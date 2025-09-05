using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DatabaseConfiguration
{
    class EncryptionHelper_new
    {
        // Your secret key (must be 16, 24, or 32 bytes for AES)
        private static readonly string secretKey = "MySuperSecretKey123";
        private static readonly string secretIV = "MySecretIV1234567";   // 16 bytes for AES IV

        public static string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            using (Aes aes = Aes.Create())
            {
                // derive key/iv the same way as your Decrypt()
                using (var sha = SHA256.Create())
                    aes.Key = sha.ComputeHash(Encoding.UTF8.GetBytes(secretKey ?? ""));

                using (var md5 = MD5.Create())
                    aes.IV = md5.ComputeHash(Encoding.UTF8.GetBytes(secretIV ?? ""));

                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                        sw.Flush();            // push StreamWriter buffer into CryptoStream
                        cs.FlushFinalBlock();  // finalize encryption so bytes are in ms
                    }

                    byte[] encrypted = ms.ToArray(); // now contains full encrypted data
                    return Convert.ToBase64String(encrypted);
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText)) return string.Empty;

            using (Aes aes = Aes.Create())
            {
                using (var sha = SHA256.Create())
                    aes.Key = sha.ComputeHash(Encoding.UTF8.GetBytes(secretKey ?? ""));
                using (var md5 = MD5.Create())
                    aes.IV = md5.ComputeHash(Encoding.UTF8.GetBytes(secretIV ?? ""));

                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    byte[] buffer = Convert.FromBase64String(cipherText);
                    using (var ms = new MemoryStream(buffer))
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (var sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }

    }
}
