using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsUser
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public int ID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;

            _Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            this.ID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            _Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.ID = clsUserData.AddNewUser(PersonID, Username, Password, IsActive);

            return this.ID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(ID, PersonID, Username, Password, IsActive);
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = false;

            if (clsUserData.GetUserInfoByID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))

                return new clsUser(UserID, PersonID, Username, Password, IsActive);

            else

                return null;
        }

        public static clsUser Find(string Username, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;

            if (clsUserData.GetUserInfoByUsernameAndPassword(Username, Password, ref UserID, ref PersonID,
                ref IsActive))

                return new clsUser(UserID, PersonID, Username, Password, IsActive);

            else

                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string Username)
        {
            return clsUserData.IsUserExist(Username);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }

        public bool Deactivate()
        {
            this.IsActive = false;
            return this.Save();
        }

        public bool Activate()
        {
            this.IsActive = true;
            return this.Save();
        }

    }
}
