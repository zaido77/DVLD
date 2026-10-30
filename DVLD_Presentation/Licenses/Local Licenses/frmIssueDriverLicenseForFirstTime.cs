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

namespace DVLD_Presentation.Applications.Local_Driving_License_Applications
{
    public partial class frmIssueDriverLicenseForFirstTime : frmBase
    {
        private int _LocalDrivingLicenseApplicationID = -1;

        public frmIssueDriverLicenseForFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmIssueDriverLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseApplicationCard1.LoadApplicationInfo(_LocalDrivingLicenseApplicationID);

            if (!ctrlLocalDrivingLicenseApplicationCard1.LoadedSuccessfully)
            {
                this.Close();
                return;
            }

            lblFees.Text = ctrlLocalDrivingLicenseApplicationCard1.GetLocalDrivingLicenseApplicationInfo()
                .LicenseClassInfo.ClassFees.ToString();

            txtNotes.Focus();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                ctrlLocalDrivingLicenseApplicationCard1.GetLocalDrivingLicenseApplicationInfo();

            if (LocalDrivingLicenseApplication.IssueLicenseForFirstTime(txtNotes.Text.Trim(), clsGlobal.CurrentUser.ID))
            {
                clsMessageBox.ShowInfo($"License Issued Succesfully with License ID = " +
                    $"[{LocalDrivingLicenseApplication.IssuedLicenseID}]");
            }
            else
            {
                clsMessageBox.ShowError("Failed to Issue License.");
            }
        }

    }
}