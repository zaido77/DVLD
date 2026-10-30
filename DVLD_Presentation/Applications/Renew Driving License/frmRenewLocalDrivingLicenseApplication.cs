using DVLD_Business;
using DVLD_Presentation.Global.Classes;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.Licenses;
using DVLD_Presentation.Licenses.Local_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Applications.Renew_License
{
    public partial class frmRenewLocalDrivingLicenseApplication : frmBase
    {
        clsLicense _OldLicense;
        clsLicense _NewLicense;

        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void _ResetApplicationInfo()
        {
            lblExpirationDate.Text = "[????]";
            lblLicenseFees.Text = "[$$$$]";
            lblTotalFees.Text = "[$$$$]";
            txtNotes.Clear();
        }

        private void ctrlLocalLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            llShowLicensesHistory.Enabled = llShowNewLicenseInfo.Enabled = btnRenew.Enabled = false;

            lblOldLicenseID.Text = LicenseID.ToString();
            llShowLicensesHistory.Enabled = (LicenseID != -1);

            if (LicenseID == -1)
            {
                _ResetApplicationInfo();
                return;
            }
                

            _OldLicense = ctrlLocalLicenseCardWithFilter1.SelectedLicenseInfo;

            lblExpirationDate.Text = clsFormat.DateToString(DateTime.Now.AddYears(_OldLicense.LicenseClassInfo.DefaultValidityLength));
            lblLicenseFees.Text = _OldLicense.LicenseClassInfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = _OldLicense.Notes;

            if (!_OldLicense.IsActive)
            {
                clsMessageBox.ShowError("Selected License is not active, choose another one.");
                return;
            }

            if (_OldLicense.IsDetained)
            {
                clsMessageBox.ShowError("Selected License is Detained, choose another one.");
                return;
            }

            if (!_OldLicense.IsExpired)
            {
                clsMessageBox.ShowError("Selected License is not yet expired, it will expire on:\n" +
                    $"{clsFormat.DateToString(_OldLicense.ExpirationDate)}");
                return;
            }

            btnRenew.Enabled = true;
            txtNotes.Focus();
        }

        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            DateTime DateNow = DateTime.Now;

            lblApplicationDate.Text = clsFormat.DateToString(DateNow);
            lblIssueDate.Text = clsFormat.DateToString(DateNow);
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicenseService).Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowPersonLicenseHistory(_OldLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLocalLicenseInfo(_NewLicense.ID);
            frm.ShowDialog();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            _NewLicense = _OldLicense.RenewLicense(txtNotes.Text.Trim(), clsGlobal.CurrentUser.ID);

            if (_NewLicense != null)
            {
                lblRenewLicenseApplicationID.Text = _NewLicense.ApplicationID.ToString();
                lblRenewedLicenseID.Text = _NewLicense.ID.ToString();

                clsMessageBox.ShowInfo($"License Renewed Succesfully with ID = [{_NewLicense.ID}]");

                ctrlLocalLicenseCardWithFilter1.FilterEnabled = false;
                llShowNewLicenseInfo.Enabled = true;
                btnRenew.Enabled = false;
            }
            else
            {
                clsMessageBox.ShowError("Failed to Renew License");
            }
        }

        private void frmRenewLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlLocalLicenseCardWithFilter1.FilterFocus();
        }
    }
}
