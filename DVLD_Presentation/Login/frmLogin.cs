using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";

            if (clsUtil.GetStoredCredentials(ref Username, ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (User == null)
            {
                txtUsername.Focus();
                clsMessageBox.ShowError("Invalid Username/Password.", "Wrong Credentials");
                return;
            }

            if (!User.IsActive)
            {
                txtUsername.Focus();
                clsMessageBox.ShowError("Your account is deactivated, Please contact your admin.", 
                    "Deactivated Account");
                return;
            }

            if (chkRememberMe.Checked)
                clsUtil.RememberUsernameAndPassword(User.Username, User.Password);
            else
                clsUtil.RememberUsernameAndPassword("", "");

            clsGlobal.CurrentUser = User;

            this.Hide();
            frmMain frm = new frmMain(this);
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
