using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace FinalCrypt.Crypto
{
    class CryptoTripleDES
    {
        private static readonly byte[] salt = new byte[] { 0x4d, 0x52, 0x20, 0x42, 0x4f, 0x4e, 0x45, 0x53, 0x20, 0x49, 0x20, 0x57, 0x41, 0x4e, 0x54, 0x20, 0x54, 0x4f, 0x20, 0x47, 0x45, 0x54, 0x20, 0x4f, 0x46, 0x46, 0x20, 0x59, 0x4f, 0x55, 0x52, 0x20, 0x57, 0x49, 0x4c, 0x44, 0x20, 0x52, 0x49, 0x44, 0x45, };

        // Encrypt a byte array into a byte array using a key and an IV 
        public static void Encrypt(FileInformation file, EncryptionSettings settings)
        {
            try
            { 
                byte[] fileData = File.ReadAllBytes(file.Path);

                MemoryStream ms = new MemoryStream();
                TripleDES alg = TripleDES.Create();
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(settings.Password, salt);

                alg.Key = pdb.GetBytes(24);
                alg.IV = pdb.GetBytes(8);

                CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

                cs.Write(fileData, 0, fileData.Length);
                cs.Close();

                byte[] encryptedData = ms.ToArray();

                File.WriteAllBytes(file.Path, encryptedData);

                file.IsEncrypted = true;
                file.Encyrption = "TripleDES";
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Password", "Error");
            }
        }

        public static void Decrypt(FileInformation file, EncryptionSettings settings)
        {
            try
            {
                byte[] fileData = File.ReadAllBytes(file.Path);

                MemoryStream ms = new MemoryStream();
                TripleDES alg = TripleDES.Create();
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(settings.Password, salt);

                alg.Key = pdb.GetBytes(24);
                alg.IV = pdb.GetBytes(8);

                CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

                cs.Write(fileData, 0, fileData.Length);
                cs.Close();

                byte[] decryptedData = ms.ToArray();

                File.WriteAllBytes(file.Path, decryptedData);

                file.IsEncrypted = false;
                file.Encyrption = "None";
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Password", "Error");
            }
        }
    }
}
