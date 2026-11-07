using DVLD_Business;
using DVLD_Presentation.Global.Classes;
using DVLD_Presentation.Global_Classes;
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

namespace DVLD_Presentation.Licenses.International_Licenses
{
    public partial class frmNewInternationalLicenseApplication : frmBase
    {
        clsInternationalLicense _InternationalLicense = new clsInternationalLicense();
        clsLicense _SelectedLocalLicense;

        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsFormat.DateToString(_InternationalLicense.ApplicationInfo.ApplicationDate);
            lblIssueDate.Text = clsFormat.DateToString(_InternationalLicense.IssueDate);
            lblFees.Text = _InternationalLicense.ApplicationInfo.ApplicationTypeInfo.Fees.ToString();
            lblExpirationDate.Text = clsFormat.DateToString(_InternationalLicense.ExpirationDate);
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        private void ctrlLocalLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            llShowLicensesHistory.Enabled = llShowLicenseInfo.Enabled = btnIssueLicense.Enabled = false;

            lblLocalLicenseID.Text = LicenseID.ToString();
            llShowLicensesHistory.Enabled = (LicenseID != -1);
            _SelectedLocalLicense = ctrlLocalLicenseCardWithFilter1.SelectedLicenseInfo;

            if (LicenseID == -1)
                return;

            if (!_SelectedLocalLicense.IsActive)
            {
                clsMessageBox.ShowError("Selected License is Not Active, select another one.");
                return;
            }

            if (_SelectedLocalLicense.IsDetained)
            {
                clsMessageBox.ShowError("Selected License is Detained, select another one.");
                return;
            }

            if (_SelectedLocalLicense.IsExpired)
            {
                clsMessageBox.ShowError("Selected License is Expired, select another one.");
                return;
            }

            if (_SelectedLocalLicense.LicenseClassInfo.ID != clsLicenseClass.enLicenseClass.OrdinaryDrivingLicense)
            {
                clsMessageBox.ShowError("Selected License should be Class 3 (Ordinary), select another one.");
                return;
            }

            _InternationalLicense = _SelectedLocalLicense.GetActiveInternationalLicense();
            if (_InternationalLicense != null)
            {
                if (!_InternationalLicense.IsExpired)
                {
                    clsMessageBox.ShowError("Person already has an active international license with ID = " +
                        $"[{_InternationalLicense.ID}]", "Not Allowed");

                    llShowLicenseInfo.Enabled = true;

                    return;
                }
            }

            llShowLicensesHistory.Enabled = true;
            btnIssueLicense.Enabled = true;
        }

        private void frmIssueInternationalLicense_Activated(object sender, EventArgs e)
        {
            ctrlLocalLicenseCardWithFilter1.FilterFocus();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowInternationalLicenseInfo(_InternationalLicense.ID);
            frm.ShowDialog();
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowPersonLicenseHistory(_SelectedLocalLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (!clsMessageBox.ShowConfirmQuestion("Are you sure you want to issue the license?"))
                return;

            _InternationalLicense = _SelectedLocalLicense.IssueInternationalLicense(clsGlobal.CurrentUser.ID);

            if (_InternationalLicense != null)
            {
                lblInternationalAppID.Text = _InternationalLicense.ApplicationID.ToString();
                lblInternationalLicenseID.Text = _InternationalLicense.ID.ToString();

                clsMessageBox.ShowInfo($"International License Issued Successfully with ID = [{_InternationalLicense.ID}]");

                ctrlLocalLicenseCardWithFilter1.FilterEnabled = false;
                llShowLicenseInfo.Enabled = true;
                btnIssueLicense.Enabled = false;
            }
            else
            {
                clsMessageBox.ShowError("Failed to Issue International License");
            }
        }

    }
}
