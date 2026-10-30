using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        enum enMode { Update = 0 }
        enMode _Mode = enMode.Update;

        public int ID { get; set; }
        public string Title { get; set; }
        public float Fees { get; set; }

        private clsApplicationType(int ApplicationTypeID, string Title, float Fees)
        {
            this.ID = ApplicationTypeID;
            this.Title = Title;
            this.Fees = Fees;

            _Mode = enMode.Update;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType((int)ID, Title, Fees);
        }

        public static clsApplicationType Find(int ApplicationTypeID)
        {
            string Title = "";
            float Fees = -1;

            if (clsApplicationTypeData.GetApplicationTypeInfoByID(ApplicationTypeID, ref Title, ref Fees))
                return new clsApplicationType(ApplicationTypeID, Title, Fees);
            else
                return null;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeData.GetAllApplicationTypes();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Update:
                    return _UpdateApplicationType();
            }

            return false;
        }

    }
}
