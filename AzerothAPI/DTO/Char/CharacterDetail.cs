using AzerothAPI.Dto.Char;

namespace AzerothAPI.DTO
{
    public partial class CharacterDetail
    {
        public string? Name { get; set; }
        public byte Race { get; set; }
        public byte Gender { get; set; }
        public byte Class { get; set; }
        public string? Guild { get; set; }
        public string? Title { get; set; }
        public byte Skin { get; set; }
        public byte Face { get; set; }
        public byte HairStyle { get; set; }
        public byte HairColor { get; set; }
        public byte FaceStyle { get; set; }
        public List<Item>? Items { get; set; }
        public Dictionary<string, int>? Stats { get; set; }
        public List<ArenaTeamInfo>? ArenaTeams { get; set; }
        public string? SpecName { get; set; }
        public List<TalentSpec>? Specs {get; set; }
    }
}
