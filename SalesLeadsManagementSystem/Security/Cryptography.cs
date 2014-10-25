using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SalesLeadsManagementSystem.Security
{

    /// <summary>
    /// Class for securing sensitive data.
    /// </summary>
    class Cryptography
    {
        /// <summary>
        /// Generate MD5 hash code
        /// </summary>
        /// <param name="value">string for encrypt</param>
        /// <returns>return the encrypted value</returns>
        public static string Encrypt(string value)
        {
            
            byte[] hashBytes = MD5CryptoServiceProvider.Create().ComputeHash(Encoding.UTF8.GetBytes(value));
            
            StringBuilder hashString = new StringBuilder();

            
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashString.Append(hashBytes[i].ToString("x2"));
            }

            return hashString.ToString();
        }
        /// <summary>
        /// Generate MD5 hash code with multiple hashing
        /// </summary>
        /// <param name="value">string for encrypt</param>
        /// <param name="encryptLevel">Number of iterations to encrypt</param>
        /// <returns>return the encrypted value</returns>
        public static string Encrypt(string value,int encryptLevel)
        {
            StringBuilder hashBuilder = new StringBuilder(value);
            string hashString =value;
            for (int i = 0; i < encryptLevel; i++)
            {
                hashBuilder.Replace(hashString, Encrypt(hashString));
                hashString = hashBuilder.ToString();
            }

            return hashString;
        }
    }
}
