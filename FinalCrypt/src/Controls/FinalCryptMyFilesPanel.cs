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
using FinalCrypt.Theme;
using FinalCrypt.DB;

namespace FinalCrypt.Controls
{
    public partial class FinalCryptMyFilesPanel : UserControl
    {
        public FinalCryptMyFilesPanel()
        {
            InitializeComponent();

            lsbFiles.Font = ThemeSettings.TextFontSmall;
            pnlFileSettings.Visible = false;
            btnAddFile.BackColor = ThemeSettings.AlternateBackgroundColor;
            btnAddFile.ForeColor = ThemeSettings.PrimaryBackgroundColor;
            lblFileSettings.Visible = false;

        }

        // Populate list box
        private void FinalCryptMyFilesPanel_Load(object sender, EventArgs e)
        {
            foreach (FileInformation file in FileInformation.myFiles)
            {
                lsbFiles.Items.Add(file.Name);
            }

            pnlFileSettings.BackColor = ThemeSettings.PrimaryBackgroundColor;
        }

        // Update the settings panel
        private void lsbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbFiles.SelectedIndex == -1)
                return;

            pnlFileSettings.Visible = true;
            lblFileSettings.Visible = true;

            FileInformation file = FileInformation.myFiles[lsbFiles.SelectedIndex];

            // Set label colors
            lblIsEncryptedAnswer.ForeColor = file.IsEncrypted ? ThemeSettings.LabelTrueColor : ThemeSettings.LabelFalseColor;
            lblThisMachineAnswer.ForeColor = file.OnThisMachine ? ThemeSettings.LabelTrueColor : ThemeSettings.LabelFalseColor;

            lblIsEncryptedAnswer.Text = file.IsEncrypted ? "Yes" : "No";
            lblThisMachineAnswer.Text = file.OnThisMachine ? "Yes" : "No";

            if (file.Encyrption == "None")
            {
                lblTypeAnswer.ForeColor = ThemeSettings.LabelFalseColor;
            }
            else
            {
                lblTypeAnswer.ForeColor = ThemeSettings.LabelTrueColor;
            }

            lblTypeAnswer.Text = file.Encyrption;
            lblPathAnswer.Text = file.Path;
            ToolTip pathToolTip = new ToolTip();
            pathToolTip.SetToolTip(lblPathAnswer, file.Path);
            lblExtensionAnswer.Text = System.IO.Path.GetExtension(file.Path);
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Path);

            if (file.OnThisMachine)
            {
                // Calculate human-readable file size
                string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                double len = fileInfo.Length;
                int order = 0;
                while (len >= 1024 && order < sizes.Length - 1)
                {
                    order++;
                    len = len / 1024;
                }
                lblFileSizeAnswer.Text = String.Format("{0:0.##} {1}", len, sizes[order]);
            }
            else
            {
                lblFileSizeAnswer.Text = "N/A";
            }

            btnEncrypt.Text = file.IsEncrypted ? "Decrypt" : "Encrypt";
        }

        // Add a file to the list and database
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            // File chosen by user
            if (result == DialogResult.OK)
            {
                FileInformation file = new FileInformation();
                file.Path = dialog.FileName;
                file.Name = System.IO.Path.GetFileName(file.Path);
                file.Encyrption = "None";
                file.IsEncrypted = false;
                file.OnThisMachine = true;

                FileInformation.myFiles.Add(file);
                DBOperations.AddFile(file);
                DBOperations.GetMyFiles();
                lsbFiles.Items.Clear();

                foreach (FileInformation f in FileInformation.myFiles)
                {
                    lsbFiles.Items.Add(f.Name);
                }
            }
        }

        // Open the encrypt/decrypt form
        private void btnEncrypt_Click(object sender, EventArgs e)
        {

        }

        // Delete the file from the list and database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsbFiles.SelectedIndex == -1)
                return;

            // Prompt the user first
            DialogResult result = MessageBox.Show("Are you sure you want to delete the file from the database?", "Warning", MessageBoxButtons.YesNo);
            FileInformation file = FileInformation.myFiles[lsbFiles.SelectedIndex];

            if (result == DialogResult.Yes)
            {
                DBOperations.DeleteFile(file);
                FileInformation.myFiles.Remove(file);
                lsbFiles.Items.Clear();

                foreach (FileInformation f in FileInformation.myFiles)
                {
                    lsbFiles.Items.Add(f.Name);
                }

                pnlFileSettings.Visible = false;
                lblFileSettings.Visible = false;
            }
        }
    }
}
