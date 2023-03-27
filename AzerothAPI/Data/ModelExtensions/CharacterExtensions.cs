using AzerothAPI.Data.Context;
using AzerothAPI.Data.DBC;
using AzerothAPI.Data.Models.Char;
using AzerothAPI.Dto.Char;

namespace AzerothAPI.Data.ModelExtensions
{
    public static class CharacterExtensions
    {
        public static List<TalentSpec> DetectSpec(this Character character, CharDb charDb)
        {
            if (character == null) throw new ArgumentNullException(nameof(character));
            if (charDb == null) throw new ArgumentNullException(nameof(charDb));

            var result = new List<TalentSpec>();
            var spells = charDb.CharacterTalents.Where(ct => ct.Guid == character.Guid).ToList();

            if (spells.Any())
            {
                for (int spec = 0; spec < character.TalentGroupsCount; spec++)
                {
                    var SpellAndTalent = spells.Where(spell => (spell.SpecMask & (1 << spec)) > 0)
                        .Select(spell => new
                        {
                            spell,
                            Talent = Talents.data.Where(t => t.Spell == spell.Spell).First()
                        }).ToList();

                    result.Add(new TalentSpec {
                                    TalentTrees = SpellAndTalent.GroupBy(t => t.Talent.TabId)
                                            .Select(group => new TalentTree
                                            {
                                                Name = TalentTabDBC.data[group.Key],
                                                Talents = group.Select(t => (int)t.spell.Spell).ToList(),
                                            }).ToList(),
                                    Active = spec == character.ActiveTalentGroup
                    });
                }
            }

            if (!result.Any())
            {
                result.Add(new TalentSpec
                {
                    TalentTrees = new List<TalentTree> { new TalentTree { Talents = new(), Name = "None" } },
                    Active = true
                });
            }

            return result;
        }

        public static List<ArenaTeamInfo> GetArenaTeamInfo(this Character character, CharDb charDb)
        {
            if (character == null) throw new ArgumentNullException(nameof(character));
            if (charDb == null) throw new ArgumentNullException(nameof(charDb));

            var result = new List<ArenaTeamInfo>();
            var arenaTeams = charDb.ArenaTeamMembers.Where(atm => atm.Guid == character.Guid);
            if (arenaTeams.Any())
            {
                var arenaTeamsAndBracket = charDb.ArenaTeams.Join(arenaTeams, at => at.ArenaTeamId, atm => atm.ArenaTeamId, (at, atm) =>
                new {
                    at.Type,
                    at.Name,
                    TeamSeasonWins = at.SeasonWins,
                    TeamSeasonLosses = at.SeasonGames-at.SeasonWins,
                    PersonalSeasonWins = atm.SeasonWins,
                    PersonalSeasonLosses = atm.SeasonGames - atm.SeasonWins,
                    TeamWeekWins = at.WeekWins,
                    TeamWeekLosses = at.SeasonGames - at.WeekWins,
                    PersonalWeekWins = atm.WeekWins,
                    PersonalWeekLosses = atm.WeekGames - atm.WeekWins,
                    at.Rating,
                    atm.PersonalRating
                });

                result = arenaTeamsAndBracket.Select(atb => new ArenaTeamInfo
                {
                    Name = atb.Name,
                    Type = atb.Type,
                    TeamRating = atb.Rating,
                    PersonalRating = (uint)atb.PersonalRating,
                    TeamSeasonLosses = atb.TeamSeasonLosses,
                    TeamSeasonWins = atb.TeamSeasonWins,
                    TeamWeekLosses = atb.TeamWeekLosses,
                    TeamWeekWins = atb.TeamWeekWins,
                    PersonalSeasonLosses = atb.PersonalSeasonLosses,
                    PersonalSeasonWins = atb.PersonalSeasonWins,
                    PersonalWeekLosses = atb.PersonalWeekLosses,
                    PersonalWeekWins = atb.PersonalWeekWins,
                }).ToList();
            }
            return result;
        }
    }
}
