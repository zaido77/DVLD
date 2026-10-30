using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests.Test_Appointments
{
    public partial class frmListTestAppointments : frmBase
    {
        clsTestType.enTestType _TestType;
        int _LocalDrivingLicenseApplicationID = -1;

        public frmListTestAppointments(clsTestType.enTestType TestType, int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            _TestType = TestType;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    this.Text = "Vision Test Appointments";
                    ctrlTitle1.TitleText = this.Text;
                    pbTestType.Image = Resources.Vision_512;
                    break;

                case clsTestType.enTestType.WrittenTest:
                    this.Text = "Written Test Appointments";
                    ctrlTitle1.TitleText = this.Text;
                    pbTestType.Image = Resources.Written_Test_512;
                    break;
                
                case clsTestType.enTestType.StreetTest:
                    this.Text = "Street Test Appointments";
                    ctrlTitle1.TitleText = this.Text;
                    pbTestType.Image = Resources.driving_test_512;
                    break;
            }
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();


            ctrlLocalDrivingLicenseApplicationCard1.LoadApplicationInfo(_LocalDrivingLicenseApplicationID);

            if (ctrlLocalDrivingLicenseApplicationCard1.LocalDrivingLicenseApplicationID == -1)
            {
                clsMessageBox.ShowError($"No Local License Application with ID = " +
                    $"[{_LocalDrivingLicenseApplicationID}]");
                this.Close();
                return;
            }


            dlAppointments.LoadData(() => clsTestAppointment.GetApplicationTestAppointmentsPerTestType(
                _LocalDrivingLicenseApplicationID, _TestType));

            if (dlAppointments.HasRows)
            {
                dlAppointments.Columns[0].HeaderText = "Appointment ID";
                dlAppointments.Columns[0].Width = 150;

                dlAppointments.Columns[1].HeaderText = "Appointment Date";
                dlAppointments.Columns[1].Width = 230;

                dlAppointments.Columns[2].HeaderText = "Paid Fees";
                dlAppointments.Columns[2].Width = 150;

                dlAppointments.Columns[3].HeaderText = "Is Locked";
                dlAppointments.Columns[3].Width = 120;
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (clsTest.IsTestPassedFor(
                ctrlLocalDrivingLicenseApplicationCard1.LocalDrivingLicenseApplicationID,
                _TestType))
            {
                clsMessageBox.ShowError("This person already passed this test, you can only retake failed test",
                    "Not Allowed");
                return;
            }

            if (clsTestAppointment.IsActiveAppointmentExistFor(
                ctrlLocalDrivingLicenseApplicationCard1.LocalDrivingLicenseApplicationID,
                _TestType))
            {
                clsMessageBox.ShowError("Person Already have an active appointment for this test, " +
                    "You cannot add new appointment.", "Not Allowed");
                return;
            }

            Form frm = new frmScheduleTest(
                ctrlLocalDrivingLicenseApplicationCard1.LocalDrivingLicenseApplicationID, _TestType);
            frm.ShowDialog();

            frmTestAppointments_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmScheduleTest(dlAppointments.SelectedRowID);
            frm.ShowDialog();
            dlAppointments.RefreshData();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTakeTest(dlAppointments.SelectedRowID);
            frm.ShowDialog();
            frmTestAppointments_Load(null, null);
        }

        private void cmsTestAppointments_Opening(object sender, CancelEventArgs e)
        {
            cmsTestAppointments.Enabled = dlAppointments.HasRows;
        }

    }
}
