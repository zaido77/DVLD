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

namespace DVLD_Presentation.Applications.Release_Detained_License
{
    public partial class frmReleaseDetainedLicense : frmBase
    {
        private int _LicenseID = -1;
        clsDetainedLicense _DetainedLicense;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();

            _LicenseID = LicenseID;
        }

        private void _ResetReleasedDetainedLicenseInfo()
        {
            _DetainedLicense = null;

            lblDetainID.Text = "[????]";
            lblDetainDate.Text = "[????]";
            lblDetainedBy.Text = "[????]";
            lblApplicationFees.Text = "[$$$$]";
            lblFineFees.Text = "[$$$$]";
            lblTotalFees.Text = "[$$$$]";
            lblTotalFees.Text = "[$$$$]";
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (_LicenseID != -1)
            {
                ctrlLocalLicenseCardWithFilter1.LoadLicenseInfo(_LicenseID);
                ctrlLocalLicenseCardWithFilter1.FilterEnabled = false;
            }
        }

        private void ctrlLocalLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            llShowLicensesHistory.Enabled = llShowLicenseInfo.Enabled = btnReleaseDetainedLicense.Enabled = false;
            _ResetReleasedDetainedLicenseInfo();

            lblLicenseID.Text = LicenseID.ToString();
            llShowLicensesHistory.Enabled = (LicenseID != -1);

            if (LicenseID == -1)
                return;

            if (!ctrlLocalLicenseCardWithFilter1.SelectedLicenseInfo.IsActive)
            {
                clsMessageBox.ShowError("Selected License is Not Active, select another one.");
                return;
            }

            if (!ctrlLocalLicenseCardWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                clsMessageBox.ShowError("Selected License is Not Detained, select another one.");
                return;
            }

            _DetainedLicense = clsDetainedLicense.GetCurrentDetainedLicenseInfo(LicenseID);

            lblDetainID.Text = _DetainedLicense.DetainID.ToString();
            lblDetainDate.Text = clsFormat.DateToString(_DetainedLicense.DetainDate);
            lblDetainedBy.Text = clsUser.Find(_DetainedLicense.CreatedByUserID).Username;
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense).Fees.ToString();
            lblFineFees.Text = _DetainedLicense.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

            btnReleaseDetainedLicense.Enabled = true;
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowPersonLicenseHistory(ctrlLocalLicenseCardWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLocalLicenseInfo(ctrlLocalLicenseCardWithFilter1.SelectedLicenseInfo.ID);
            frm.ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            if (clsMessageBox.ShowConfirmQuestion("Are you sure you want to release this license?") == DialogResult.No)
                return;

            if (_DetainedLicense.Release(clsGlobal.CurrentUser.ID))
            {
                lblApplicationID.Text = _DetainedLicense.ReleaseApplicationID.ToString();

                clsMessageBox.ShowInfo($"Detained License Released Succesfully");

                ctrlLocalLicenseCardWithFilter1.FilterEnabled = false;
                llShowLicenseInfo.Enabled = true;
                btnReleaseDetainedLicense.Enabled = false;
            }
            else
            {
                clsMessageBox.ShowError("Failed to Release Detained License");
            }
        }

        private void frmReleaseDetainedLicense_Activated(object sender, EventArgs e)
        {
            ctrlLocalLicenseCardWithFilter1.FilterFocus();
        }

    }
}
