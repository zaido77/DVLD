 using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDriver
    {
        enum enMode {  AddNew = 0, Update = 1 }
        enMode _Mode;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; }

        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            
            _Mode = enMode.AddNew;
        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            _Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverData.AddNewDriver(PersonID, CreatedByUserID);

            return this.DriverID != -1;
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(DriverID, PersonID, CreatedByUserID);
        }

        public static clsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriverData.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);

            else

                return null;
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriverData.GetDriverInfoByDriverID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))

                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);

            else

                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateDriver();
            }

            return false;
        }

        public static bool IsDriverExist(int DriverID)
        {
            return clsDriverData.IsDriverExist(DriverID);
        }

        public static bool IsDriverExist(int PersonID, ref int DriverID)
        {
            return clsDriverData.IsDriverExist(PersonID, ref DriverID);
        }

        public static DataTable GetLocalLicenses(int DriverID)
        {
            return clsLicense.GetAllLocalLicensesFor(DriverID);
        }

        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return clsInternationalLicense.GetDriverInternationalLicenses(DriverID);
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }
    }
}
