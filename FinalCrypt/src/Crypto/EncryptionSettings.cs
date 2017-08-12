using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCrypt.Crypto
{
    class EncryptionSettings
    {
        public string Type { get; set; }
        public string Key { get; set; }
        public string IV { get; set; }
    }
}
