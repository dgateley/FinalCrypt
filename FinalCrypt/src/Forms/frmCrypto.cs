using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalCrypt.Crypto;
using FinalCrypt.Theme;

namespace FinalCrypt.Forms
{
    public partial class frmCrypto : Form
    {
        private FileInformation fileToEncrypt;

        public FileInformation FileToEncrypt
        {
            get { return fileToEncrypt; }

            set
            {
                fileToEncrypt = value;
                btnEncrypt.Text = fileToEncrypt.IsEncrypted ? "Decrypt" : "Encrypt";
            }
        }


        public frmCrypto()
        {
            InitializeComponent();

            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = false;
            windowSettings.CloseType = ThemeWindowCommands.CloseTypes.Close;

            ThemeStyling.Style(this, windowSettings);

            btnEncrypt.BackColor = ThemeSettings.AlternateBackgroundColor;
            btnEncrypt.ForeColor = ThemeSettings.PrimaryBackgroundColor;
        }

        // Call the encryption method
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Validate input
            if (txtPassword.textBox.Text != "")
            {
                EncryptionSettings settings = new EncryptionSettings();
                settings.Password = txtPassword.textBox.Text;

                if (rdoRijndael.Checked)
                    settings.Type = "Rijndael";
                else
                    settings.Type = "TripleDES";

                CryptoEncryption.EncryptFile(FileToEncrypt, settings);

                Close();
            }
        }
    }
}
