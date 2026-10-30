using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class frmAddUpdateUser : frmBase
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;

        private int _UserID = -1;
        private clsUser _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                ctrlTitle1.TitleText = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

                tabLoginInfo.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                ctrlTitle1.TitleText = "Update User";
                this.Text = "Update User";

                tabLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            lblUserID.Text = "???";
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chkIsAcitve.Checked = true;
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                clsMessageBox.ShowError($"No User with ID = {_UserID}", "User Not Found");
                this.Close();
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            lblUserID.Text = _User.ID.ToString();
            txtUsername.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsAcitve.Checked = _User.IsActive;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnPersonalInfoNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonID == -1)
            {
                clsMessageBox.ShowError("Please select a Person", "Select a Person");
                ctrlPersonCardWithFilter1.FilterFocus();
                return;
            }

            if (_Mode == enMode.AddNew && clsUser.IsUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
            {
                clsMessageBox.ShowError("Selected Person already has a user, choose another one.", 
                    "Select another Person");
                ctrlPersonCardWithFilter1.FilterFocus();
                return;
            }

            tabLoginInfo.Enabled = true;
            btnSave.Enabled = true;
            this.AcceptButton = btnSave;

            tcUserInfo.SelectedTab = tcUserInfo.TabPages["tabLoginInfo"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                return;
            }

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.Username = txtUsername.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chkIsAcitve.Checked;

            if (_User.Save())
            {
                lblUserID.Text = _User.ID.ToString();
                _Mode = enMode.Update;
                ctrlTitle1.TitleText = "Update User";
                this.Text = "Update User";

                ctrlPersonCardWithFilter1.FilterEnabled = false;

                if (_User.ID == clsGlobal.CurrentUser.ID)
                    clsGlobal.CurrentUser = _User;

                clsMessageBox.ShowInfo("Data Saved Succesfully.", "Saved");
            }
            else
            {
                clsMessageBox.ShowError("Failed to Save data");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }

            if (_Mode == enMode.AddNew)
            {
                if (clsUser.IsUserExist(txtUsername.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUsername, "Username already in use, Choose another one");
                }
                else
                {
                    errorProvider1.SetError(txtUsername, null);
                }
            }
            else
            {
                if (_User.Username != txtUsername.Text.Trim() && clsUser.IsUserExist(txtUsername.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUsername, "Username already in use, Choose another one");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtUsername, null);
                }
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

    }
}
