using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    

    public class clsPerson
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public byte Age
        {
            get
            {
                byte Years = Convert.ToByte(DateTime.Today.Year - DateOfBirth.Year);


                if (DateTime.Now.Month <= DateOfBirth.Month && DateTime.Now.Day <= DateOfBirth.Day)
                    return Years;
                else
                    return Convert.ToByte(Years - 1);
            }
        }
        public enum enGender { Male = 0, Female = 1 }
        public enGender Gender;
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CountryID { get; set; }

        public clsCountry CountryInfo;
        public string ImagePath { get; set; }

        public clsPerson()
        {
            this.ID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Today;
            this.Gender = enGender.Male;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.CountryID = -1;
            this.ImagePath = "";

            _Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, 
            string LastName, DateTime DateOfBirth, enGender Gender, string Address, string Phone, string Email,
            int CountryID, string ImagePath)
        {
            this.ID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryID = CountryID;
            this.CountryInfo = clsCountry.Find(CountryID);
            this.ImagePath = ImagePath;
            
            _Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.ID = clsPersonData.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, (byte)Gender, Address, Phone, Email, CountryID, ImagePath);

            return this.ID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(ID, NationalNo, FirstName, SecondName, ThirdName,
                LastName, DateOfBirth, (byte)Gender, Address, Phone, Email, CountryID, ImagePath);
        }

        public static clsPerson Find(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Today;
            byte Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int CountryID = -1;
            string ImagePath = "";

            if (clsPersonData.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email,
                ref CountryID, ref ImagePath))

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName,
                    LastName, DateOfBirth, (enGender)Gender, Address, Phone, Email,
                    CountryID, ImagePath);

            else

                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Today;
            byte Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int CountryID = -1;
            string ImagePath = "";

            if (clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email,
                ref CountryID, ref ImagePath))

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName,
                    LastName, DateOfBirth, (enGender)Gender, Address, Phone, Email,
                    CountryID, ImagePath);

            else

                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }
    }
}
