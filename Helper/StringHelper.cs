using System.Security.Cryptography;
using System.Text;

namespace TestOkta7.Helper
{
    public static class StringHelper
    {
        public static string Hash(this string raw, bool simpleVersion = true)
        {
            using var algorith = SHA512.Create();
            var hashedString = BitConverter.ToString(algorith.ComputeHash(Encoding.UTF8.GetBytes(raw)));
            return simpleVersion ? hashedString.Replace("-", "").ToLower() : hashedString;
        }
    }
}
