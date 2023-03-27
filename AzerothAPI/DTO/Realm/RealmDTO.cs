namespace AzerothAPI.DTO.Realm
{
    public partial class RealmDTO
    {
        public string? Name { get; set; }
        public string? Population { get; set; }
        public DateTime StartTime { get; set; }
        public bool Online { get; set; }
        public int OnlinePlayers { get; set; } = 0;
        public int MaxPlayers { get; set; } = 0;
        public double AverageLatency { get; internal set; }
        public string Uptime { get; internal set; }
    }
}
