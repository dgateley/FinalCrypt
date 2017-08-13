namespace FinalCrypt.Controls
{
    partial class FinalCryptMyFilesPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbFiles = new System.Windows.Forms.ListBox();
            this.pnlFileSettings = new System.Windows.Forms.Panel();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new FinalCrypt.Controls.FinalCryptButton();
            this.btnEncrypt = new FinalCrypt.Controls.FinalCryptButton();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.pnlAdvInfo = new System.Windows.Forms.Panel();
            this.lblFileSizeAnswer = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblFileSize = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblExtensionAnswer = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblExtension = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblPathAnswer = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblPath = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblThisMachineAnswer = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblTypeAnswer = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblIsEncryptedAnswer = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblThisMachine = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblType = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblIsEncrypted = new FinalCrypt.Controls.FinalCryptLabel();
            this.btnAddFile = new FinalCrypt.Controls.FinalCryptButton();
            this.lblFileSettings = new FinalCrypt.Controls.FinalCryptLabel();
            this.lblFiles = new FinalCrypt.Controls.FinalCryptLabel();
            this.pnlFileSettings.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.pnlAdvInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbFiles
            // 
            this.lsbFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbFiles.FormattingEnabled = true;
            this.lsbFiles.ItemHeight = 21;
            this.lsbFiles.Location = new System.Drawing.Point(3, 52);
            this.lsbFiles.Name = "lsbFiles";
            this.lsbFiles.Size = new System.Drawing.Size(262, 298);
            this.lsbFiles.TabIndex = 0;
            this.lsbFiles.SelectedIndexChanged += new System.EventHandler(this.lsbFiles_SelectedIndexChanged);
            // 
            // pnlFileSettings
            // 
            this.pnlFileSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFileSettings.Controls.Add(this.grpActions);
            this.pnlFileSettings.Controls.Add(this.grpInfo);
            this.pnlFileSettings.Location = new System.Drawing.Point(272, 52);
            this.pnlFileSettings.Name = "pnlFileSettings";
            this.pnlFileSettings.Size = new System.Drawing.Size(294, 368);
            this.pnlFileSettings.TabIndex = 1;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnDelete);
            this.grpActions.Controls.Add(this.btnEncrypt);
            this.grpActions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.Location = new System.Drawing.Point(8, 245);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(272, 104);
            this.grpActions.TabIndex = 6;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnDelete.Location = new System.Drawing.Point(20, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnEncrypt.Location = new System.Drawing.Point(151, 48);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(106, 35);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.pnlAdvInfo);
            this.grpInfo.Controls.Add(this.lblThisMachineAnswer);
            this.grpInfo.Controls.Add(this.lblTypeAnswer);
            this.grpInfo.Controls.Add(this.lblIsEncryptedAnswer);
            this.grpInfo.Controls.Add(this.lblThisMachine);
            this.grpInfo.Controls.Add(this.lblType);
            this.grpInfo.Controls.Add(this.lblIsEncrypted);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(8, 16);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(272, 223);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // pnlAdvInfo
            // 
            this.pnlAdvInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdvInfo.Controls.Add(this.lblFileSizeAnswer);
            this.pnlAdvInfo.Controls.Add(this.lblFileSize);
            this.pnlAdvInfo.Controls.Add(this.lblExtensionAnswer);
            this.pnlAdvInfo.Controls.Add(this.lblExtension);
            this.pnlAdvInfo.Controls.Add(this.lblPathAnswer);
            this.pnlAdvInfo.Controls.Add(this.lblPath);
            this.pnlAdvInfo.Location = new System.Drawing.Point(11, 113);
            this.pnlAdvInfo.Name = "pnlAdvInfo";
            this.pnlAdvInfo.Size = new System.Drawing.Size(255, 100);
            this.pnlAdvInfo.TabIndex = 6;
            // 
            // lblFileSizeAnswer
            // 
            this.lblFileSizeAnswer.AutoSize = true;
            this.lblFileSizeAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFileSizeAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSizeAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblFileSizeAnswer.Location = new System.Drawing.Point(38, 59);
            this.lblFileSizeAnswer.Name = "lblFileSizeAnswer";
            this.lblFileSizeAnswer.Size = new System.Drawing.Size(0, 17);
            this.lblFileSizeAnswer.TabIndex = 5;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFileSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblFileSize.Location = new System.Drawing.Point(4, 59);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(34, 17);
            this.lblFileSize.TabIndex = 4;
            this.lblFileSize.Text = "Size:";
            // 
            // lblExtensionAnswer
            // 
            this.lblExtensionAnswer.AutoSize = true;
            this.lblExtensionAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblExtensionAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtensionAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblExtensionAnswer.Location = new System.Drawing.Point(67, 39);
            this.lblExtensionAnswer.Name = "lblExtensionAnswer";
            this.lblExtensionAnswer.Size = new System.Drawing.Size(0, 17);
            this.lblExtensionAnswer.TabIndex = 3;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblExtension.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblExtension.Location = new System.Drawing.Point(5, 39);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(66, 17);
            this.lblExtension.TabIndex = 2;
            this.lblExtension.Text = "Extension:";
            // 
            // lblPathAnswer
            // 
            this.lblPathAnswer.AutoSize = true;
            this.lblPathAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPathAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblPathAnswer.Location = new System.Drawing.Point(41, 17);
            this.lblPathAnswer.Name = "lblPathAnswer";
            this.lblPathAnswer.Size = new System.Drawing.Size(0, 17);
            this.lblPathAnswer.TabIndex = 1;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblPath.Location = new System.Drawing.Point(4, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(36, 17);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path:";
            // 
            // lblThisMachineAnswer
            // 
            this.lblThisMachineAnswer.AutoSize = true;
            this.lblThisMachineAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblThisMachineAnswer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblThisMachineAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblThisMachineAnswer.Location = new System.Drawing.Point(126, 75);
            this.lblThisMachineAnswer.Name = "lblThisMachineAnswer";
            this.lblThisMachineAnswer.Size = new System.Drawing.Size(29, 20);
            this.lblThisMachineAnswer.TabIndex = 5;
            this.lblThisMachineAnswer.Text = "No";
            // 
            // lblTypeAnswer
            // 
            this.lblTypeAnswer.AutoSize = true;
            this.lblTypeAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTypeAnswer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTypeAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblTypeAnswer.Location = new System.Drawing.Point(91, 52);
            this.lblTypeAnswer.Name = "lblTypeAnswer";
            this.lblTypeAnswer.Size = new System.Drawing.Size(29, 20);
            this.lblTypeAnswer.TabIndex = 4;
            this.lblTypeAnswer.Text = "No";
            // 
            // lblIsEncryptedAnswer
            // 
            this.lblIsEncryptedAnswer.AutoSize = true;
            this.lblIsEncryptedAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblIsEncryptedAnswer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIsEncryptedAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblIsEncryptedAnswer.Location = new System.Drawing.Point(86, 29);
            this.lblIsEncryptedAnswer.Name = "lblIsEncryptedAnswer";
            this.lblIsEncryptedAnswer.Size = new System.Drawing.Size(29, 20);
            this.lblIsEncryptedAnswer.TabIndex = 3;
            this.lblIsEncryptedAnswer.Text = "No";
            // 
            // lblThisMachine
            // 
            this.lblThisMachine.AutoSize = true;
            this.lblThisMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblThisMachine.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblThisMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblThisMachine.Location = new System.Drawing.Point(7, 75);
            this.lblThisMachine.Name = "lblThisMachine";
            this.lblThisMachine.Size = new System.Drawing.Size(118, 20);
            this.lblThisMachine.TabIndex = 2;
            this.lblThisMachine.Text = "On this machine:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblType.Location = new System.Drawing.Point(7, 52);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Encryption:";
            // 
            // lblIsEncrypted
            // 
            this.lblIsEncrypted.AutoSize = true;
            this.lblIsEncrypted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblIsEncrypted.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIsEncrypted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblIsEncrypted.Location = new System.Drawing.Point(7, 29);
            this.lblIsEncrypted.Name = "lblIsEncrypted";
            this.lblIsEncrypted.Size = new System.Drawing.Size(78, 20);
            this.lblIsEncrypted.TabIndex = 0;
            this.lblIsEncrypted.Text = "Encrypted:";
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddFile.FlatAppearance.BorderSize = 0;
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFile.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnAddFile.Location = new System.Drawing.Point(164, 339);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(101, 32);
            this.btnAddFile.TabIndex = 4;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lblFileSettings
            // 
            this.lblFileSettings.AutoSize = true;
            this.lblFileSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFileSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblFileSettings.Location = new System.Drawing.Point(276, 19);
            this.lblFileSettings.Name = "lblFileSettings";
            this.lblFileSettings.Size = new System.Drawing.Size(87, 30);
            this.lblFileSettings.TabIndex = 3;
            this.lblFileSettings.Text = "Settings";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFiles.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblFiles.Location = new System.Drawing.Point(3, 19);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(53, 30);
            this.lblFiles.TabIndex = 2;
            this.lblFiles.Text = "Files";
            // 
            // FinalCryptMyFilesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.lblFileSettings);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.pnlFileSettings);
            this.Controls.Add(this.lsbFiles);
            this.Name = "FinalCryptMyFilesPanel";
            this.Size = new System.Drawing.Size(575, 430);
            this.Load += new System.EventHandler(this.FinalCryptMyFilesPanel_Load);
            this.pnlFileSettings.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.pnlAdvInfo.ResumeLayout(false);
            this.pnlAdvInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFiles;
        private System.Windows.Forms.Panel pnlFileSettings;
        private FinalCryptLabel lblFiles;
        private FinalCryptLabel lblFileSettings;
        private System.Windows.Forms.GroupBox grpInfo;
        private FinalCryptLabel lblThisMachineAnswer;
        private FinalCryptLabel lblTypeAnswer;
        private FinalCryptLabel lblIsEncryptedAnswer;
        private FinalCryptLabel lblThisMachine;
        private FinalCryptLabel lblType;
        private FinalCryptLabel lblIsEncrypted;
        private FinalCryptButton btnAddFile;
        private System.Windows.Forms.GroupBox grpActions;
        private FinalCryptButton btnEncrypt;
        private System.Windows.Forms.Panel pnlAdvInfo;
        private FinalCryptLabel lblFileSizeAnswer;
        private FinalCryptLabel lblFileSize;
        private FinalCryptLabel lblExtensionAnswer;
        private FinalCryptLabel lblExtension;
        private FinalCryptLabel lblPathAnswer;
        private FinalCryptLabel lblPath;
        private FinalCryptButton btnDelete;
    }
}
