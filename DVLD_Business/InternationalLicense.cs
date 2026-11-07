using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo;
        public int DriverID { get; set; }
        public clsDriver DriverInfo;
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public bool IsExpired
        {
            get { return DateTime.Today > ExpirationDate; }
        }

        public clsInternationalLicense()
        {
            this.ID = -1;
            this.ApplicationID = -1;
            this.ApplicationInfo = new clsApplication(clsApplication.enApplicationType.NewInternationalLicense);
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = this.IssueDate.AddYears(1);
            this.IsActive = true;
            this.CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate,
            bool IsActive, int CreatedByUserID)
        {
            this.ID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.Find(ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindByDriverID(DriverID);
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            this.ID = clsInternationalLicenseData.AddNewInternationalLicense(
                ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            return this.ID != -1;
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(
                ID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                IssueDate, ExpirationDate, IsActive, CreatedByUserID);
        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsInternationalLicenseData.GetInternationalLicenseInfoByID(
                InternationalLicenseID, ref ApplicationID, ref DriverID,
                ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
                ref IsActive, ref CreatedByUserID))

                return new clsInternationalLicense(
                    InternationalLicenseID, ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                    IsActive, CreatedByUserID);

            else

                return null;
        }

        public static clsInternationalLicense GetActiveInternationalLicenseByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsInternationalLicenseData.GetActiveInternationalLicenseByDriverID(
                DriverID, ref InternationalLicenseID, ref ApplicationID, 
                ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
                ref IsActive, ref CreatedByUserID))

                return new clsInternationalLicense(
                    InternationalLicenseID, ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                    IsActive, CreatedByUserID);

            else

                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateInternationalLicense();
            }

            return false;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicenseData.GetDriverInternationalLicenses(DriverID);
        }

        public bool Deactivate()
        {
            IsActive = false;
            return clsInternationalLicenseData.UpdateIsActive(ID, false);
        }

        public static clsInternationalLicense IssueInternationalLicense(int LicenseID, int CreatedByUserID)
        {
            clsLicense License = clsLicense.Find(LicenseID);

            if (License == null || !License.IsActive || License.IsExpired || License.IsDetained ||
                License.LicenseClassInfo.ID != clsLicenseClass.enLicenseClass.OrdinaryDrivingLicense)
            {
                return null;
            }

            clsInternationalLicense OldInternationalLicense = License.GetActiveInternationalLicense();

            if (OldInternationalLicense != null &&
                !OldInternationalLicense.IsExpired)
            {
                return null;
            }

            clsApplication Application = new clsApplication(clsApplication.enApplicationType.NewInternationalLicense);

            Application.ApplicantPersonID = License.DriverInfo.PersonID;
            Application.Status = clsApplication.enStatus.Completed;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
                return null;

            clsInternationalLicense NewInternationalLicense = new clsInternationalLicense();
            NewInternationalLicense.ApplicationID = Application.ApplicationID;
            NewInternationalLicense.DriverID = License.DriverID;
            NewInternationalLicense.IssuedUsingLocalLicenseID = License.ID;
            NewInternationalLicense.IssueDate = DateTime.Now;
            NewInternationalLicense.ExpirationDate = NewInternationalLicense.IssueDate.AddYears(1);
            NewInternationalLicense.IsActive = true;
            NewInternationalLicense.CreatedByUserID = CreatedByUserID;

            if (!NewInternationalLicense.Save())
            {
                clsApplication.DeleteApplication(Application.ApplicationID);
                return null;
            }

            OldInternationalLicense?.Deactivate();
            return NewInternationalLicense;
        }

    }
}
