using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD5andSalting;
using System.Security.Cryptography;

namespace CheckPasswords
{
    public partial class PasswordChecker : Form
    {
        SecureData secureData;
        MD5 md5Hash;
        public PasswordChecker()
        {
            InitializeComponent();
        }

        private void BtnHashwithMD5_Click(object sender, EventArgs e)
        {
            try
            {
                Initialise();
                MD5 md5Hash = MD5.Create();
                txtHashedPassword.Text = EncryptDecrypt.GetMd5Hash(md5Hash, txtPasswordtoHash.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHashMD5Salt_Click(object sender, EventArgs e)
        {
            try
            {
                Initialise();
                md5Hash = MD5.Create();
                secureData = new SecureData();
                secureData = EncryptDecrypt.GetMd5HashWithSalt(md5Hash, txtPasswordtoHash.Text);
                txtHashedPassword.Text = secureData.MD5Hash;
                txtSalt.Text = secureData.Salt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHashMD5SaltPepper_Click(object sender, EventArgs e)
        {
            try
            {

                Initialise();
                md5Hash = MD5.Create();
                string userName = "nikhil";
                secureData = new SecureData();
                secureData = EncryptDecrypt.GetMd5HashWithSaltAndPepper(md5Hash, txtPasswordtoHash.Text, userName);
                txtHashedPassword.Text = secureData.MD5Hash;
                txtSalt.Text = secureData.Salt;
                txtPepper.Text = userName;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Initialise ()
        {
            txtHashedPassword.Text = "";
            txtSalt.Text = "";
            txtPepper.Text = "";
            lblCheck.Visible = false;
        }

        private void BtnCheckwithMD5_Click(object sender, EventArgs e)
        {
            try
            {
                md5Hash = MD5.Create();
                if (EncryptDecrypt.VerifyMd5Hash(md5Hash, txtCheckPassword.Text, txtHashedPassword.Text))
                    lblCheck.Text = "Verified";
                else
                    lblCheck.Text = "Not Verified";
                lblCheck.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCheckwithSalt_Click(object sender, EventArgs e)
        {
            try
            {
                md5Hash = MD5.Create();
                if (EncryptDecrypt.VerifyMd5HashWithSalt(md5Hash, txtCheckPassword.Text, txtHashedPassword.Text, txtSalt.Text))
                    lblCheck.Text = "Verified";
                else
                    lblCheck.Text = "Not Verified";
                lblCheck.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCheckwithSaltPepper_Click(object sender, EventArgs e)
        {
            try
            {
                md5Hash = MD5.Create();
                if (EncryptDecrypt.VerifyMd5HashWithSaltAndPepper(md5Hash, txtCheckPassword.Text, txtHashedPassword.Text, txtSalt.Text, txtPepper.Text))
                    lblCheck.Text = "Verified";
                else
                    lblCheck.Text = "Not Verified";
                lblCheck.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
