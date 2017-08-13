namespace FinalCrypt.Forms
{
    partial class frmCrypto
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
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rdoRijndael = new System.Windows.Forms.RadioButton();
            this.rdoTripleDES = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new FinalCrypt.Controls.FinalCryptButton();
            this.txtPassword = new FinalCrypt.Controls.FinalCryptTextBox();
            this.lblPassword = new FinalCrypt.Controls.FinalCryptLabel();
            this.grpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdoTripleDES);
            this.grpType.Controls.Add(this.rdoRijndael);
            this.grpType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.Location = new System.Drawing.Point(97, 14);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(200, 100);
            this.grpType.TabIndex = 0;
            this.grpType.TabStop = false;
            this.grpType.Text = "Encryption Type";
            // 
            // rdoRijndael
            // 
            this.rdoRijndael.AutoSize = true;
            this.rdoRijndael.Location = new System.Drawing.Point(23, 29);
            this.rdoRijndael.Name = "rdoRijndael";
            this.rdoRijndael.Size = new System.Drawing.Size(84, 25);
            this.rdoRijndael.TabIndex = 0;
            this.rdoRijndael.TabStop = true;
            this.rdoRijndael.Text = "Rijndael";
            this.rdoRijndael.UseVisualStyleBackColor = true;
            // 
            // rdoTripleDES
            // 
            this.rdoTripleDES.AutoSize = true;
            this.rdoTripleDES.Location = new System.Drawing.Point(23, 60);
            this.rdoTripleDES.Name = "rdoTripleDES";
            this.rdoTripleDES.Size = new System.Drawing.Size(94, 25);
            this.rdoTripleDES.TabIndex = 1;
            this.rdoTripleDES.TabStop = true;
            this.rdoTripleDES.Text = "TripleDES";
            this.rdoTripleDES.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnEncrypt.Location = new System.Drawing.Point(136, 194);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(122, 43);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPassword.Location = new System.Drawing.Point(97, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(1);
            this.txtPassword.PasswordHidden = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblPassword.Location = new System.Drawing.Point(18, 137);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // frmCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 253);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.grpType);
            this.Name = "frmCrypto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalCrypt - Crypto";
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rdoTripleDES;
        private System.Windows.Forms.RadioButton rdoRijndael;
        private Controls.FinalCryptLabel lblPassword;
        private Controls.FinalCryptTextBox txtPassword;
        private Controls.FinalCryptButton btnEncrypt;
    }
}