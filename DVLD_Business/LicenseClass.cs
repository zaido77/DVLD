using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsLicenseClass
    {
        enum enMode { Update = 1 }
        private enMode _Mode;

        public enum enLicenseClass
        {
            SmallMotorCycle = 1,
            HeavyMotorCycleLicense = 2,
            OrdinaryDrivingLicense = 3,
            Commercial = 4,
            Agricultural = 5,
            SmallAndMediumBus = 6,
            TruckAndHeavyVehicle = 7
        }

        public enLicenseClass ID { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public float ClassFees {  get; set; }

        private clsLicenseClass(enLicenseClass LicenseClassID, string ClassName, string ClassDescription, 
            byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            this.ID = LicenseClassID;
            this.ClassName = ClassName;
            this.Description = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            _Mode = enMode.Update;
        }

        public static clsLicenseClass Find(enLicenseClass LicenseClassID)
        {
            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 18;
            byte DefaultValidityLength = 10;
            float ClassFees = -1;

            if (clsLicenseClassData.GetLicenseClassInfoByID((int)LicenseClassID, ref ClassName, 
                ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, 
                    DefaultValidityLength, ClassFees);

            else

                return null;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassData.GetAllLicenseClasses();
        }

    }
}