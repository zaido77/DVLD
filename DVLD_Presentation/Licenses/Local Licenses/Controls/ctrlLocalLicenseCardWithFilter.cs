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

namespace DVLD_Presentation.Licenses.Controls
{
    public partial class ctrlLocalLicenseCardWithFilter : UserControl
    {
        public delegate void LicenseSelectedEventHandler(int LicenseID);
        public event LicenseSelectedEventHandler LicenseSelected;

        public int LicenseID
        {
            get { return ctrlLocalLicenseCard1.LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get {  return ctrlLocalLicenseCard1.SelectedLicenseInfo; }
        }

        public bool FilterEnabled
        {
            get { return gbFilter.Enabled; }
            set { gbFilter.Enabled = value; }
        }

        public ctrlLocalLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        public void FilterFocus()
        {
            txtLicenseID.Focus();
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtLicenseID.Text = LicenseID.ToString();
            ctrlLocalLicenseCard1.LoadDriverLicenseInfo(LicenseID);

            if (FilterEnabled)
                LicenseSelected?.Invoke(ctrlLocalLicenseCard1.LicenseID);
        }

        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseID, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtLicenseID, null);
            }
        }

        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                FilterFocus();
                return;
            }

            int LicenseID = Convert.ToInt32(txtLicenseID.Text.Trim());
            LoadLicenseInfo(LicenseID);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
            if (e.KeyChar == (char)Keys.Enter)
                btnSearchLicense.PerformClick();
        }
    }
}   
