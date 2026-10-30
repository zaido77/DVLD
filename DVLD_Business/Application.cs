using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplication
    {
        protected enum enMode { AddNew = 0, Update = 1 }
        protected enMode _Mode;

        public int ApplicationID { get; private set; }
        public int ApplicantPersonID { get; set; }

        private clsPerson _PersonInfo;
        public clsPerson PersonInfo
        {
            get
            {
                if (_PersonInfo == null && ApplicantPersonID > 0)
                    _PersonInfo = clsPerson.Find(ApplicantPersonID);

                return _PersonInfo;
            }
            private set
            {
                _PersonInfo = value;
            }
        }

        public DateTime ApplicationDate { get; private set; }

        public enum enApplicationType
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService = 2,
            ReplacementForLostDrivingLicense = 3,
            ReplacementForDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7
        }
        public enApplicationType ApplicationTypeID { get; private set; }
        public clsApplicationType ApplicationTypeInfo;
        
        public enum enStatus { New = 1, Cancelled = 2, Completed = 3 }

        private enStatus _Status;
        public enStatus Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                LastStatusDate = DateTime.Now;
            }
        }

        public string StatusText
        {
            get
            {
                switch (Status)
                {
                    case enStatus.New: return "New";
                    case enStatus.Cancelled: return "Cancelled";
                    case enStatus.Completed: return "Completed";
                    default: return "Unknown";
                }
            }
        }

        public DateTime LastStatusDate { get; private set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;

        public clsApplication(enApplicationType ApplicationTypeID)
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find((int)ApplicationTypeID);
            this.Status = enStatus.New;
            this.LastStatusDate = this.ApplicationDate;
            this.PaidFees = -1; // assigned in Save()
            this.CreatedByUserID = -1;
            
            _Mode = enMode.AddNew;
        }

        protected clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            enApplicationType ApplicationTypeID, enStatus Status, DateTime LastStatusDate,
            float PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find((int)ApplicationTypeID);
            this.Status = Status;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);

            _Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(ApplicantPersonID, ApplicationDate,
                (int)ApplicationTypeID, (byte)Status, LastStatusDate,
                PaidFees, CreatedByUserID);

            return this.ApplicationID != -1;
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
                (int)ApplicationTypeID, (byte)Status, LastStatusDate,
                PaidFees, CreatedByUserID);
        }

        public static clsApplication Find(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte Status = 0;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = -1;
            int CreatedByUserID = -1;

            if (clsApplicationData.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, 
                ref ApplicationDate, ref ApplicationTypeID, ref Status, ref LastStatusDate,
                ref PaidFees, ref CreatedByUserID))

                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, 
                    (enApplicationType)ApplicationTypeID,(enStatus)Status, LastStatusDate, 
                    PaidFees, CreatedByUserID);

            else

                return null;
        }

        public virtual bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    this.PaidFees = this.ApplicationTypeInfo.Fees;

                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateApplication();
            }

            return false;
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationData.DeleteApplication(ApplicationID);
        }

        public static bool CancelApplication(int ApplicationID)
        {
            return clsApplicationData.CancelApplication(ApplicationID);
        }

        public static bool IsActiveApplicationExist(int PersonID,
            clsLicenseClass.enLicenseClass LicenseClass, ref int ActiveApplicationID)
        {
            ActiveApplicationID = -1;

            return clsApplicationData
                .IsApplicationExist(PersonID, (int)LicenseClass, (byte)enStatus.New, ref ActiveApplicationID);
        }

        
    }
}