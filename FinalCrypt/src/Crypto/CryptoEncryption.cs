using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalCrypt.DB;

namespace FinalCrypt.Crypto
{
    class CryptoEncryption
    {
        public static void EncryptFile(FileInformation file, EncryptionSettings settings)
        {
            if (file.IsEncrypted)
            {
                if (settings.Type == "Rijndael")
                {
                    CryptoRijndael.Decrypt(file, settings);
                }
                else
                {
                    CryptoTripleDES.Decrypt(file, settings);
                }
            }
            else
            {
                if (settings.Type == "Rijndael")
                {
                    CryptoRijndael.Encrypt(file, settings);
                }
                else
                {
                    CryptoTripleDES.Encrypt(file, settings);
                }
            }

            // Update the file in the database
            DBOperations.AddFile(file);
        }
    }
}
