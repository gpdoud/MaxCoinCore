using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoinLib.Utility {

    public static class Sha256 {

        public static string Hash(string data) {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] hashedBytes = sha256.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach(var b in hashedBytes) {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        public static bool IsValidHash(string hash, int difficulty = 4) {
            var hashPrefix = "".PadRight(25, '0').Substring(0, difficulty);
            return hash.StartsWith(hashPrefix);
        }
    }
}
