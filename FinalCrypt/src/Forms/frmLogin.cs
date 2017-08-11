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
    }
}
