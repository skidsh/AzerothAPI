namespace AzerothAPI.Dto.Char
{
    public class ArenaTeamInfo
    {
        public string? Name { get; set; }
        public uint TeamWeekWins { get; set; }
        public int TeamWeekLosses { get; set; }
        public uint PersonalWeekWins { get; set; }
        public int PersonalWeekLosses { get; set; }
        public uint TeamSeasonWins { get; set; }
        public int TeamSeasonLosses { get; set; }
        public uint PersonalSeasonWins { get; set; }
        public int PersonalSeasonLosses { get; set; }
        public uint TeamRating { get; set; }
        public uint PersonalRating { get; set; }
        public uint Type { get; set; }
    }
}