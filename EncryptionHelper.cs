//Use Hashing  

/*
 * One-way transformation  You cannot decrypt it back. ,Always produces the same output for the same input.,Used for passwords.
 */

using System;
using System.Security.Cryptography;
using System.Text;

namespace DatabaseConfiguration
{
    public static class EncryptionHelper
    {
        /// Hash password using SHA256
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash); // store in DB
            }
        }

        /// Verify password by comparing hash
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = HashPassword(enteredPassword);
            return enteredHash == storedHash? true : false;
        }
    }
}




