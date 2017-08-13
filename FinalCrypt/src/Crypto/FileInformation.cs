using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCrypt.Crypto
{
    public class FileInformation
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Encyrption { get; set; }
        public bool IsEncrypted { get; set; }
        public bool OnThisMachine { get; set; }
        public int DBID { get; set; }

        public static List<FileInformation> myFiles = new List<FileInformation>();
    }
}
