using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace FinalCrypt.Crypto
{
    class CryptoRijndael
    {
        public static string Encrypt(FileInformation fileInformation, EncryptionSettings encryptionSettings)
        {
            RijndaelManaged cipher = new RijndaelManaged();

            cipher.Key = Encoding.ASCII.GetBytes(encryptionSettings.Key);
            cipher.IV = Encoding.ASCII.GetBytes(encryptionSettings.IV);

            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform rijndaelEncryptor = cipher.CreateEncryptor();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelEncryptor, CryptoStreamMode.Write);
            byte[] bytes = Encoding.ASCII.GetBytes(File.ReadAllText(fileInformation.Path));

            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encryptedBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            return Convert.ToBase64String(encryptedBytes, 0, encryptedBytes.Length);

        }

        public static string Decrypt(FileInformation fileInformation, EncryptionSettings encryptionSettings)
        {
            RijndaelManaged cipher = new RijndaelManaged();

            cipher.Key = Encoding.ASCII.GetBytes(encryptionSettings.Key);
            cipher.IV = Encoding.ASCII.GetBytes(encryptionSettings.IV);

            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform rijndaelDecryptor = cipher.CreateDecryptor();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelDecryptor, CryptoStreamMode.Write);
            string text = "";

            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(File.ReadAllText(fileInformation.Path));

                cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                cryptoStream.FlushFinalBlock();

                byte[] bytes = memoryStream.ToArray();

                text = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
            }
            finally
            {
                memoryStream.Close();
                cryptoStream.Close();
            }

            return text;
        }
    }
}
