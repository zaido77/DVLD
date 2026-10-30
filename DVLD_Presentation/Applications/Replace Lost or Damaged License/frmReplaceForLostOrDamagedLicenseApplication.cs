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

namespace DVLD_Presentation.Applications.Replacement_for_Lost_or_Damaged_License
{
    public partial class frmReplaceForLostOrDamagedLicenseApplication : frmBase
    {
        private clsLicense.enIssueReason _IssueReason;
        private clsLicense.enIssueReason IssueReason
        {
            get { return _IssueReason; }
            set
            {
                _IssueReason = value;

                switch (_IssueReason)
                {
                    case clsLicense.enIssueReason.ReplacementForLost:
                        this.Text = "Replacement for Lost License";
                        ctrlTitle1.TitleText = this.Text;
                        break;
                    
                    case clsLicense.enIssueReason.ReplacementForDamaged:
                        this.Text = "Replacement for Damaged License";
                        ctrlTitle1.TitleText = this.Text;
                        break;
                }

                lblApplicationFees.Text = clsApplicationType.Find((int)_GetApplicationType()).Fees.ToString();
            }
        }

        clsLicense _SelectedLicense;
        clsLicense _ReplacedLicense;

        public frmReplaceForLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }

        private clsApplication.enApplicationType _GetApplicationType()
        {
            if (IssueReason == clsLicense.enIssueReason.ReplacementForLost)
                return clsApplication.enApplicationType.ReplacementForLostDrivingLicense;
            else
                return clsApplication.enApplicationType.ReplacementForDamagedDrivingLicense;
        }

        private void frmReplacementForLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsFormat.DateToString(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

            rbLostLicense.Checked = true;
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLostLicense.Checked)
                IssueReason = clsLicense.enIssueReason.ReplacementForLost;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
                IssueReason = clsLicense.enIssueReason.ReplacementForDamaged;
        }

        private void ctrlLocalLicenseCardWithFilter1_LicenseSelected(int LicenseID)
        {
            llShowNewLicenseInfo.Enabled = btnIssueReplacement.Enabled = false;

            lblOldLicenseID.Text = LicenseID.ToString();

            if (LicenseID == -1)
                return;

            _SelectedLicense = ctrlLocalLicenseCardWithFilter1.SelectedLicenseInfo;

            if (!_SelectedLicense.IsActive)
            {
                clsMessageBox.ShowError("Selected License is Not Active, choose another one.");
                return;
            }

            if (_SelectedLicense.IsDetained)
            {
                clsMessageBox.ShowError("Selected License is Detained, choose another one.");
                return;
            }

            btnIssueReplacement.Enabled = true;
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm;

            if (ctrlLocalLicenseCardWithFilter1.LicenseID == -1)
                frm = new frmShowPersonLicenseHistory();
            else
                frm = new frmShowPersonLicenseHistory(_SelectedLicense.DriverInfo.PersonID);

            frm.ShowDialog();
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLocalLicenseInfo(_ReplacedLicense.ID);
            frm.ShowDialog();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (clsMessageBox.ShowConfirmQuestion("Are you sure you want to Issue a Replacement for the license?")
                == DialogResult.No)
            {
                return;
            }

            _ReplacedLicense = _SelectedLicense.ReplaceLicense(IssueReason, clsGlobal.CurrentUser.ID);

            if (_ReplacedLicense == null)
            {
                clsMessageBox.ShowError("Failed to Issue Replacement.");
                return;
            }

            lblLicenseReplacementApplicationID.Text = _ReplacedLicense.ApplicationID.ToString();
            lblReplacedLicenseID.Text = _ReplacedLicense.ID.ToString();

            clsMessageBox.ShowInfo($"License Replaced Successfully with ID = {_ReplacedLicense.ID}");

            ctrlLocalLicenseCardWithFilter1.FilterEnabled = false;
            gbReplacementFor.Enabled = false;
            btnIssueReplacement.Enabled = false;
            llShowNewLicenseInfo.Enabled = true;
        }

        private void frmReplacementForLostOrDamagedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlLocalLicenseCardWithFilter1.FilterFocus();
        }

    }
}
