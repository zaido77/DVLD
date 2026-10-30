using DVLD_Business;
using DVLD_Presentation.Global.Classes;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Licenses.International_Licenses.Controls
{
    public partial class ctrlInternationalLicenseCard : UserControl
    {
        clsInternationalLicense _InternationalLicense;

        public int InternationalLicenseID
        {
            get { return _InternationalLicense != null ? _InternationalLicense.ID : -1; }
        }

        public ctrlInternationalLicenseCard()
        {
            InitializeComponent();

            lblName.ForeColor = clsSettings.MainColor;
        }

        private void _LoadPersonImage()
        {
            if (_InternationalLicense.DriverInfo.PersonInfo.Gender == clsPerson.enGender.Male)
            {
                pbGender.Image = Resources.Man_32;
                pbPersonImage.Image = Resources.Male_512;
            }
            else
            {
                pbGender.Image = Resources.Woman_32;
                pbPersonImage.Image = Resources.Female_512;
            }

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if (!string.IsNullOrEmpty(ImagePath))
            {
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    clsMessageBox.ShowError($"Could not find this image = {ImagePath}");
            }
        }

        private void _FillInfo()
        {
            
            lblName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblInternationalLicenseID.Text = _InternationalLicense.ID.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblDateOfBirth.Text = clsFormat.DateToString(_InternationalLicense.DriverInfo.PersonInfo.DateOfBirth);
            lblGender.Text = _InternationalLicense.DriverInfo.PersonInfo.Gender.ToString();
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblIssueDate.Text = clsFormat.DateToString(_InternationalLicense.IssueDate);
            lblExpirationDate.Text = clsFormat.DateToString(_InternationalLicense.ExpirationDate);
            
            _LoadPersonImage();
        }

        public void ResetInfo()
        {
            _InternationalLicense = null;

            lblInternationalLicenseID.Text = "[????]";
            lblApplicationID.Text = "[????]";
            lblName.Text = "[????]";
            lblLicenseID.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblGender.Text = "[????]";
            lblDriverID.Text = "[????]";
            lblIssueDate.Text = "[????]";
            lblExpirationDate.Text = "[????]";
            pbGender.Image = Resources.Man_32;
            pbPersonImage.Image = Resources.Male_512;
        }

        public bool LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicense = clsInternationalLicense.Find(InternationalLicenseID);

            if (_InternationalLicense == null)
            {
                ResetInfo();
                clsMessageBox.ShowError($"No International License with ID = [{InternationalLicenseID}]");
                return false;
            }

            _FillInfo();

            return true;
        }

    }
}
