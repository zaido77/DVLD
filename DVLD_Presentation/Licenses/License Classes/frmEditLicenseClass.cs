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

namespace DVLD_Presentation.Licenses.License_Classes
{
    public partial class frmEditLicenseClass : frmBase
    {
        private clsLicenseClass.enLicenseClass _LicenseClassID = clsLicenseClass.enLicenseClass.OrdinaryDrivingLicense;
        private clsLicenseClass _LicenseClass;

        public frmEditLicenseClass(clsLicenseClass.enLicenseClass LicenseClassID)
        {
            InitializeComponent();

            _LicenseClassID = LicenseClassID;
        }

        private void _ResetDefaultValues()
        {
            lblLicenseClassID.Text = "???";
            lblName.Text = "N/A";
            lblDescription.Text = "N/A";
            nudMinimumAge.Value = 18;
            nudValidityLength.Value = 5;
            txtFees.Clear();
        }

        private void frmEditLicenseClass_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            nudMinimumAge.Focus();

            _LicenseClass = clsLicenseClass.Find(_LicenseClassID);

            if (_LicenseClass == null)
            {
                clsMessageBox.ShowError($"No License Class with ID = {(int)_LicenseClassID}", "Not Found");
                this.Close();
                return;
            }

            lblLicenseClassID.Text = ((int)_LicenseClass.ID).ToString();
            lblName.Text = _LicenseClass.ClassName;
            lblDescription.Text = _LicenseClass.Description;
            nudMinimumAge.Value = _LicenseClass.MinimumAllowedAge;
            nudValidityLength.Value = _LicenseClass.DefaultValidityLength;
            txtFees.Text = _LicenseClass.ClassFees.ToString();
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }

            if (!clsValidation.IsNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number!");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                return;
            }

            _LicenseClass.MinimumAllowedAge = Convert.ToByte(nudMinimumAge.Value);
            _LicenseClass.DefaultValidityLength = Convert.ToByte(nudValidityLength.Value);
            _LicenseClass.ClassFees = Convert.ToSingle(txtFees.Text);
            
            if (_LicenseClass.Save())
                clsMessageBox.ShowInfo("Data Saved Succesfully.", "Saved");
            else
                clsMessageBox.ShowError("Failed to save data");
        }
    }
}
