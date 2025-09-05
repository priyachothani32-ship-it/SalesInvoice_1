
namespace DatabaseConfiguration
{
    partial class ForgetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtUnm = new System.Windows.Forms.TextBox();
            this.lblUnm = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.Pctshow_HideResetPwd = new System.Windows.Forms.PictureBox();
            this.btnRestPwd = new System.Windows.Forms.Button();
            this.txtResetPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.Pctshow_HideNewPwd = new System.Windows.Forms.PictureBox();
            this.lblReEnterPwd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChagepwd = new System.Windows.Forms.Label();
            this.PreviousImg = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctshow_HideResetPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pctshow_HideNewPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Snow;
            this.pnlMain.Controls.Add(this.pnlUsername);
            this.pnlMain.Controls.Add(this.pnlPassword);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.lblChagepwd);
            this.pnlMain.Location = new System.Drawing.Point(-2, -2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(289, 333);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlUsername
            // 
            this.pnlUsername.Controls.Add(this.txtUnm);
            this.pnlUsername.Controls.Add(this.lblUnm);
            this.pnlUsername.Location = new System.Drawing.Point(14, 93);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(263, 63);
            this.pnlUsername.TabIndex = 13;
            // 
            // txtUnm
            // 
            this.txtUnm.Location = new System.Drawing.Point(16, 35);
            this.txtUnm.Multiline = true;
            this.txtUnm.Name = "txtUnm";
            this.txtUnm.Size = new System.Drawing.Size(201, 28);
            this.txtUnm.TabIndex = 0;
            // 
            // lblUnm
            // 
            this.lblUnm.AutoSize = true;
            this.lblUnm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnm.Location = new System.Drawing.Point(14, 9);
            this.lblUnm.Name = "lblUnm";
            this.lblUnm.Size = new System.Drawing.Size(84, 22);
            this.lblUnm.TabIndex = 3;
            this.lblUnm.Text = "Usename";
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.lblNewPwd);
            this.pnlPassword.Controls.Add(this.PreviousImg);
            this.pnlPassword.Controls.Add(this.Pctshow_HideResetPwd);
            this.pnlPassword.Controls.Add(this.btnRestPwd);
            this.pnlPassword.Controls.Add(this.txtResetPwd);
            this.pnlPassword.Controls.Add(this.txtNewPwd);
            this.pnlPassword.Controls.Add(this.Pctshow_HideNewPwd);
            this.pnlPassword.Controls.Add(this.lblReEnterPwd);
            this.pnlPassword.Location = new System.Drawing.Point(14, 162);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(263, 172);
            this.pnlPassword.TabIndex = 12;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPwd.Location = new System.Drawing.Point(13, 10);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(130, 22);
            this.lblNewPwd.TabIndex = 2;
            this.lblNewPwd.Text = "New password";
            // 
            // Pctshow_HideResetPwd
            // 
            this.Pctshow_HideResetPwd.Location = new System.Drawing.Point(224, 93);
            this.Pctshow_HideResetPwd.Name = "Pctshow_HideResetPwd";
            this.Pctshow_HideResetPwd.Size = new System.Drawing.Size(36, 20);
            this.Pctshow_HideResetPwd.TabIndex = 10;
            this.Pctshow_HideResetPwd.TabStop = false;
            this.Pctshow_HideResetPwd.Click += new System.EventHandler(this.btnshow_HideResetPwd_Click_1);
            // 
            // btnRestPwd
            // 
            this.btnRestPwd.BackColor = System.Drawing.Color.Blue;
            this.btnRestPwd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestPwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestPwd.Location = new System.Drawing.Point(19, 119);
            this.btnRestPwd.Name = "btnRestPwd";
            this.btnRestPwd.Size = new System.Drawing.Size(203, 40);
            this.btnRestPwd.TabIndex = 3;
            this.btnRestPwd.Text = "Reset Password";
            this.btnRestPwd.UseVisualStyleBackColor = false;
            this.btnRestPwd.Click += new System.EventHandler(this.btnRestPwd_Click);
            // 
            // txtResetPwd
            // 
            this.txtResetPwd.Location = new System.Drawing.Point(19, 93);
            this.txtResetPwd.Name = "txtResetPwd";
            this.txtResetPwd.Size = new System.Drawing.Size(201, 20);
            this.txtResetPwd.TabIndex = 2;
            this.txtResetPwd.UseSystemPasswordChar = true;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(17, 35);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(201, 20);
            this.txtNewPwd.TabIndex = 1;
            this.txtNewPwd.UseSystemPasswordChar = true;
            // 
            // Pctshow_HideNewPwd
            // 
            this.Pctshow_HideNewPwd.Location = new System.Drawing.Point(224, 35);
            this.Pctshow_HideNewPwd.Name = "Pctshow_HideNewPwd";
            this.Pctshow_HideNewPwd.Size = new System.Drawing.Size(36, 20);
            this.Pctshow_HideNewPwd.TabIndex = 8;
            this.Pctshow_HideNewPwd.TabStop = false;
            this.Pctshow_HideNewPwd.Click += new System.EventHandler(this.show_HideNewPwdImg_Click);
            // 
            // lblReEnterPwd
            // 
            this.lblReEnterPwd.AutoSize = true;
            this.lblReEnterPwd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEnterPwd.Location = new System.Drawing.Point(15, 68);
            this.lblReEnterPwd.Name = "lblReEnterPwd";
            this.lblReEnterPwd.Size = new System.Drawing.Size(207, 22);
            this.lblReEnterPwd.TabIndex = 4;
            this.lblReEnterPwd.Text = "Re- enter new password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblChagepwd
            // 
            this.lblChagepwd.AutoSize = true;
            this.lblChagepwd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChagepwd.ForeColor = System.Drawing.Color.Red;
            this.lblChagepwd.Location = new System.Drawing.Point(69, 11);
            this.lblChagepwd.Name = "lblChagepwd";
            this.lblChagepwd.Size = new System.Drawing.Size(160, 19);
            this.lblChagepwd.TabIndex = 0;
            this.lblChagepwd.Text = "Change your password";
            // 
            // PreviousImg
            // 
            this.PreviousImg.Image = ((System.Drawing.Image)(resources.GetObject("PreviousImg.Image")));
            this.PreviousImg.Location = new System.Drawing.Point(224, 119);
            this.PreviousImg.Name = "PreviousImg";
            this.PreviousImg.Size = new System.Drawing.Size(36, 40);
            this.PreviousImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviousImg.TabIndex = 7;
            this.PreviousImg.TabStop = false;
            this.PreviousImg.Click += new System.EventHandler(this.PreviousImg_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 332);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ForgetPasswordForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctshow_HideResetPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pctshow_HideNewPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChagepwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Button btnRestPwd;
        private System.Windows.Forms.Label lblReEnterPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.PictureBox Pctshow_HideNewPwd;
        private System.Windows.Forms.PictureBox PreviousImg;
        private System.Windows.Forms.PictureBox Pctshow_HideResetPwd;
        private System.Windows.Forms.TextBox txtResetPwd;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.TextBox txtUnm;
        private System.Windows.Forms.Label lblUnm;
        private System.Windows.Forms.Panel pnlPassword;
    }
}
