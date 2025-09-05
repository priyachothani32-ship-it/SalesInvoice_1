
namespace DatabaseConfiguration
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUnm = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUnm = new System.Windows.Forms.Label();
            this.btnShowPwd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlLoginForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkForgetPwd = new System.Windows.Forms.LinkLabel();
            this.PictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pnlLoginForm.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnm
            // 
            this.txtUnm.Location = new System.Drawing.Point(27, 107);
            this.txtUnm.Multiline = true;
            this.txtUnm.Name = "txtUnm";
            this.txtUnm.Size = new System.Drawing.Size(201, 30);
            this.txtUnm.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(27, 174);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(201, 20);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(25, 149);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(90, 22);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(29, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUnm
            // 
            this.lblUnm.AutoSize = true;
            this.lblUnm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnm.Location = new System.Drawing.Point(23, 82);
            this.lblUnm.Name = "lblUnm";
            this.lblUnm.Size = new System.Drawing.Size(92, 22);
            this.lblUnm.TabIndex = 0;
            this.lblUnm.Text = "Username";
            // 
            // btnShowPwd
            // 
            this.btnShowPwd.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPwd.Location = new System.Drawing.Point(234, 174);
            this.btnShowPwd.Name = "btnShowPwd";
            this.btnShowPwd.Size = new System.Drawing.Size(36, 20);
            this.btnShowPwd.TabIndex = 3;
            this.btnShowPwd.UseVisualStyleBackColor = false;
            this.btnShowPwd.Click += new System.EventHandler(this.btnShowPwd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(130, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLoginForm
            // 
            this.pnlLoginForm.Controls.Add(this.panel3);
            this.pnlLoginForm.Location = new System.Drawing.Point(-1, -1);
            this.pnlLoginForm.Name = "pnlLoginForm";
            this.pnlLoginForm.Size = new System.Drawing.Size(289, 316);
            this.pnlLoginForm.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.linkForgetPwd);
            this.panel3.Controls.Add(this.PictureBoxUser);
            this.panel3.Controls.Add(this.txtUnm);
            this.panel3.Controls.Add(this.lblUnm);
            this.panel3.Controls.Add(this.txtPwd);
            this.panel3.Controls.Add(this.btnShowPwd);
            this.panel3.Controls.Add(this.lblPwd);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 316);
            this.panel3.TabIndex = 8;
            // 
            // linkForgetPwd
            // 
            this.linkForgetPwd.AutoSize = true;
            this.linkForgetPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkForgetPwd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgetPwd.Location = new System.Drawing.Point(38, 273);
            this.linkForgetPwd.Name = "linkForgetPwd";
            this.linkForgetPwd.Size = new System.Drawing.Size(171, 17);
            this.linkForgetPwd.TabIndex = 5;
            this.linkForgetPwd.TabStop = true;
            this.linkForgetPwd.Text = " Click here to Forget Password";
            this.linkForgetPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgetPwd_LinkClicked);
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxUser.Image")));
            this.PictureBoxUser.Location = new System.Drawing.Point(104, 13);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.Size = new System.Drawing.Size(67, 40);
            this.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUser.TabIndex = 8;
            this.PictureBoxUser.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 308);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLoginForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnlLoginForm.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUnm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUnm;
        private System.Windows.Forms.Button btnShowPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PictureBoxUser;
        private System.Windows.Forms.LinkLabel linkForgetPwd;
    }
}
