namespace FinalCrypt.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMyFiles = new FinalCrypt.Controls.FinalCryptMyFilesPanel();
            this.btnAbout = new FinalCrypt.Controls.FInalCryptPanelButton();
            this.btnSettings = new FinalCrypt.Controls.FInalCryptPanelButton();
            this.btnStats = new FinalCrypt.Controls.FInalCryptPanelButton();
            this.btnMyFiles = new FinalCrypt.Controls.FInalCryptPanelButton();
            this.pnlSettings = new FinalCrypt.Controls.FinalCryptSettingsPanel();
            this.pnlStatistics = new FinalCrypt.Controls.FinalCryptStatisticsPanel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.stsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.ImageLocation = "../../resources/LogoSmall.png";
            this.imgLogo.Location = new System.Drawing.Point(291, 35);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(146, 29);
            this.imgLogo.TabIndex = 4;
            this.imgLogo.TabStop = false;
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsMain.Location = new System.Drawing.Point(0, 497);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(754, 22);
            this.stsMain.TabIndex = 5;
            this.stsMain.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // pnlMyFiles
            // 
            this.pnlMyFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMyFiles.Location = new System.Drawing.Point(172, 70);
            this.pnlMyFiles.Name = "pnlMyFiles";
            this.pnlMyFiles.Size = new System.Drawing.Size(579, 427);
            this.pnlMyFiles.TabIndex = 6;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnAbout.Location = new System.Drawing.Point(6, 222);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(160, 41);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnSettings.Location = new System.Drawing.Point(6, 175);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(160, 41);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnStats.Location = new System.Drawing.Point(6, 128);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(160, 41);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnMyFiles
            // 
            this.btnMyFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMyFiles.FlatAppearance.BorderSize = 0;
            this.btnMyFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyFiles.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMyFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnMyFiles.Location = new System.Drawing.Point(6, 81);
            this.btnMyFiles.Name = "btnMyFiles";
            this.btnMyFiles.Size = new System.Drawing.Size(160, 41);
            this.btnMyFiles.TabIndex = 0;
            this.btnMyFiles.Text = "My Files";
            this.btnMyFiles.UseVisualStyleBackColor = false;
            this.btnMyFiles.Click += new System.EventHandler(this.btnMyFiles_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Location = new System.Drawing.Point(173, 70);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(575, 430);
            this.pnlSettings.TabIndex = 7;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Location = new System.Drawing.Point(173, 70);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(575, 430);
            this.pnlStatistics.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 519);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlMyFiles);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnMyFiles);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalCrypt";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.FInalCryptPanelButton btnMyFiles;
        private Controls.FInalCryptPanelButton btnStats;
        private Controls.FInalCryptPanelButton btnSettings;
        private Controls.FInalCryptPanelButton btnAbout;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private Controls.FinalCryptMyFilesPanel pnlMyFiles;
        private Controls.FinalCryptSettingsPanel pnlSettings;
        private Controls.FinalCryptStatisticsPanel pnlStatistics;
    }
}