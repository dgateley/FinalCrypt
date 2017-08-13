using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalCrypt.Theme;
using FinalCrypt.DB;

namespace FinalCrypt.Forms
{
    public partial class frmRegister : Form
    {
        private bool passwordVisible;

        public bool PasswordVisible
        {
            get { return passwordVisible; }

            set
            {
                passwordVisible = value;
                txtPassword.textBox.UseSystemPasswordChar = value;
            }
        }

        public frmRegister()
        {
            InitializeComponent();

            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = false;
            windowSettings.CloseType = ThemeWindowCommands.CloseTypes.Close;

            ThemeStyling.Style(this, windowSettings);

            PasswordVisible = false;

            txtPassword.AddButton();

            btnRegister.BackColor = ThemeSettings.ButtonBackgroundColor;
        }

        // Handle drawing
        private void frmRegister_Paint(object sender, PaintEventArgs e)
        {
            ThemeDrawing.DrawWindowHandle(this);
        }

        // Handle dragging
        private void frmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeInteraction.Drag(this, e);
        }

        // Register the user
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate input
            if (txtUsername.textBox.Text == "" || txtPassword.textBox.Text == "")
            {
                MessageBox.Show("Please fill out both fields", "Invalid Registration");
                return;
            }

            bool success = DBOperations.AttemptRegister(txtUsername.textBox.Text, txtPassword.textBox.Text);

            if (success)
            {
                MessageBox.Show("User account has been registered. You may now login.");
                Close();
            }
        }
    }
}
