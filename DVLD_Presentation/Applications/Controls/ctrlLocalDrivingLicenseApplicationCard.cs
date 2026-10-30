using DVLD_Business;
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

namespace DVLD_Presentation.Applications.Local_Driving_License_Applications
{
    public partial class ctrlLocalDrivingLicenseApplicationCard : UserControl
    {
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public int LocalDrivingLicenseApplicationID
        {
            get { return (_LocalDrivingLicenseApplication != null) ? _LocalDrivingLicenseApplication.ID : -1; }
        }

        public bool LoadedSuccessfully { get; private set; } = false;

        public ctrlLocalDrivingLicenseApplicationCard()
        {
            InitializeComponent();
        }

        private void _ResetApplicationInfo()
        {
            _LocalDrivingLicenseApplication = null;

            lblDrivingLicenseApplicationID.Text = "[????]";
            lblAppliedForLicense.Text = "[????]";
            lblPassedTests.Text = "[????]";
            llShowLicenseInfo.Enabled = false;

            ctrlApplicationBasicInfo1.ResetApplicationInfo();
        }

        private void _FillApplicationInfo()
        {
            lblDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplication.ID.ToString();
            lblAppliedForLicense.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblPassedTests.Text = $"{_LocalDrivingLicenseApplication.PassedTests}/{clsTestType.TotalNumberOfTests}";
            llShowLicenseInfo.Enabled = _LocalDrivingLicenseApplication.IsLicenseIssued();

            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplication.ApplicationID);

            this.LoadedSuccessfully = true;
        }

        public bool LoadApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetApplicationInfo();
                LoadedSuccessfully = false;
                clsMessageBox.ShowError($"No Local Driving License Application with ID = [{LocalDrivingLicenseApplicationID}]");
                return false;
            }

            _FillApplicationInfo();
            return true;
        }

        public clsLocalDrivingLicenseApplication GetLocalDrivingLicenseApplicationInfo()
        {
            return _LocalDrivingLicenseApplication;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLocalLicenseInfo(_LocalDrivingLicenseApplication.IssuedLicenseID);
            frm.ShowDialog();
        }

    }
}
