using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        
        public int ID { get; set; }

        private int _LicenseClassID = -1;
        public int LicenseClassID
        {
            get { return _LicenseClassID; }
            set
            {
                if (_LicenseClassID != value)
                {
                    _LicenseClassID = value;
                    _LicenseClassInfo = null;
                }
            }
        }

        private clsLicenseClass _LicenseClassInfo;
        public clsLicenseClass LicenseClassInfo
        {
            get
            {
                if (_LicenseClassInfo == null && LicenseClassID > 0)
                    _LicenseClassInfo = clsLicenseClass.Find((clsLicenseClass.enLicenseClass)LicenseClassID);

                return _LicenseClassInfo;
            }
            private set
            {
                _LicenseClassInfo = value;
            }
        }

        public byte PassedTests { get; private set; }
        public int IssuedLicenseID { get; private set; }
        public clsLicense IssuedLicenseInfo;

        public clsLocalDrivingLicenseApplication()
            : base(enApplicationType.NewLocalDrivingLicenseService)
        {
            this.LicenseClassID = -1;
            this.PassedTests = 0;
            this.IssuedLicenseID = -1;

            _Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int LicenseClassID,
            byte PassedTests, int IssuedLicenseID, int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            enApplicationType ApplicationTypeID, enStatus Status, DateTime LastStatusDate,
            float PaidFees, int CreatedByUserID)
            : base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, Status, LastStatusDate,
                    PaidFees, CreatedByUserID)
        {
            this.ID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find((clsLicenseClass.enLicenseClass)LicenseClassID);
            this.PassedTests = PassedTests;
            this.IssuedLicenseID = IssuedLicenseID;
            this.IssuedLicenseInfo = clsLicense.Find(IssuedLicenseID);

            _Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.ID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(
                    base.ApplicationID, LicenseClassID
                );

            return this.ID != -1;
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(
                    ID, base.ApplicationID, LicenseClassID
                );
        }

        public static new clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;
            byte PassedTests = 0;
            int IssuedLicenseID = -1;

            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(
                LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID, ref PassedTests, 
                ref IssuedLicenseID))
            {
                clsApplication Application = clsApplication.Find(ApplicationID);

                if (Application == null)
                    return null;

                return new clsLocalDrivingLicenseApplication(
                        LocalDrivingLicenseApplicationID,
                        LicenseClassID,
                        PassedTests,
                        IssuedLicenseID,
                        ApplicationID,
                        Application.ApplicantPersonID,
                        Application.ApplicationDate,
                        Application.ApplicationTypeID,
                        Application.Status,
                        Application.LastStatusDate,
                        Application.PaidFees,
                        Application.CreatedByUserID
                    );
            }

            else
                return null;
        }

        public override bool Save()
        {
            base._Mode = (clsApplication.enMode)this._Mode;
            if (!base.Save())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }

            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        public static int GetAssociatedApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData
                .GetAssociatedApplicationID(LocalDrivingLicenseApplicationID);
        }

        public new static bool DeleteApplication(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = GetAssociatedApplicationID(LocalDrivingLicenseApplicationID);

            if (clsLocalDrivingLicenseApplicationData
                .DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID))

                return clsApplication.DeleteApplication(ApplicationID);
            
            else
                return false;
        }

        public new static bool CancelApplication(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = GetAssociatedApplicationID(LocalDrivingLicenseApplicationID);

            return clsApplication.CancelApplication(ApplicationID);
        }

        public bool CanScheduleTests()
        {
            return (Status == enStatus.New) && (PassedTests != 3);
        }

        public bool CanScheduleTest(clsTestType.enTestType TestType)
        {
            if (!CanScheduleTests())
                return false;

            switch (TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    return PassedTests == 0;

                case clsTestType.enTestType.WrittenTest:
                    return PassedTests == 1;

                case clsTestType.enTestType.StreetTest:
                    return PassedTests == 2;
            }

            return false;
        }

        public bool CanIssueLicense()
        {
            return (Status == enStatus.New) && (PassedTests == 3) && !IsLicenseIssued();
        }

        public bool IsLicenseIssued()
        {
            return (this.IssuedLicenseID != -1);
            //return GetActiveLicenseID() != -1;
        }

        public bool IssueLicenseForFirstTime(string Notes, int CreatedByUserID)
        {
            if (!CanIssueLicense())
                return false;

            int DriverID = -1;
            if (!clsDriver.IsDriverExist(this.ApplicantPersonID, ref DriverID))
            {
                clsDriver Driver = new clsDriver();
                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedByUserID = CreatedByUserID;

                if (!Driver.Save())
                    return false;

                DriverID = Driver.DriverID;
            }

            clsLicense NewLocalLicense = new clsLicense(this.LicenseClassInfo.ID);
            NewLocalLicense.DriverID = DriverID;
            NewLocalLicense.CreatedByUserID = CreatedByUserID;
            NewLocalLicense.Notes = Notes;
            NewLocalLicense.ApplicationID = this.ApplicationID;
            NewLocalLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            NewLocalLicense.IssueReason = clsLicense.enIssueReason.FirstTime;

            if (NewLocalLicense.Save())
            {
                this.IssuedLicenseID = NewLocalLicense.ID;
                this.IssuedLicenseInfo = NewLocalLicense;

                this.Status = enStatus.Completed;

                this.Save();
                return true;
            }
            else
                return false;
        }

        public bool PersonAllowedToApply()
        {
            return PersonInfo.Age >= LicenseClassInfo.MinimumAllowedAge;
        }

        public int GetActiveLicenseID()
        {
            return clsLicense.GetActiveLicenseID(this.ApplicantPersonID, (int)this.LicenseClassID);
        }

    }
}
