using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Design
{
    internal class ShortenURL
    {
        public void Short(string url)
        {
            byte[] data = Encoding.UTF8.GetBytes(url);

            StringBuilder builder = new StringBuilder();
            using (MD5 md = MD5.Create())
            {
                var result = md.ComputeHash(data);
                foreach (var item in result)
                {
                    builder.Append(item.ToString("x2"));
                }
                Console.WriteLine(Convert.FromBase64String(builder.ToString()));
                Console.WriteLine(builder.ToString());
            }

            builder.Clear();
            using (SHA256 sha256 = SHA256.Create())
            {
                var result = sha256.ComputeHash(data);
                foreach (var item in result)
                {
                    builder.Append(item.ToString("x2"));
                }
                Console.WriteLine(builder.ToString());
            }
        }
    }
}
