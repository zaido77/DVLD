using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class ctrlUserCard : UserControl
    {
        private clsUser _User;

        public int UserID
        {
            get
            {
                if (_User != null)
                    return _User.ID;
                else 
                    return -1;
            }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);

            lblUserID.Text = _User.ID.ToString();
            lblUsername.Text = _User.Username;
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";
        }

        private void _ResetUserInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();

            lblUserID.Text = "[???]";
            lblUsername.Text = "[???]";
            lblIsActive.Text = "[???]";
        }

        public bool LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);

            if (_User == null)
            {
                _ResetUserInfo();
                clsMessageBox.ShowError($"No User with ID = [{UserID}]");
                return false;
            }

            _FillUserInfo();

            return true;
        }

    }
}
