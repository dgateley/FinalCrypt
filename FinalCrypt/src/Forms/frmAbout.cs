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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();

            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = false;
            windowSettings.CloseType = ThemeWindowCommands.CloseTypes.Close;

            ThemeStyling.Style(this, windowSettings);
        }

        // Drawing
        private void frmAbout_Paint(object sender, PaintEventArgs e)
        {
            ThemeDrawing.DrawWindowHandle(this);
        }

        // Dragging
        private void frmAbout_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeInteraction.Drag(this, e);
        }
    }
}
