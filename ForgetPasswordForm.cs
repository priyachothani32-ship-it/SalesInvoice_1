using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConfiguration
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        public ForgetPasswordForm(string username)
        {
            InitializeComponent();
            txtUnm.Text = username;   // auto-fill
            txtUnm.ReadOnly = true;   // make uneditable
        }


        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {
            Pctshow_HideNewPwd.Image = Properties.Resources.hidden;
            Pctshow_HideNewPwd.Text = "";

            Pctshow_HideResetPwd.Image = Properties.Resources.hidden;
            Pctshow_HideResetPwd.Text = "";

        }

        private void show_HideNewPwdImg_Click(object sender, EventArgs e)
        {
            txtNewPwd.UseSystemPasswordChar = !txtNewPwd.UseSystemPasswordChar;

            if (txtNewPwd.UseSystemPasswordChar)
                Pctshow_HideNewPwd.Image = Properties.Resources.hidden;
            else
                Pctshow_HideNewPwd.Image = Properties.Resources.eye;
        }


        private void btnRestPwd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNewPwd.Text) ||
                    string.IsNullOrWhiteSpace(txtResetPwd.Text))
                {
                    MessageBox.Show("Please enter and confirm your new password.");
                    return;
                }

                if (txtNewPwd.Text != txtResetPwd.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                // prepare parameters
                sqlparam logCredt = new sqlparam();
                logCredt.status = "ChangePassword";
                logCredt.Username = txtUnm.Text.Trim();
                logCredt.Password = EncryptionHelper_new.Encrypt(txtNewPwd.Text.Trim());

                // call DB
                DataTable dt = CommonHelper.GetDataTable("LoginCredential", logCredt);

                //MessageBox.Show("Password changed successfully!");

                // ✅ Close reset form and go to login
                this.Hide();
                LoginForm login = new LoginForm();
                login.ShowDialog();  // modal login form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed:\n" + ex.Message);
            }
        }

        private void btnshow_HideResetPwd_Click_1(object sender, EventArgs e)
        {
            txtResetPwd.UseSystemPasswordChar = !txtResetPwd.UseSystemPasswordChar;

            if (txtResetPwd.UseSystemPasswordChar)
                Pctshow_HideResetPwd.Image = Properties.Resources.hidden;
            else
                Pctshow_HideResetPwd.Image = Properties.Resources.eye;
        }

        private void PreviousImg_Click(object sender, EventArgs e)
        {
            this.Hide();                 // hide this one first
            LoginForm l1 = new LoginForm();
            l1.ShowDialog();             // show modal
            this.Close();

        }
    }
}
