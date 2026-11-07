using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicense
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo;
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        
        public enum enIssueReason
        {
            FirstTime = 1, 
            Renew = 2, 
            ReplacementForDamaged = 3, 
            ReplacementForLost = 4
        }
        public enIssueReason IssueReason { get; set; }

        public string IssueReasonText
        {
            get
            {
                switch (this.IssueReason)
                {
                    case enIssueReason.FirstTime: return "First Time";
                    case enIssueReason.Renew: return "Renew";
                    case enIssueReason.ReplacementForDamaged: return "Replacement for Damaged";
                    case enIssueReason.ReplacementForLost: return "Replacement for Lost";
                }

                return "";
            }
        }

        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;
    
        public bool IsDetained
        {
            get { return clsDetainedLicense.IsLicenseDetained(this.ID); }
        }

        public bool IsExpired
        {
            get { return ExpirationDate < DateTime.Now; }
        }

        public clsLicense()
        {
            this.ID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }

        public clsLicense(clsLicenseClass.enLicenseClass LicenseClass)
        {
            this.ID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = (int)LicenseClass;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClass);
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = this.IssueDate.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive,
            enIssueReason IssueReason, int CreatedByUserID)
        {
            this.ID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindByDriverID(DriverID);
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find((clsLicenseClass.enLicenseClass)LicenseClassID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);

            _Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            this.ID = clsLicenseData.AddNewLicense(ApplicationID, DriverID, LicenseClassID, 
                IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (byte)IssueReason, CreatedByUserID);

            return this.ID != -1;
        }

        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(ID, ApplicationID, DriverID, LicenseClassID, IssueDate, 
                ExpirationDate, Notes, PaidFees, IsActive, (byte)IssueReason, CreatedByUserID);
        }

        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            float PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            if (clsLicenseData.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, 
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, 
                ref CreatedByUserID))

                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate,
                    ExpirationDate, Notes, PaidFees, IsActive, (enIssueReason)IssueReason,
                    CreatedByUserID);

            else

                return null;
        }

        // to check for IsActive and with GetActiveLicenseID()
        public static bool IsLicenseExist(int PersonID, clsLicenseClass.enLicenseClass LicenseClass)
        {
            return clsLicenseData.IsLicenseExist(PersonID, (int)LicenseClass);
            //return GetActiveLicenseID(PersonID, (int)LicenseClass) != -1;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateLicense();
            }

            return false;
        }
        
        public static DataTable GetDriverLocalLicenses(int DriverID)
        {
            return clsLicenseData.GetDriverLocalLicenses(DriverID);
        }

        public static int GetActiveLicenseID(int PersonID, int LicenseClassID)
        {
            return clsLicenseData.GetActiveLicenseID(PersonID, LicenseClassID);
        }

        public clsInternationalLicense GetActiveInternationalLicense()
        {
            return clsInternationalLicense.GetActiveInternationalLicenseByDriverID(this.DriverID);
        }

        public clsInternationalLicense IssueInternationalLicense(int CreatedByUserID)
        {
            return clsInternationalLicense.IssueInternationalLicense(this.ID, CreatedByUserID);
        }

        public bool Deactivate()
        {
            if (clsLicenseData.DeactivateLicense(ID))
            {
                IsActive = false;
                return true;
            }

            return false;
        }

        public clsLicense RenewLicense(string Notes, int CreatedByUserID)
        {
            if (!IsActive || IsDetained || !IsExpired)
                return null;

            clsApplication Application = new clsApplication(clsApplication.enApplicationType.RenewDrivingLicenseService);
            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.Status = clsApplication.enStatus.Completed;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
                return null;

            clsLicense NewLicense = new clsLicense();
            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = NewLicense.IssueDate.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedByUserID;

            if (!NewLicense.Save())
            {
                clsApplication.DeleteApplication(Application.ApplicationID);
                return null;
            }

            this.Deactivate();

            return NewLicense;
        }

        public clsLicense ReplaceLicense(enIssueReason IssueReason, int CreatedByUserID)
        {
            if (!IsActive || IsDetained)
                return null;

            if (IssueReason != enIssueReason.ReplacementForLost &&
                IssueReason != enIssueReason.ReplacementForDamaged)
            {
                return null;
            }


            clsApplication Application = IssueReason == enIssueReason.ReplacementForLost ?
                new clsApplication(clsApplication.enApplicationType.ReplacementForLostDrivingLicense) :
                new clsApplication(clsApplication.enApplicationType.ReplacementForDamagedDrivingLicense);

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.Status = clsApplication.enStatus.Completed;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
                return null;

            clsLicense NewLicense = new clsLicense();
            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = this.ExpirationDate;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = 0;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = IssueReason;
            NewLicense.CreatedByUserID = CreatedByUserID;

            if (!NewLicense.Save())
            {
                clsApplication.DeleteApplication(Application.ApplicationID);
                return null;
            }

            this.Deactivate();

            return NewLicense;
        }

        public int GetActiveDetainID()
        {
            return clsDetainedLicense.GetLicenseActiveDetainID(this.ID);
        }

        public bool Detain(float FineFees, int CreatedByUserID, ref int DetainID)
        {
            return clsDetainedLicense.DetainLicense(this.ID, FineFees, CreatedByUserID, ref DetainID);
        }

        public bool Release(int ReleasedByUserID)
        {
            clsDetainedLicense DetainedLicense = clsDetainedLicense.FindByLicenseID(this.ID);

            if (DetainedLicense == null)
                return false;

            return DetainedLicense.Release(ReleasedByUserID);
        }

    }
}
