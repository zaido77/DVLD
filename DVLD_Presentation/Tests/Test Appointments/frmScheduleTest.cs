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
using static DVLD_Business.clsTestType;

namespace DVLD_Presentation.Tests.Test_Appointments
{
    public partial class frmScheduleTest : frmBase
    {
        public frmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();

            ctrlScheduleTest1.LoadTestAppointmentInfo(TestAppointmentID);
        }

        public frmScheduleTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            InitializeComponent();

            ctrlScheduleTest1.LoadTestAppointmentInfo(LocalDrivingLicenseApplicationID, TestType);
        }

    }
}
