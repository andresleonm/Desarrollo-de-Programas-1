using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Services
{
    class HashService
    {
        private string salt = "9aff81a04032f4387e353179e92e12743edbcc6e";
        private HashAlgorithm hasher = new SHA1CryptoServiceProvider();

        public HashService()
        {
                
        }

        public string HashText(string text)
        {
            byte[] textWithSaltBytes = Encoding.UTF8.GetBytes(string.Concat(text, salt));
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);
            return Convert.ToBase64String(hashedBytes);
        }
    }


}
