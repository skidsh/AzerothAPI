using AzerothAPI.Data.Context;
using AzerothAPI.Dto.Char;
using AzerothAPI.Data.ModelExtensions;
using AzerothAPI.DTO;
using AzerothAPI.Data.DBC;
using System.Xml;
using System.Text.Json;
using AzerothAPI.Data.Models.Char;

namespace AzerothAPI.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly CharDb _charDb;
        private readonly AuthDb _authDb;
        private readonly WorldDb _worldDb;
        private int PLAYER_FLAGS_HIDE_CLOAK = 0x00000800;
        private int PLAYER_FLAGS_HIDE_HELM = 0x00000400;

        public CharacterService(CharDb charDb, AuthDb authDb, WorldDb worldDb)
        {
            _charDb = charDb;
            _authDb = authDb;
            _worldDb = worldDb;
        }

        public CharSearchResult SearchCharacterPaged(string nameSearch, int skip, int take)
        {
            var chars = _charDb.Characters.Where(c => c.Name.ToLower().Contains(nameSearch.ToLower()) && c.DeleteDate == null);
            var count = Math.Min(chars.Count(), 100);
            var pagedChars = chars.Skip(skip).Take(take).ToList();
            var charSpecs = pagedChars.Select(c => new
            {
                c.Guid,
                Specs = c.DetectSpec(_charDb)
            });

            var result = pagedChars.Select(pc => new { 
                Char = pc,
                Specs = charSpecs.Any(s => s.Guid == pc.Guid) ? charSpecs.Where(s => s.Guid == pc.Guid).First().Specs : new List<TalentSpec>(),
                ArenaInfo = pc.GetArenaTeamInfo(_charDb)
            });

            return new CharSearchResult
            {
                Characters = result.Select(r => new CharResult {
                    Name = r.Char.Name,
                    Race = r.Char.Race,
                    Class = r.Char.Class,
                    Gender = r.Char.Gender,
                    Spec = r.Specs.First(s => s.Active).TalentTrees.OrderByDescending(x => x.Talents?.Count).First().Name,
                    TalentSpecs = r.Specs,
                    ArenaTeams = r.ArenaInfo
                }).ToList(),
                Count = count
            };
        }
        
        private static int GetDisplayIdForItemId(int itemId)
        {
            // Old unused wowhead data parse

            //itemdisplayid result = new itemdisplayid();
            //using var http = new HttpClient();
            //var response = await http.GetAsync($"https://www.wowhead.com/item={itemId}&xml");
            //var data = await response.Content.ReadAsStringAsync();
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.LoadXml(data);
            //XmlNodeList json = xmlDoc.GetElementsByTagName("json");
            //if (json != null && json.Count > 0)
            //{
            //    var dataF = JsonSerializer.Deserialize<itemdisplayid>("{" + json[0].InnerText + "}");
            //    if (dataF != null)
            //        result = dataF;
            //}
            //return result;

            var idi = ItemDisplayInfos.data.Where(idi => idi.itemId == itemId).FirstOrDefault();
            return (idi != null) ? idi.displayId : 0;
        }

        public CharSearchResult GetCharsForAccount(string accountName)
        {
            var result = new CharSearchResult();
            var account = _authDb.Accounts.Single(a => a.Username == accountName);
            if (account != null)
            {
                var chars = _charDb.Characters.Where(c => c.Account == account.Id).ToList();
                if (chars.Any())
                {
                    var charSpecs = chars.Select(c => new
                    {
                        c.Guid,
                        Specs = c.DetectSpec(_charDb)
                    });

                    var finalChars = chars.Select(pc => new {
                        Char = pc,
                        Specs = charSpecs.Any(s => s.Guid == pc.Guid) ? charSpecs.Where(s => s.Guid == pc.Guid).First().Specs : new List<TalentSpec>(),
                        ArenaInfo = pc.GetArenaTeamInfo(_charDb)
                    });

                    result.Characters = finalChars.Select(r => new CharResult
                    {
                        Name = r.Char.Name,
                        Race = r.Char.Race,
                        Class = r.Char.Class,
                        Gender = r.Char.Gender,
                        Spec = r.Specs.First(s => s.Active).TalentTrees.OrderByDescending(x => x.Talents?.Count).First().Name,
                        TalentSpecs = r.Specs,
                        ArenaTeams = r.ArenaInfo
                    }).ToList();
                    result.Count = result.Characters.Count;
                }
            }
            return result;
        }

        public async Task<CharacterDetail> GetCharByName(string characterName)
        {
            CharacterDetail result = null;
            var character = _charDb.Characters.Where(c => c.Name.ToLower().Equals(characterName.ToLower()) && c.DeleteDate == null).FirstOrDefault();
            if (character != null)
            {
                var charStats = _charDb.CharacterStats.Where(cs => cs.Guid == character.Guid).FirstOrDefault();
                bool hideHelm = (character.PlayerFlags & PLAYER_FLAGS_HIDE_HELM) > 0;
                bool hideCloak = (character.PlayerFlags & PLAYER_FLAGS_HIDE_CLOAK) > 0;

                var guildMember = _charDb.GuildMembers.Where(gm => gm.Guid == character.Guid).FirstOrDefault();
                var guildName = string.Empty;
                if (guildMember != null)
                {
                    var guild = _charDb.Guilds.Where(g => g.Guildid == guildMember.Guildid).FirstOrDefault();
                    if (guild != null)
                    {
                        guildName = guild.Name;
                    }
                }

                List<Item> finalItems = await GetItems(character, hideHelm, hideCloak);
                List<TalentSpec> specs = character.DetectSpec(_charDb);

                result = new CharacterDetail
                {
                    Name = character.Name,
                    Race = character.Race,
                    Gender = character.Gender,
                    Class = character.Class,
                    Guild = guildName,
                    Title = CharTitles.data.Where(t => t.MaskID == character.ChosenTitle).FirstOrDefault()?.MaleTitle,
                    Items = finalItems,
                    Skin = character.Skin,
                    Face = character.Face,
                    HairColor = character.HairColor,
                    HairStyle = character.HairStyle,
                    FaceStyle = character.FacialStyle,
                    Stats = charStats != null ? charStats.ToDictionary() : new Dictionary<string, int>(),
                    ArenaTeams = character.GetArenaTeamInfo(_charDb),
                    Specs = specs,
                    SpecName = specs.First(s => s.Active).TalentTrees?.OrderByDescending(x => x.Talents?.Count).First().Name
                };
            }
            return result;
        }

        private async Task<List<Item>> GetItems(Character? character, bool hideHelm, bool hideCloak)
        {
            if (character == null) { throw new ArgumentNullException(nameof(character)); }

            var items = _charDb.CharacterInventories.Where(ci => ci.Guid == character.Guid && ci.Slot < 19 && ci.Bag == 0);
            var tempItems = _charDb.ItemInstances.Join(items, ii => ii.Guid, i => i.Item, (ii, i) => new
            {
                Id = ii.ItemEntry,
                i.Slot,
                EnchantString = ii.Enchantments,
                ii.Transmog
            }).ToList();

            var finalItems = new List<Item>();

            foreach (var i in tempItems)
            {
                List<int> enchantList = i.EnchantString.Split(' ').Where(e => !string.IsNullOrEmpty(e)).Select(int.Parse).ToList();
                var finalItem = new Item
                {
                    Id = (int)i.Id,
                    Slot = i.Slot,
                    Enchant = enchantList[0],
                    Gem1 = enchantList[6],
                    Gem2 = enchantList[9],
                    Gem3 = enchantList[12],
                    Transmog = (int)i.Transmog,
                    EquipedSetItems = new List<int>()
                };

                finalItem.DisplayId = GetDisplayIdForItemId(i.Transmog != 0 ? (int)i.Transmog : (int)i.Id);
                finalItem.DisplaySlot = i.Slot == 15 ? 21 : i.Slot == 16 ? 22 : i.Slot + 1;

                finalItem.FindWeaponEnchantVisual();

                if ((i.Slot == 0 && hideHelm) || (i.Slot == 14 && hideCloak))
                {
                    finalItem.DisplayId = 0;
                }

                var itemTemplate = _worldDb.ItemTemplates.Where(it => it.Entry == i.Id).FirstOrDefault();
                if (itemTemplate != null)
                {
                    var itemSet = ItemSets.data.Where(iss => iss.Id == itemTemplate.Itemset).FirstOrDefault();
                    if (itemSet != null)
                    {
                        foreach (var linkedItem in itemSet.LinkedItems)
                        {
                            if (tempItems.Any(iss => iss.Id == linkedItem))
                            {
                                finalItem.EquipedSetItems.Add((int)linkedItem);
                            }
                        }
                    }
                }

                finalItems.Add(finalItem);
            }

            return finalItems;
        }
    }
}