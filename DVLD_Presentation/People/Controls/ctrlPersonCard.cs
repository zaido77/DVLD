using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.People
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        public int PersonID
        {
            get
            {
                if (_Person != null)
                    return _Person.ID;
                else
                    return -1;
            }
        }

        public clsPerson SelectedPersonInfo
        {
            get
            {
                return _Person;
            }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();

            lblName.ForeColor = clsUISettings.MainColor;
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == clsPerson.enGender.Male)
            {
                pbGender.Image = Resources.Man_32;
                pbImage.Image = Resources.Male_512;
            }
            else
            {
                pbGender.Image = Resources.Woman_32;
                pbImage.Image = Resources.Female_512;
            }

            if (!string.IsNullOrWhiteSpace(_Person.ImagePath))
            {
                if (File.Exists(_Person.ImagePath))
                    pbImage.ImageLocation = _Person.ImagePath;
                else
                    clsMessageBox.ShowError($"Could not find this image = {_Person.ImagePath}");
            }
        }

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            lblPersonID.Text = _Person.ID.ToString();
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblGender.Text = _Person.Gender.ToString();
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblPhone.Text = _Person.Phone;
            lblCountry.Text = _Person.CountryInfo.Name;

            _LoadPersonImage();
        }

        public void ResetPersonInfo()
        {
            _Person = null;

            lblPersonID.Text = "[????]";
            lblName.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblAddress.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblPhone.Text = "[????]";
            lblCountry.Text = "[????]";
            pbGender.Image = Resources.Man_32;
            pbImage.Image = Resources.Male_512;

            llEditPersonInfo.Enabled = false;
        }

        public bool LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
            {
                ResetPersonInfo();
                clsMessageBox.ShowError($"No Person with PersonID = [{PersonID}]");
                return false;
            }

            _FillPersonInfo();

            return true;
        }

        public bool LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                ResetPersonInfo();
                clsMessageBox.ShowError($"No Person with National No. = [{NationalNo}]");
                return false;
            }

            _FillPersonInfo();

            return true;
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);

            frm.PersonSaved += frmAddEditPerson_PersonSaved;

            frm.ShowDialog();
        }

        private void frmAddEditPerson_PersonSaved(object sender, int PersonID)
        {
            this.LoadPersonInfo(PersonID);
        }

    }
}
