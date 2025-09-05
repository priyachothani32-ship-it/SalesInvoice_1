/* Hashing Key */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace DatabaseConfiguration
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnm.Text))
            {
                MessageBox.Show("Please enter Username");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                MessageBox.Show("Please enter Password");
                return;
            }

            // 🔐 Encrypt password before sending to DB
            //string encryptedPassword = EncryptionHelper.Encrypt(txtPwd.Text);

            //using (SqlConnection con = new SqlConnection(CommClass.Connection))
            //{
            try
            {
                sqlparam logCredt = new sqlparam();
                logCredt.status = "Select";
                logCredt.Username = txtUnm.Text.Trim();
                logCredt.Password = txtPwd.Text.Trim();

                DataTable dt = CommonHelper.GetDataTable("LoginCredential", logCredt);


                /*
                👉 So summary:
                SQL only checks username.
                C# verifies password using the hash.
                */
                if (dt.Rows.Count > 0)
                {
                    string storedHash = dt.Rows[0]["Password"].ToString();

                    //if (EncryptionHelper.VerifyPassword(txtPwd.Text.Trim(), storedHash))
                    if (EncryptionHelper_new.Decrypt(storedHash) == txtPwd.Text.Trim())
                    {
                        //MessageBox.Show("Login Successful!");
                        this.Hide();
                        SalesInvoiceCustomerListPage nextPage = new SalesInvoiceCustomerListPage();
                        nextPage.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                        txtPwd.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username");
                    txtUnm.Clear();
                    txtPwd.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed:\n" + ex.Message);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnShowPwd.Image = Properties.Resources.hidden;
            btnShowPwd.Text = "";
        }

        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            txtPwd.UseSystemPasswordChar = !txtPwd.UseSystemPasswordChar;

            if (txtPwd.UseSystemPasswordChar)
                btnShowPwd.Image = Properties.Resources.hidden;
            else
                btnShowPwd.Image = Properties.Resources.eye;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private void linkForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //    this.Hide();                 // hide this one first
            //    ForgetPasswordForm f1 = new ForgetPasswordForm();
            //    f1.ShowDialog();            // show modal
            //    this.Close();

            if (string.IsNullOrWhiteSpace(txtUnm.Text.Trim()))
            {
                MessageBox.Show("Please enter your username before resetting password.");
                return;
            }

            string username = txtUnm.Text.Trim();

            this.Hide();

            ForgetPasswordForm f1 = new ForgetPasswordForm(username); // ✅ Pass username
            f1.ShowDialog();

            this.Close();


            //try
            //{
            //    sqlparam logCredt = new sqlparam();
            //    logCredt.status = "change";
            //    logCredt.Username = txtUnm.Text.Trim();
            //    logCredt.Password = EncryptionHelper_new.Encrypt(txtPwd.Text.Trim());
            //    DataTable dt = CommonHelper.GetDataTable("LoginCredential", logCredt);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Connection Failed:\n" + ex.Message);
            //}
        }
    }
}
