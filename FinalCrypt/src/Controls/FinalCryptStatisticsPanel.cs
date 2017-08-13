using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalCrypt.Crypto;
using FinalCrypt.DB;

namespace FinalCrypt.Controls
{
    public partial class FinalCryptStatisticsPanel : UserControl
    {
        public FinalCryptStatisticsPanel()
        {
            if (DesignMode)
                return;

            InitializeComponent();
        }

        // Load data
        private void FinalCryptStatisticsPanel_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            List<FileInformation> allFiles = DBOperations.GetAllFiles();
            int rijndael = 0;
            int tripleDES = 0;
            int encrypted = 0;
            int totalRijndael = 0;
            int totalTripleDES = 0;
            int totalEncryped = 0;


            foreach (var file in FileInformation.myFiles)
            {
                if (file.IsEncrypted)
                    encrypted++;

                if (file.Encyrption == "Rijndael")
                    rijndael++;
                else if (file.Encyrption == "TripleDES")
                    tripleDES++;
            }

            foreach (var file in allFiles)
            {
                if (file.IsEncrypted)
                    totalEncryped++;

                if (file.Encyrption == "Rijndael")
                    totalRijndael++;
                else if (file.Encyrption == "TripleDES")
                    totalTripleDES++;
            }

            lblFilesAnswer.Text = FileInformation.myFiles.Count.ToString();
            lblEncryptedFilesAnswer.Text = encrypted.ToString();
            lblRijndaelAnswer.Text = rijndael.ToString();
            lblTripleDESFilesAnswer.Text = tripleDES.ToString();

            lblTotalFilesAnswer.Text = allFiles.Count.ToString();
            lblTotalEncryptedFilesAnswer.Text = totalEncryped.ToString();
            lblTotalRijndaelFilesAnswer.Text = totalRijndael.ToString();
            lblTotalTripleDESFilesAnswer.Text = totalTripleDES.ToString();
        }
    }
}
