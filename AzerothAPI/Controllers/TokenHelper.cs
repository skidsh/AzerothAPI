using AzerothAPI.Services;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AzerothAPI.Controllers
{
    internal static class TokenHelper
    {

        public static string GetToken(string username, IConfiguration config)
        {
            string result;
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtSecret = config.GetSection("JwtSecret").Value;
            var key = Encoding.ASCII.GetBytes(jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            result = tokenHandler.WriteToken(token);
            return result;
        }

        public static string ValidateToken(string token, IConfiguration config)
        {
            if (token == null)
                return string.Empty;

            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtSecret = config.GetSection("JwtSecret").Value;
            var key = Encoding.ASCII.GetBytes(jwtSecret);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var user = jwtToken.Claims.First(x => x.Type == "unique_name").Value;

                return user;
            }
            catch
            {
                // return null if validation fails
                return string.Empty;
            }
        }

        public static int GetUserIdFromJWT(string jwt, IConfiguration config, IAccountService accountService)
        {
            var account = accountService.GetByUsername(ValidateToken(jwt, config));
            return account != null ? (int)account.Id : 0;
        }
    }
}