using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestType
    {
        public static byte TotalNumberOfTests = 3;
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.Update;

        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }

        public enTestType ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }

        public clsTestType()
        {
            this.ID = enTestType.VisionTest;
            this.Title = "";
            this.Description = "";
            this.Fees = -1;

            _Mode = enMode.AddNew;
        }

        private clsTestType(enTestType TestTypeID, string Title, string Description, float Fees)
        {
            this.ID = TestTypeID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;

            _Mode = enMode.Update;
        }

        private bool _AddNewTestType()
        {
            int result = clsTestTypeData.AddNewTestType(Title, Description, Fees);

            if (result == -1)
                return false;

            this.ID = (enTestType)result;
            return true;
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType((int)ID, Title, Description, Fees);
        }

        public static clsTestType Find(enTestType TestTypeID)
        {
            string Title = "";
            string Description = "";
            float Fees = -1;

            if (clsTestTypeData.GetTestTypeInfoByID((int)TestTypeID, ref Title, ref Description, ref Fees))
                return new clsTestType(TestTypeID, Title, Description, Fees);
            else
                return null;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateTestType();
            }

            return false;
        }
    }
}
