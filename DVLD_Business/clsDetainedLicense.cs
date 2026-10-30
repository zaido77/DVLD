using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public clsLicense LicenseInfo;
        public DateTime DetainDate { get; set; }
        public float FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }

        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            _Mode = enMode.AddNew;
        }

        private clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate,
            float FineFees, int CreatedByUserID, bool IsReleased,
            DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.LicenseInfo = clsLicense.Find(LicenseID);
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            
            _Mode = enMode.Update;
        }

        private bool _AddNewDetainedLicense()
        {
            DetainID = clsDetainedLicenseData.AddNewDetainedLicense(
                LicenseID, DetainDate, FineFees, CreatedByUserID);

            return (DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseData.UpdateDetainedLicense(
                DetainID, LicenseID, DetainDate, FineFees,
                CreatedByUserID, IsReleased, ReleaseDate,
                ReleasedByUserID, ReleaseApplicationID);
        }

        public static clsDetainedLicense Find(int DetainID)
        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.MinValue;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseInfoByID(
                DetainID, ref LicenseID, ref DetainDate, ref FineFees,
                ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
                ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicense(DetainID, LicenseID, DetainDate,
                    FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                    ReleasedByUserID, ReleaseApplicationID);

            else

                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateDetainedLicense();
            }

            return false;
        }

        public static int GetLicenseActiveDetainID(int LicenseID)
        {
            return clsDetainedLicenseData.GetLicenseActiveDetainID(LicenseID);
        }

        public static clsDetainedLicense GetCurrentDetainedLicenseInfo(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.MinValue;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicenseData.GetCurrentDetainedLicenseInfo(
                LicenseID, ref DetainID, ref DetainDate, ref FineFees,
                ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
                ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicense(DetainID, LicenseID, DetainDate,
                    FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                    ReleasedByUserID, ReleaseApplicationID);

            else

                return null;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return GetLicenseActiveDetainID(LicenseID) != -1;
        }

        public static bool DetainLicense(int LicenseID, float FineFees, int CreatedByUserID)
        {
            clsLicense License = clsLicense.Find(LicenseID);

            if (License == null)
                return false;

            if (!License.IsActive || License.IsDetained)
                return false;

            clsDetainedLicense DetainedLicense = new clsDetainedLicense();
            DetainedLicense.LicenseID = LicenseID;
            DetainedLicense.DetainDate = DateTime.Now;
            DetainedLicense.FineFees = FineFees;
            DetainedLicense.CreatedByUserID = CreatedByUserID;
            DetainedLicense.IsReleased = false;

            return DetainedLicense.Save();
        }

        public bool Release(int ReleasedByUserID)
        {
            if (!LicenseInfo.IsActive || !LicenseInfo.IsDetained || this.IsReleased)
                return false;

            clsApplication Application = new clsApplication(clsApplication.enApplicationType.ReleaseDetainedDrivingLicense);
            Application.ApplicantPersonID = this.LicenseInfo.DriverInfo.PersonID;
            Application.Status = clsApplication.enStatus.Completed;
            Application.CreatedByUserID = ReleasedByUserID;

            if (!Application.Save())
                return false;

            this.IsReleased = true;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = Application.ApplicationID;

            if (!this.Save())
            {
                clsApplication.DeleteApplication(Application.ApplicationID);
                return false;
            }

            return true;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseData.GetAllDetainedLicenses();
        }
    }

}
