using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalCrypt.Theme;
using FinalCrypt.DB;

namespace FinalCrypt.Controls
{
    public partial class FinalCryptSettingsPanel : UserControl
    {
        public FinalCryptSettingsPanel()
        {
            InitializeComponent();

            btnChangeUsername.BackColor = ThemeSettings.AlternateBackgroundColor;
            btnChangeUsername.ForeColor = ThemeSettings.PrimaryBackgroundColor;
            btnChangePassword.BackColor = ThemeSettings.AlternateBackgroundColor;
            btnChangePassword.ForeColor = ThemeSettings.PrimaryBackgroundColor;
        }

        // Set up data
        private void FinalCryptSettingsPanel_Load(object sender, EventArgs e)
        {
            txtUsername.textBox.Text = DBUserInformation.Username;
        }

        // Attempt to change username
        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change your username?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DBOperations.ChangeUsername(txtUsername.textBox.Text);
                MessageBox.Show("Username changed.", "Success");
            }
        }

        // Attempt to change password
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change your password?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DBOperations.ChangePassword(txtPassword.textBox.Text);
                MessageBox.Show("Password changed.", "Success");
            }
        }
    }
}
