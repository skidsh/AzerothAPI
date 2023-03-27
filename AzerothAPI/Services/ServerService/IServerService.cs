using AzerothAPI.DTO.Realm;

namespace AzerothAPI.Services
{
    public interface IServerService
    {
        RealmDTO GetRealm();
    }
}