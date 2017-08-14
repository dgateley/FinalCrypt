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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = false;
            windowSettings.CloseType = ThemeWindowCommands.CloseTypes.Exit;

            ThemeStyling.Style(this, windowSettings);
        }

        // Set up initial data
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Update time
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Start();
            timer.Tick += (s, e2) =>
            {
                lblStatus.Text = "Connection to server successful (" + DateTime.Now.ToString("h:mm:ss tt") + ")";
            };


            // Load files
            DBOperations.GetMyFiles();
        }

        // Drawing
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            ThemeDrawing.DrawWindowHandle(this);
            ThemeDrawing.DrawMainHeader(this);
            ThemeDrawing.DrawMainTreeBorder(this);
        }

        // Dragging
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeInteraction.Drag(this, e);
        }

        // Load files panel
        private void btnMyFiles_Click(object sender, EventArgs e)
        {
            pnlMyFiles.Visible = true;
            pnlSettings.Visible = false;
            pnlStatistics.Visible = false;         
        }

        // Load Stats panel
        private void btnStats_Click(object sender, EventArgs e)
        {
            pnlMyFiles.Visible = false;
            pnlSettings.Visible = false;
            pnlStatistics.Visible = true;
        }

        // Load settings panel
        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlMyFiles.Visible = false;
            pnlSettings.Visible = true;
            pnlStatistics.Visible = false;
        }

        // Load about form
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
