using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Presentation.Properties;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;
using DVLD_Presentation.Global_Classes;

namespace DVLD_Presentation.People
{
    public partial class frmAddUpdatePerson : frmBase
    {
        public delegate void PersonSavedEventHandler(object sender, int PersonID);
        public event PersonSavedEventHandler PersonSaved;

        enum enMode { AddNew = 0, Update = 1}
        enMode _Mode;

        private int _PersonID = -1;
        clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            
            _Mode = enMode.Update;
        }

        private void _SetDefaultPersonImage(bool IsMale)
        {
            if (IsMale)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
        }

        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        
                    }
                }

                if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                {
                    string SourceImageFile = pbPersonImage.ImageLocation;

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        clsMessageBox.ShowError("Error Copying Image File");
                        return false;
                    }
                }
            }

            return true;
        }

        private void _FillCountryComboBox()
        {
            //DataTable dtCountries = clsCountry.GetAllCountries();

            //foreach (DataRow row in dtCountries.Rows)
            //{
            //    cbCountry.Items.Add(row["CountryName"]);
            //}

            cbCountry.DataSource = clsCountry.GetAllCountries();
            cbCountry.ValueMember = "CountryID";
            cbCountry.DisplayMember = "CountryName";
        }

        private void _ResetDefaultValues()
        {
            _FillCountryComboBox();

            if (_Mode == enMode.AddNew)
            {
                ctrlTitle1.TitleText = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                ctrlTitle1.TitleText = "Update Person";
            }

            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Today.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            txtFirstName.Clear();
            txtSecondName.Clear();
            txtThirdName.Clear();
            txtLastName.Clear();
            txtNationalNo.Clear();
            rbMale.Checked = true;
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            _SetDefaultPersonImage(rbMale.Checked);
            llRemoveImage.Visible = !string.IsNullOrEmpty(pbPersonImage.ImageLocation);
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                clsMessageBox.ShowError($"No Person with ID = {_PersonID}", "Person Not Found");
                this.Close();
                return;
            }

            lblPersonID.Text = _Person.ID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == clsPerson.enGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            cbCountry.SelectedValue = _Person.CountryID;
            //cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.Name);
            
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                llRemoveImage.Visible = true;
            }
            else
            {
                _SetDefaultPersonImage(_Person.Gender == clsPerson.enGender.Male);
                llRemoveImage.Visible = false;
            }
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                _SetDefaultPersonImage(rbMale.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                return;
            }

            if (!_HandlePersonImage())
                return;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gender = clsPerson.enGender.Male;
            else
                _Person.Gender = clsPerson.enGender.Female;

            //_Person.CountryID = clsCountry.Find(cbCountry.Text).ID;
            _Person.CountryID = (int)cbCountry.SelectedValue;

            if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";
            

            if (_Person.Save())
            {
                _Mode = enMode.Update;
                ctrlTitle1.TitleText = "Update Person";
                lblPersonID.Text = _Person.ID.ToString();

                clsMessageBox.ShowInfo("Data Saved Succesfully.", "Saved");

                PersonSaved?.Invoke(this, _Person.ID);
            }
            else
            {
                clsMessageBox.ShowError("Failed to Save data");
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog1.FileName;
                
                llRemoveImage.Visible = true;
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = "";
            _SetDefaultPersonImage(rbMale.Checked);
            llRemoveImage.Visible = false;
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

            if (_Person.NationalNo != txtNationalNo.Text.Trim() && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void EmptyTextBoxes_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = ((TextBox)sender);

            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }
    }
}
