using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTest
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public int ID { get; set; }
        public int TestAppointmentID { get; set; }
        public clsTestAppointment Appointment;

        public enum enTestResult { Fail = 0, Pass = 1 }
        public enTestResult TestResult { get; set; }

        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public bool IsTaken
        {
            get { return Appointment.IsLocked; }
        }

        public clsTest(int TestAppointmentID)
        {
            this.ID = -1;
            this.TestAppointmentID = TestAppointmentID;
            this.Appointment = clsTestAppointment.Find(TestAppointmentID);
            this.TestResult = enTestResult.Pass;
            this.Notes = "";
            this.CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }

        private clsTest(int ID, int TestAppointmentID, enTestResult TestResult,
            string Notes, int CreatedByUserID)
        {
            this.ID = ID;
            this.TestAppointmentID = TestAppointmentID;
            this.Appointment = clsTestAppointment.Find(TestAppointmentID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            this.ID = clsTestData.AddNewTest(TestAppointmentID, (byte)TestResult,
                Notes, CreatedByUserID);

            return this.ID != -1;
        }

        private bool _UpdateTest()
        {
            return clsTestData.UpdateTest(ID, TestAppointmentID, (byte)TestResult,
                Notes, CreatedByUserID);
        }

        public static clsTest FindByTestID(int TestID)
        {
            int TestAppointmentID = -1;
            byte TestResult = 0;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsTestData.GetTestInfoByTestID(TestID, ref TestAppointmentID,
                ref TestResult, ref Notes, ref CreatedByUserID))

                return new clsTest(TestID, TestAppointmentID, (enTestResult)TestResult,
                    Notes, CreatedByUserID);

            else

                return null;
        }

        public static clsTest FindByAppointmentID(int TestAppointmentID)
        {
            int TestID = -1;
            byte TestResult = 0;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsTestData.GetTestInfoByAppointmentID(TestAppointmentID, ref TestID,
                ref TestResult, ref Notes, ref CreatedByUserID))

                return new clsTest(TestID, TestAppointmentID, (enTestResult)TestResult,
                    Notes, CreatedByUserID);

            else

                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Appointment.IsLocked = true;

                        if (!Appointment.Save())
                            return false;

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateTest();
            }

            return false;
        }
    
        public static bool IsTestExistByAppointmentID(int TestAppointmentID)
        {
            return clsTestData.IsTestExistByAppointmentID(TestAppointmentID);
        }

        public static bool IsTestPassedFor(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            return clsTestData.IsTestPassedFor(LocalDrivingLicenseApplicationID, (int)TestType);
        }
    }
}
