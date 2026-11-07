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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Presentation.Licenses.Local_Licenses
{
    public partial class ctrlLocalLicenseCard : UserControl
    {
        clsLicense _License;

        public int LicenseID
        {
            get { return _License != null ? _License.ID : -1; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return _License; }
        }

        public ctrlLocalLicenseCard()
        {
            InitializeComponent();

            lblName.ForeColor = clsUISettings.MainColor;
        }

        private void _LoadDriverImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == clsPerson.enGender.Male)
            {
                pbGender.Image = Resources.Man_32;
                pbDriverImage.Image = Resources.Male_512;
            }
            else
            {
                pbGender.Image = Resources.Woman_32;
                pbDriverImage.Image = Resources.Female_512;
            }

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (!string.IsNullOrEmpty(ImagePath))
            {
                if (File.Exists(ImagePath))
                    pbDriverImage.ImageLocation = ImagePath;
                else
                    clsMessageBox.ShowError($"Could not find this image = {ImagePath}");
            }
        }

        private void _FillDriverLicenseInfo()
        {
            lblClass.Text = _License.LicenseClassInfo.ClassName;
            lblName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _License.ID.ToString();
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblDateOfBirth.Text = clsFormat.DateToString(_License.DriverInfo.PersonInfo.DateOfBirth);
            lblGender.Text = _License.DriverInfo.PersonInfo.Gender.ToString();
            lblDriverID.Text = _License.DriverID.ToString();
            lblIssueDate.Text = clsFormat.DateToString(_License.IssueDate);
            lblExpirationDate.Text = clsFormat.DateToString(_License.ExpirationDate);
            lblIssueReason.Text = _License.IssueReasonText;
            lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
            lblNotes.Text = string.IsNullOrEmpty(_License.Notes) ? "No Notes" : _License.Notes;

            _LoadDriverImage();
        }

        public void ResetDriverLicenseInfo()
        {
            _License = null;

            lblClass.Text = "[????]";
            lblName.Text = "[????]";
            lblLicenseID.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblGender.Text = "[????]";
            lblDriverID.Text = "[????]";
            lblIssueDate.Text = "[????]";
            lblExpirationDate.Text = "[????]";
            lblIssueReason.Text = "[????]";
            lblIsDetained.Text = "[????]";
            lblNotes.Text = "[????]";
            pbGender.Image = Resources.Man_32;
            pbDriverImage.Image = Resources.Male_512;
        }

        public bool LoadDriverLicenseInfo(int LicenseID)
        {
            _License = clsLicense.Find(LicenseID);

            if (_License == null)
            {
                ResetDriverLicenseInfo();
                clsMessageBox.ShowError($"No Local License with LicenseID = [{LicenseID}]");
                return false;
            }

            _FillDriverLicenseInfo();

            return true;
        }

    }
}
