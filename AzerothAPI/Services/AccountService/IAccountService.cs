using AzerothAPI.Data.Models.Auth;

namespace AzerothAPI.Services
{
    public interface IAccountService
    {
        Account? Auth(string username, string password);
        Task<bool> CreateAccount(string username, string password, string email);
        Account? GetByUsername(string username);
        string GetUsername(int id);
        Task<bool> UpdateUsername(string oldUser, string newUser, string currentPassword);
        bool UserOrEmailAvailable(string? username, string? email);
        Task<bool> UpdatePassword(string oldUser, string currentPassword, string newPassword);
        Task<bool> UpdateEmail(string user, string pass, string newEmail);
    }
}