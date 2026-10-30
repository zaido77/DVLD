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

namespace DVLD_Presentation.Tests.Test_Types
{
    public partial class frmUpdateTestType : frmBase
    {
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsTestType _TestType;

        public frmUpdateTestType(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private void _ResetDefaultValues()
        {
            lblTestTypeID.Text = "???";
            txtTitle.Clear();
            txtDescription.Clear();
            txtFees.Clear();
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _TestType = clsTestType.Find(_TestTypeID);

            if (_TestType == null)
            {
                clsMessageBox.ShowError($"No Test Type with ID = {(int)_TestTypeID}", "Test Type Not Found");
                this.Close();
                return;
            }

            lblTestTypeID.Text = ((int)_TestType.ID).ToString();
            txtTitle.Text = _TestType.Title;
            txtDescription.Text = _TestType.Description;
            txtFees.Text = _TestType.Fees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                return;
            }

            _TestType.Title = txtTitle.Text.Trim();
            _TestType.Description = txtDescription.Text.Trim();
            _TestType.Fees = Convert.ToSingle(txtFees.Text.Trim());

            if (_TestType.Save())
                clsMessageBox.ShowInfo("Data Saved Succesfully.", "Saved");
            else
                clsMessageBox.ShowError("Failed to save data");            
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtTitle, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtDescription, null);
            }
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
    }
}
