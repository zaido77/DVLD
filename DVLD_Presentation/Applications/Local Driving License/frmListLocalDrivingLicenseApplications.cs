using DVLD_Business;
using DVLD_Presentation.Applications.Local_Driving_License_Applications;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.Licenses;
using DVLD_Presentation.Licenses.Local_Licenses;
using DVLD_Presentation.Tests.Test_Appointments;
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

namespace DVLD_Presentation.Applications.Local_License_Applications
{
    public partial class frmListLocalDrivingLicenseApplications : frmBase
    {
        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void _ShowApplicationDetails()
        {
            Form frm =
                new frmShowLocalDrivingLicenseApplicationInfo(dlLocalDrivingLicenseApplications.SelectedRowID);

            frm.ShowDialog();
        }

        private void frmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            dlLocalDrivingLicenseApplications
                .LoadData(clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications);

            dlLocalDrivingLicenseApplications
                .ShowFilterItems("L.D.L.AppID", "National No.", "Full Name", "Status");

            if (dlLocalDrivingLicenseApplications.HasRows)
            {
                dlLocalDrivingLicenseApplications.Columns[0].Width = 120;
                dlLocalDrivingLicenseApplications.Columns[1].Width = 330;
                dlLocalDrivingLicenseApplications.Columns[2].Width = 130;
                dlLocalDrivingLicenseApplications.Columns[3].Width = 380;
                dlLocalDrivingLicenseApplications.Columns[4].Width = 180;
                dlLocalDrivingLicenseApplications.Columns[5].Width = 130;
                dlLocalDrivingLicenseApplications.Columns[6].Width = 130;
            }
        }

        private void btnAddLocalDLApplication_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicenseApplication();
            frm.ShowDialog();
            dlLocalDrivingLicenseApplications.RefreshData();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditLocalDrivingLicenseApplication(dlLocalDrivingLicenseApplications.SelectedRowID);
            frm.ShowDialog();
            dlLocalDrivingLicenseApplications.RefreshData();
        }

        private void cmsLocalDrivingLicenseApplications_Opening(object sender, CancelEventArgs e)
        {
            clsLocalDrivingLicenseApplication Application =
                clsLocalDrivingLicenseApplication.Find(dlLocalDrivingLicenseApplications.SelectedRowID);

            bool IsNewApplication = Application.Status == clsApplication.enStatus.New;
            editApplicationToolStripMenuItem.Enabled = IsNewApplication;
            deleteApplicationToolStripMenuItem.Enabled = IsNewApplication;
            cancelApplicationToolStripMenuItem.Enabled = IsNewApplication;

            if (scheduleTestsToolStripMenuItem.Enabled = Application.CanScheduleTests())
            {
                scheduleVisionTestToolStripMenuItem.Enabled =
                    Application.CanScheduleTest(clsTestType.enTestType.VisionTest);

                scheduleWrittenTestToolStripMenuItem.Enabled =
                    Application.CanScheduleTest(clsTestType.enTestType.WrittenTest);

                scheduleStreetTestToolStripMenuItem.Enabled =
                    Application.CanScheduleTest(clsTestType.enTestType.StreetTest);
            }
            
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = Application.CanIssueLicense();
            showLicenseToolStripMenuItem.Enabled = Application.IsLicenseIssued();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsMessageBox.ShowWarning($"Are you sure you want to delete this application?",
                "Confirm Delete") == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication
                    .DeleteApplication(dlLocalDrivingLicenseApplications.SelectedRowID))
                {
                    clsMessageBox.ShowInfo("Application Deleted Successfully.");
                    dlLocalDrivingLicenseApplications.RefreshData();
                }
                else
                {
                    clsMessageBox.ShowError("Application was not deleted due to data connected to it.");
                }
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsMessageBox.ShowWarning($"Are you sure you want to cancel this application?",
                "Confirm Delete") == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication
                    .CancelApplication(dlLocalDrivingLicenseApplications.SelectedRowID))
                {
                    clsMessageBox.ShowInfo("Application Cancelled Successfully.");
                    dlLocalDrivingLicenseApplications.RefreshData();
                }
                else
                {
                    clsMessageBox.ShowError("Failed to Cancel Application.");
                }
            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowApplicationDetails();
        }

        private void dlLocalDrivingLicenseApplications_RowDoubleClick(object sender, EventArgs e)
        {
            _ShowApplicationDetails();
        }

        private void _OpenTestAppointmentsForm(clsTestType.enTestType TestType)
        {
            Form frm = new frmListTestAppointments(TestType,
                dlLocalDrivingLicenseApplications.SelectedRowID);

            frm.ShowDialog();

            dlLocalDrivingLicenseApplications.RefreshData();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenTestAppointmentsForm(clsTestType.enTestType.VisionTest);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenTestAppointmentsForm(clsTestType.enTestType.WrittenTest);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenTestAppointmentsForm(clsTestType.enTestType.StreetTest);
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication Application = 
                clsLocalDrivingLicenseApplication.Find(dlLocalDrivingLicenseApplications.SelectedRowID);

            Form frm = new frmShowLocalLicenseInfo(Application.GetActiveLicenseID());
            frm.ShowDialog();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmIssueDriverLicenseForFirstTime(dlLocalDrivingLicenseApplications.SelectedRowID);
            frm.ShowDialog();
            dlLocalDrivingLicenseApplications.RefreshData();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication Application =
                clsLocalDrivingLicenseApplication.Find(dlLocalDrivingLicenseApplications.SelectedRowID);

            Form frm = new frmShowPersonLicenseHistory(Application.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
