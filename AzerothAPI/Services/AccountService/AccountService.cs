using AzerothAPI.Data.Context;
using AzerothAPI.Data.ModelExtensions;
using AzerothAPI.Data.Models.Auth;
using AzerothAPI.Helpers;
using System.Security.Cryptography;

namespace AzerothAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly AuthDb _authContext;

        public AccountService(AuthDb context)
        {
            _authContext = context;
        }

        public Account? GetByUsername(string username)
        {
            return _authContext.Accounts.FirstOrDefault(a => a.Username == username);
        }

        public Account? Auth(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var account = GetByUsername(username);
                if (account != null)
                {
                    if (CryptoHelper.CalculateVerifier(username, password, account.Salt).SequenceEqual(account.Verifier))
                    {
                        return account;
                    }
                }
            }
            return null;
        }

        public bool UserOrEmailAvailable(string? username, string? email)
        {
            return !_authContext.Accounts.Any(a => (!string.IsNullOrEmpty(username) && a.Username == username) ||
                                                     (!string.IsNullOrEmpty(email) && a.Email == email));
        }

        public async Task<bool> CreateAccount(string username, string password, string email)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (UserOrEmailAvailable(username, email))
                {
                    byte[] salt = new byte[32];
                    RandomNumberGenerator rng = RandomNumberGenerator.Create();
                    rng.GetBytes(salt);
                    byte[] verifier = CryptoHelper.CalculateVerifier(username, password, salt);
                    _authContext.Accounts.Add(new Account
                    {
                        Username = username,
                        Salt = salt,
                        Verifier = verifier,
                        Email = email
                    });
                    await _authContext.SaveChangesAsync();
                    result = true;
                }
            }
            return result;
        }

        public string GetUsername(int id)
        {
            return _authContext.Accounts.First(u => u.Id == id).Username;
        }

        public async Task<bool> UpdateUsername(string oldUser, string newUser, string currentPassword)
        {
            bool result = false;
            var account = Auth(oldUser, currentPassword);
            if (account != null)
            {
                if (UserOrEmailAvailable(newUser, null))
                {
                    byte[] salt = new byte[32];
                    RandomNumberGenerator rng = RandomNumberGenerator.Create();
                    rng.GetBytes(salt);
                    byte[] verifier = CryptoHelper.CalculateVerifier(newUser, currentPassword, salt);

                    account.Username = newUser;
                    account.Salt = salt;
                    account.Verifier = verifier;

                    _authContext.Update(account);
                    await _authContext.SaveChangesAsync();
                    result = true;
                }
            }

            return result;
        }

        public async Task<bool> UpdatePassword(string oldUser, string currentPassword, string newPassword)
        {
            bool result = false;
            var account = Auth(oldUser, currentPassword);
            if (account != null)
            {
                byte[] salt = new byte[32];
                RandomNumberGenerator rng = RandomNumberGenerator.Create();
                rng.GetBytes(salt);
                byte[] verifier = CryptoHelper.CalculateVerifier(oldUser, newPassword, salt);

                account.Salt = salt;
                account.Verifier = verifier;

                _authContext.Update(account);
                await _authContext.SaveChangesAsync();
                result = true;
            }

            return result;
        }

        public async Task<bool> UpdateEmail(string user, string pass, string newEmail)
        {
            bool result = false;
            var account = Auth(user, pass);
            if (account != null)
            {
                if (UserOrEmailAvailable(null, newEmail))
                {
                    account.Email = newEmail;

                    _authContext.Update(account);
                    await _authContext.SaveChangesAsync();
                    result = true;
                }
            }

            return result;
        }
    }
}