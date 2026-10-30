using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DVLD_Business.clsTestAppointment;
using static DVLD_Business.clsTestType;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public int AppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public clsTestType TestType;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication;
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public clsApplication RetakeTestApplication;
        public byte Trial { get; set; }

        public enum enAppointmentType { FirstTime = 0, Retake = 1 }
        public enAppointmentType Type { get; set; }

        public float TotalFees
        {
            get
            {
                
                if (Type == enAppointmentType.FirstTime)
                    return TestType.Fees;

                if (_Mode == enMode.AddNew)
                    return TestType.Fees + RetakeTestApplication.ApplicationTypeInfo.Fees;

                return PaidFees + RetakeTestApplication.PaidFees;
            }
        }

        public clsTestAppointment(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            this.AppointmentID = -1;
            this.TestTypeID = (int)TestType;
            this.TestType = clsTestType.Find(TestType);
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.Trial = (byte)(CountAppointmentsFor(LocalDrivingLicenseApplicationID, TestType) + 1);
            this.RetakeTestApplicationID = -1;

            if (AnyAppointmentExistFor(LocalDrivingLicenseApplicationID, TestType))
            {
                this.Type = enAppointmentType.Retake;
                this.RetakeTestApplication = new clsApplication(clsApplication.enApplicationType.RetakeTest);
            }
            else
                this.Type = enAppointmentType.FirstTime;

            _Mode = enMode.AddNew;
        }

        private clsTestAppointment(int AppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked,
            int RetakeTestApplicationID)
        {
            this.AppointmentID = AppointmentID;
            this.TestTypeID = TestTypeID;
            this.TestType = clsTestType.Find((clsTestType.enTestType)TestTypeID);
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.Trial = _GetAppointmentTrial();
            this.Type = (RetakeTestApplicationID == -1) ? enAppointmentType.FirstTime : enAppointmentType.Retake;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestApplication = (this.Type == enAppointmentType.Retake) ? clsApplication.Find(RetakeTestApplicationID) : null;

            _Mode = enMode.Update;
        }

        private byte _GetAppointmentTrial()
        {
            return clsTestAppointmentData.GetAppointmentTrial(AppointmentID, 
                LocalDrivingLicenseApplicationID, TestTypeID);
        }

        private bool _AddNewTestAppointment()
        {
            this.AppointmentID = clsTestAppointmentData.AddNewTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID,
                AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);

            return this.AppointmentID != -1;
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateTestAppointment(AppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
                AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
        }

        public static clsTestAppointment Find(int AppointmentID)
        {
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            float PaidFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            if (clsTestAppointmentData.GetTestAppointmentInfoByID(AppointmentID, ref TestTypeID, 
                ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, 
                ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointment(AppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, 
                    AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);

            else

                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    
                    if (Type == enAppointmentType.Retake)
                    {
                        RetakeTestApplication.ApplicantPersonID = LocalDrivingLicenseApplication.ApplicantPersonID;
                        RetakeTestApplication.Status = clsApplication.enStatus.Completed;
                        RetakeTestApplication.CreatedByUserID = this.CreatedByUserID;

                        if (!RetakeTestApplication.Save())
                            return false;

                        this.RetakeTestApplicationID = RetakeTestApplication.ApplicationID;
                    }

                    this.PaidFees = this.TestType.Fees;

                    if (_AddNewTestAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateTestAppointment();
            }

            return false;
        }

        private static byte CountAppointmentsFor(int LocalDrivingLicenseApplicationID, 
            clsTestType.enTestType TestType)
        {
            return clsTestAppointmentData.CountAppointmentsFor(LocalDrivingLicenseApplicationID, (int)TestType);
        }

        public static bool AnyAppointmentExistFor(int LocalDrivingLicenseApplicationID, 
            clsTestType.enTestType TestType)
        {
            return CountAppointmentsFor(LocalDrivingLicenseApplicationID, TestType) > 0;
        }

        public static bool IsActiveAppointmentExistFor(int LocalDrivingLicenseApplicationID, 
            clsTestType.enTestType TestType)
        {
            return clsTestAppointmentData.IsActiveAppointmentExistFor(LocalDrivingLicenseApplicationID, 
                (int)TestType);
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID,
            clsTestType.enTestType TestType)
        {
            return clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(
                LocalDrivingLicenseApplicationID, (int)TestType);
        }

        public static bool IsTestAppointmentExist(int TestAppointmentID)
        {
            return clsTestAppointmentData.IsTestAppointmentExist(TestAppointmentID);
        }

    }
}
