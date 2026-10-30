using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests.Test_Appointments.Controls
{
    public partial class ctrlScheduleTest : UserControl
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;

        clsTestAppointment _TestAppointment;

        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;
        public clsTestType.enTestType TestType
        {
            get { return _TestType; }

            set
            {
                _TestType = value;
                _LoadTestTypeTitleAndImage(_TestType);
            }
        }

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }

        private void _LoadTestTypeTitleAndImage(clsTestType.enTestType TestType)
        {
            switch (TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    gbScheduleTest.Text = "Vision Test";
                    pbTestType.Image = Resources.Vision_512;
                    break;
                
                case clsTestType.enTestType.WrittenTest:
                    gbScheduleTest.Text = "Written Test";
                    pbTestType.Image = Resources.Written_Test_512;
                    break;
                
                case clsTestType.enTestType.StreetTest:
                    gbScheduleTest.Text = "Street Test";
                    pbTestType.Image = Resources.driving_test_512;
                    break;
            }
        }

        private void _LockUnlockTestAppointment(bool IsLocked)
        {
            if (IsLocked)
                ctrlTitle1.TitleText = "Schedule Retake Test";

            lblUserMessage.Visible = IsLocked;
            dtpAppointmentDate.Enabled = !IsLocked;
            btnSave.Enabled = !IsLocked;
        }

        private void _FillTestAppointmentData()
        {
            this.Enabled = true;

            _LoadTestTypeTitleAndImage(_TestAppointment.TestType.ID);

            lblDrivingLicenseApplicationID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _TestAppointment.LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblName.Text = _TestAppointment.LocalDrivingLicenseApplication.PersonInfo.FullName;
            lblTrial.Text = _TestAppointment.Trial.ToString();

            if (_Mode == enMode.AddNew)
            {
                dtpAppointmentDate.MinDate = DateTime.Now;
                dtpAppointmentDate.Value = dtpAppointmentDate.MinDate;
                lblTestFees.Text = _TestAppointment.TestType.Fees.ToString();
            }
            else
            {
                if (_TestAppointment.AppointmentDate <= DateTime.Now)
                    dtpAppointmentDate.MinDate = _TestAppointment.AppointmentDate;
                else
                    dtpAppointmentDate.MinDate = DateTime.Now;

                dtpAppointmentDate.Value = _TestAppointment.AppointmentDate;
                lblTestFees.Text = _TestAppointment.PaidFees.ToString();
            }

            if (_TestAppointment.Type == clsTestAppointment.enAppointmentType.Retake)
            {
                ctrlTitle1.TitleText = "Schedule Retake Test";
                gbRetakeTestInfo.Visible = true;

                if (_Mode == enMode.AddNew)
                    lblRetakeApplicationFees.Text = _TestAppointment.RetakeTestApplication.ApplicationTypeInfo.Fees.ToString();
                else
                {
                    lblRetakeApplicationFees.Text = _TestAppointment.RetakeTestApplication.PaidFees.ToString();
                    lblRetakeTestApplicationID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                }

                lblTotalFees.Text = _TestAppointment.TotalFees.ToString();
            }
            else
            {
                ctrlTitle1.TitleText = "Schedule Test";
                gbRetakeTestInfo.Visible = false;
            }

            _LockUnlockTestAppointment(_TestAppointment.IsLocked);
        }

        private void _ResetTestAppointmentData()
        {
            lblDrivingLicenseApplicationID.Text = "[????]";
            lblDrivingClass.Text = "[????]";
            lblName.Text = "[????]";
            lblTrial.Text = "[????]";
            lblTestFees.Text = "[$$$$]";

            lblRetakeTestApplicationID.Text = "N/A";
            lblRetakeApplicationFees.Text = "[$$$$]";
            lblTotalFees.Text = "[$$$$]";
            gbRetakeTestInfo.Visible = false;

            dtpAppointmentDate.MinDate = DateTime.Now;
            dtpAppointmentDate.Value = dtpAppointmentDate.MinDate;

            gbScheduleTest.Text = "[???] Test";
            pbTestType.Image = Resources.Vision_512;
            ctrlTitle1.TitleText = "Schedule Test";

            this.Enabled = false;
        }

        public void LoadTestAppointmentInfo(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            _Mode = enMode.AddNew;

            _TestAppointment = new clsTestAppointment(LocalDrivingLicenseApplicationID, TestType);

            if (_TestAppointment == null)
            {
                clsMessageBox.ShowError("No Local Driving License Application with ID = " +
                    $"[{LocalDrivingLicenseApplicationID}]");
                _ResetTestAppointmentData();
                return;
            }

            _FillTestAppointmentData();
        }

        public void LoadTestAppointmentInfo(int AppointmentID)
        {
            _Mode = enMode.Update;

            _TestAppointment = clsTestAppointment.Find(AppointmentID);

            if (_TestAppointment == null)
            {
                clsMessageBox.ShowError("No Test Appointment with ID = " +
                    $"[{AppointmentID}]");
                _ResetTestAppointmentData();
                return;
            }

            _FillTestAppointmentData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestAppointment.AppointmentDate = dtpAppointmentDate.Value;
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.ID;

            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                clsMessageBox.ShowInfo("Data Saved Successfully!");
            }
            else
                clsMessageBox.ShowError("Failed to save data.");
        }

    }
}
