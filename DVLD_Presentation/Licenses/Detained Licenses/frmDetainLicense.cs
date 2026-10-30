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

namespace DVLD_Presentation.Licenses.Detained_Licenses
{
    public partial class frmDetainLicense : frmBase
    {
        clsLicense _SelectedLicense;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToString(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        private void ctrlLocalLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            llShowLicensesHistory.Enabled = llShowLicenseInfo.Enabled = btnDetainLicense.Enabled = false;

            lblLicenseID.Text = LicenseID.ToString();
            llShowLicensesHistory.Enabled = (LicenseID != -1);

            if (LicenseID == -1)
                return;

            _SelectedLicense = ctrlLocalLicenseCardWithFilter1.SelectedLicenseInfo;

            if (!_SelectedLicense.IsActive)
            {
                clsMessageBox.ShowError("Selected License is Not Active, select another one.");
                return;
            }

            if (_SelectedLicense.IsDetained)
            {
                clsMessageBox.ShowError("Selected License is already Detained, select another one.");
                return;
            }

            btnDetainLicense.Enabled = true;
            txtFineFees.Focus();
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
                return;
            }

            if (!clsValidation.IsNumber(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number!");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowPersonLicenseHistory(_SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLocalLicenseInfo(_SelectedLicense.ID);
            frm.ShowDialog();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                return;
            }

            if (clsMessageBox.ShowConfirmQuestion("Are you sure you want to detain this license?") == DialogResult.No)
                return;

            if (_SelectedLicense.Detain(Convert.ToSingle(txtFineFees.Text), clsGlobal.CurrentUser.ID))
            {
                int DetainID = _SelectedLicense.GetActiveDetainID();
                lblDetainID.Text = DetainID.ToString();

                clsMessageBox.ShowInfo($"License Detained Succesfully with ID={DetainID}");

                ctrlLocalLicenseCardWithFilter1.FilterEnabled = false;
                txtFineFees.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                btnDetainLicense.Enabled = false;
            }
            else
            {
                clsMessageBox.ShowError("Failed to Detain License");
            }
        }

        private void frmDetainLicense_Activated(object sender, EventArgs e)
        {
            ctrlLocalLicenseCardWithFilter1.FilterFocus();
        }
    }
}
