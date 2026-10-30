using DVLD_Business;
using DVLD_Presentation.Global.Classes;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests.Controls
{
    public partial class ctrlTestInfo : UserControl
    {
        private clsTest _Test;
        public int TestID
        {
            get { return _Test != null? _Test.ID : -1; }
        }

        public bool LoadedSuccesfully { get; private set; } = false;

        public ctrlTestInfo()
        {
            InitializeComponent();
        }

        private void _LoadTestTypeData()
        {
            switch (_Test.Appointment.TestType.ID)
            {
                case clsTestType.enTestType.VisionTest:
                    gbTestInfo.Text = "Vision Test";
                    pbTestType.Image = Resources.Vision_512;
                    break;

                case clsTestType.enTestType.WrittenTest:
                    gbTestInfo.Text = "Written Test";
                    pbTestType.Image = Resources.Written_Test_512;
                    break;

                case clsTestType.enTestType.StreetTest:
                    gbTestInfo.Text = "Street Test";
                    pbTestType.Image = Resources.driving_test_512;
                    break;
            }
        }

        private void _FillTestData()
        {
            _LoadTestTypeData();

            lblDrivingLicenseApplicationID.Text = _Test.Appointment.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _Test.Appointment.LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblName.Text = _Test.Appointment.LocalDrivingLicenseApplication.PersonInfo.FullName;
            lblTrial.Text = _Test.Appointment.Trial.ToString();
            lblAppointmentDate.Text = clsFormat.DateToString(_Test.Appointment.AppointmentDate);
            lblTestFees.Text = _Test.Appointment.PaidFees.ToString();
            lblTestID.Text = (_Test.ID != -1) ? _Test.ID.ToString() : "Not Taken Yet";

            this.LoadedSuccesfully = true;
        }

        public void ResetTestData()
        {
            _Test = null;

            gbTestInfo.Text = "[???] Test";
            pbTestType.Image = Resources.Vision_512;
            ctrlTitle1.TitleText = "Scheduled Test";

            lblDrivingLicenseApplicationID.Text = "[????]";
            lblDrivingClass.Text = "[????]";
            lblName.Text = "[????]";
            lblTrial.Text = "[????]";
            lblTestFees.Text = "[$$$$]";
            lblTestID.Text = "Not Taken Yet";
        }

        public void LoadTestInfoByTestID(int TestID)
        {
            _Test = clsTest.FindByTestID(TestID);

            if (_Test == null)
            {
                clsMessageBox.ShowError("No Test with ID = " +
                    $"[{TestID}]");
                LoadedSuccesfully = false;
                ResetTestData();
                return;
            }

            _FillTestData();
        }

        public void LoadTestInfoByAppointmentID(int TestAppointmentID)
        {
            if (!clsTestAppointment.IsTestAppointmentExist(TestAppointmentID))
            {
                clsMessageBox.ShowError($"No Test Appointment with ID = [{TestAppointmentID}]");
                LoadedSuccesfully = false;
                return;
            }

            _Test = clsTest.FindByAppointmentID(TestAppointmentID);

            if (_Test == null)
                _Test = new clsTest(TestAppointmentID);

            _FillTestData();
        }

        public clsTest GetTestInfo()
        {
            return _Test;
        }

    }
}
