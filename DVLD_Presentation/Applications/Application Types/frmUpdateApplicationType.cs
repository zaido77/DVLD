using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Presentation.Applications.Application_Types
{
    public partial class frmUpdateApplicationType : frmBase
    {
        private int _ApplicationTypeID = -1;
        clsApplicationType _ApplicationType;

        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeID;
        }

        private void _ResetDefaultValues()
        {
            lblApplicationTypeID.Text = "???";
            txtTitle.Clear();
            txtFees.Clear();
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            if (_ApplicationType == null)
            {
                clsMessageBox.ShowError($"No Application Type with ID = {_ApplicationTypeID}", "Application Type Not Found");
                this.Close();
                return;
            }

            lblApplicationTypeID.Text = _ApplicationType.ID.ToString();
            txtTitle.Text = _ApplicationType.Title;
            txtFees.Text = _ApplicationType.Fees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                return;
            }

            _ApplicationType.Title = txtTitle.Text.Trim();
            _ApplicationType.Fees = Convert.ToSingle(txtFees.Text.Trim());

            if (_ApplicationType.Save())
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
