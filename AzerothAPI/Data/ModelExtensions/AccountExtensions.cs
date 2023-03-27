using AzerothAPI.Data.Models.Auth;

namespace AzerothAPI.Data.ModelExtensions
{
    public static class AccountExtensions
    {
        public static bool IsIpAllowed(this Account account, string ip)
        {
            return account.Locked <= 0 || account.LastAttemptIp == ip;
        }
    }
}
