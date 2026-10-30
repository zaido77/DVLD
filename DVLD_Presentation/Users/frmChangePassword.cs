using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DVLD_Presentation.Users
{
    public partial class frmChangePassword : frmBase
    {
        private int _UserID = -1;

        clsUser _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            txtCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                clsMessageBox.ShowError("Could not Find User with id = " + _UserID);
                this.Close();
                return;
            }

            ctrlUserCard1.LoadUserInfo(_User.ID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                return;
            }

            _User.Password = txtNewPassword.Text.Trim();

            if (_User.Save())
            {
                clsMessageBox.ShowInfo("Password Changed Successfully.", "Saved");

                _ResetDefaultValues();
            }
            else
            {
                clsMessageBox.ShowError("Failed to Change Password");
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current Password cannot be blank!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current Password is wrong!");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password cannot be blank!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }

            if (txtNewPassword.Text.Trim() == txtCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password cannot be equal the current password!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
    }
}
