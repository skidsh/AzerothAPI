using System.Globalization;
using System.Numerics;
using System.Text;

namespace AzerothAPI.Helpers
{
    public static class CryptoHelper
    {
        public static byte[] CalculateVerifier(string username, string password, byte[] salt)
        {
            BigInteger g = 7;
            BigInteger N = BigInteger.Parse("0894B645E89E1535BBDAD5B8B290650530801B18EBFBF5E8FAB3C82872A3E9BB7", NumberStyles.AllowHexSpecifier);

            var sha1 = System.Security.Cryptography.SHA1.Create();
            var h1 = sha1.ComputeHash(Encoding.Default.GetBytes($"{username}:{password}".ToUpper()));
            var h2 = sha1.ComputeHash(salt.Concat(h1).ToArray());
            h2 = h2.Reverse().ToArray();
            BigInteger h2num = BigInteger.Parse($"0{BitConverter.ToString(h2).Replace("-", "")}", NumberStyles.AllowHexSpecifier);
            BigInteger verifyNum = BigInteger.ModPow(g, h2num, N);
            var verifier = verifyNum.ToByteArray().Take(32).ToArray();
            if (verifier.Length != 32)
            {
                Array.Resize(ref verifier, 32);
            }

            return verifier;
        }

    }
}
