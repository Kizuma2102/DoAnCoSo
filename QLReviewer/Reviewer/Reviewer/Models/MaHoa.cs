using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer.Models
{
    public static class MaHoa
    {
        public static string ToMD5(this string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in bHash)
                sbHash.Append(String.Format("{0:x2}", b));
            return sbHash.ToString();
        }
        public static string ToSHA512(this string input)
        {
            using (var algorithm = SHA512.Create())
            {
                var hashedBytes =
               algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashedBytes).Replace("-","").ToLower();
            }
        }
    }

}

