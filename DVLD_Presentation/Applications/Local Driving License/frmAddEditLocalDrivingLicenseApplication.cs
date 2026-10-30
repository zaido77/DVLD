using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Applications.Local_Driving_License_Applications
{
    public partial class frmAddEditLocalDrivingLicenseApplication : frmBase
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;

        private int _LocalDrivingLicenseApplicationID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public frmAddEditLocalDrivingLicenseApplication()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Mode = enMode.Update;
        }

        private void _FillLicenseClassesComboBox() 
        {
            cbLicenseClass.DataSource = clsLicenseClass.GetAllLicenseClasses();
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";

            //DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();
            //foreach (DataRow row in dtLicenseClasses.Rows)
            //    cbLicenseClass.Items.Add(row["ClassName"]);
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                ctrlTitle1.TitleText = "New Local Driving License Application";
                this.Text = ctrlTitle1.TitleText;
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();

                lblApplicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToShortDateString();
                lblApplicationFees.Text = _LocalDrivingLicenseApplication.ApplicationTypeInfo.Fees.ToString();
                lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

                tabApplicationInfo.Enabled = false;
                btnSave.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                ctrlTitle1.TitleText = "Update Local Driving License Application";
                this.Text = ctrlTitle1.TitleText;

                tabApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            _FillLicenseClassesComboBox();
            cbLicenseClass.SelectedIndex = 2;
        }

        private void _LoadData()
        {
            _LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                clsMessageBox.ShowError($"No Local Driving License Application with ID = {_LocalDrivingLicenseApplicationID}", 
                    "Application Not Found");
                this.Close();
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            lblLocalDLApplicationID.Text = _LocalDrivingLicenseApplication.ID.ToString();
            lblApplicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(_LocalDrivingLicenseApplication.LicenseClassInfo.ClassName);
            lblApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lblCreatedBy.Text = _LocalDrivingLicenseApplication.CreatedByUserInfo.Username;
        }

        private void frmAddEditLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnPersonalInfoNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonID == -1)
            {
                clsMessageBox.ShowError("Please Select a Person", "Select a Person");
                return;
            }

            tabApplicationInfo.Enabled = true;
            btnSave.Enabled = true;
            this.AcceptButton = btnSave;
            tcLocalDLApplicationInfo.SelectedTab = tcLocalDLApplicationInfo.TabPages["tabApplicationInfo"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsLicenseClass.enLicenseClass LicenseClass = (clsLicenseClass.enLicenseClass)cbLicenseClass.SelectedValue;

            if (clsLicense.IsLicenseExist(ctrlPersonCardWithFilter1.PersonID, LicenseClass))
            {
                clsMessageBox.ShowError("Person already have a license with the same applied " +
                    "license class, Choose different license class", "Not Allowed");
                cbLicenseClass.Focus();
                return;
            }
            
            int ActiveApplicationID = -1;
            if (clsApplication.IsActiveApplicationExist(ctrlPersonCardWithFilter1.PersonID, LicenseClass,
                ref ActiveApplicationID)
            )
            {
                clsMessageBox.ShowError("Choose another License Class, the selected Person Already " +
                    $"have an active application for the selected class with ID = {ActiveApplicationID}");
                cbLicenseClass.Focus();
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonID;
            _LocalDrivingLicenseApplication.LicenseClassID = (int)cbLicenseClass.SelectedValue;

            if (!_LocalDrivingLicenseApplication.PersonAllowedToApply())
            {
                clsMessageBox.ShowError($"Person with age = [{_LocalDrivingLicenseApplication.PersonInfo.Age}] is not allowed to apply for this license class, " +
                    $"Age must be greater than or equal [{_LocalDrivingLicenseApplication.LicenseClassInfo.MinimumAllowedAge}].", "Not Allowed");
                cbLicenseClass.Focus();
                return;
            }

            if (_Mode == enMode.AddNew)
                _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.ID;

            if (_LocalDrivingLicenseApplication.Save())
            {
                lblLocalDLApplicationID.Text = _LocalDrivingLicenseApplication.ID.ToString();
                
                _Mode = enMode.Update;
                ctrlTitle1.TitleText = "Update Local Driving License Application";
                this.Text = ctrlTitle1.TitleText;

                ctrlPersonCardWithFilter1.FilterEnabled = false;

                clsMessageBox.ShowInfo("Data Saved Successfully!", "Saved");
            }
            else
            {
                clsMessageBox.ShowError("Failed to Save Data");
            }
        }

        private void frmAddEditLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

    }
}