using AzerothAPI.Dto.Char;

namespace AzerothAPI.DTO
{
    public partial class CharResult
    {
        public string? Name { get; set; }
        public byte Race { get; set; }
        public byte Gender { get; set; }
        public byte Class { get; set; }
        public string Spec { get; set; }
        public List<TalentSpec> TalentSpecs { get; set; }
        public List<ArenaTeamInfo> ArenaTeams { get; set; }
    }
}
