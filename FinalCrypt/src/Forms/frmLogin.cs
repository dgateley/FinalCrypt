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
    public partial class frmLogin : Form
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


        public frmLogin()
        {
            InitializeComponent();
            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = false;

            ThemeStyling.Style(this, windowSettings);

            PasswordVisible = false;

            txtPassword.AddButton();
            btnRegister.BackColor = ThemeSettings.AlternateBackgroundColor;
            btnRegister.ForeColor = ThemeSettings.PrimaryBackgroundColor;

            DBOperations.CreateConnection();
        }

        // Handle theme drawing
        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            ThemeDrawing.DrawWindowHandle(this);
        }

        // Handle window dragging
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeInteraction.Drag(this, e);
        }

        // Open registration form
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister form = new frmRegister();
            Hide();
            form.ShowDialog();
            Show();
        }

        // Attempt to login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input
            if (txtUsername.textBox.Text == "" || txtPassword.textBox.Text == "")
            {
                MessageBox.Show("Please fill out both fields.", "Invalid Login");
                return;
            }

            bool success = DBOperations.AttemptLogin(txtUsername.textBox.Text, txtPassword.textBox.Text);

            if (success)
            {
                // Open main form
            }
            else
            {
                MessageBox.Show("Invalid login.", "Login Failed");
            }
        }
    }
}
