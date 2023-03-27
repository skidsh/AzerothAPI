using AzerothAPI.Data.Context;
using AzerothAPI.DTO.Realm;

namespace AzerothAPI.Services
{
    public class ServerService : IServerService
    {
        private readonly AuthDb _authContext;
        private readonly CharDb _charContext;

        public ServerService(AuthDb authContext, CharDb charContext)
        {
            _authContext = authContext;
            _charContext = charContext;
        }

        public RealmDTO GetRealm()
        {
            var realm = _authContext.Realmlists.First();
            var uptime = _authContext.Uptimes.Where(u => u.Realmid == realm.Id).OrderByDescending(u => u.Starttime).First();
            var latencyList = _charContext.Characters.Where(a => a.Online == 1).Select(c => (int)c.Latency);
            var onlinePlayerCount = latencyList.Count();
            var averageLatency = onlinePlayerCount > 0 ? latencyList.Average() : 0;
            var uptimeTimeSpan = TimeSpan.FromSeconds(uptime.Uptime1);
            var uptimeString = string.Empty;

            if (uptimeTimeSpan.Days > 0)
            {
                uptimeString += $"{uptimeTimeSpan.Days}d ";
            }
            if (uptimeTimeSpan.Hours > 0)
            {
                uptimeString += $"{uptimeTimeSpan.Hours}h ";
            }
            if (uptimeTimeSpan.Minutes > 0)
            {
                uptimeString += $"{uptimeTimeSpan.Minutes}m ";
            }

            uptimeString += $"{uptimeTimeSpan.Seconds}s ";


            return new RealmDTO { 
                Name = realm.Name,
                Population = realm.Population >= 2.0 ? "High" : realm.Population >= 1.0 ? "Medium" : "Low",
                StartTime = DateTimeOffset.FromUnixTimeSeconds(uptime.Starttime).LocalDateTime,
                Uptime = uptimeString,
                Online = DateTime.Now.Subtract(DateTimeOffset.FromUnixTimeSeconds(uptime.Starttime).LocalDateTime.AddSeconds(uptime.Uptime1)) < TimeSpan.FromMinutes(10),
                OnlinePlayers = onlinePlayerCount,
                MaxPlayers = uptime.Maxplayers,
                AverageLatency = averageLatency
            };
        }
    }
}