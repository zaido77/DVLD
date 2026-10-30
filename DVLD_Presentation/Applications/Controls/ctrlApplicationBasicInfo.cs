using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Applications
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        clsApplication _Application;

        public int ApplicationID
        {
            get { return _Application.ApplicationID; }
        }

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private void _FillApplicationInfo()
        {
            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = _Application.StatusText;
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = _Application.ApplicationTypeInfo.Title;
            lblApplicant.Text = _Application.PersonInfo.FullName;
            lblDate.Text = clsUtil.DateToString(_Application.ApplicationDate);
            lblStatusDate.Text = clsUtil.DateToString(_Application.LastStatusDate);
            lblCreatedBy.Text = _Application.CreatedByUserInfo.Username;

            llViewPersonInfo.Enabled = true;
        }

        public void ResetApplicationInfo()
        {
            lblApplicationID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblFees.Text = "[????]";
            lblType.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreatedBy.Text = "[????]";

            llViewPersonInfo.Enabled = false;
        }

        public bool LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.Find(ApplicationID);

            if (_Application == null)
            {
                ResetApplicationInfo();
                clsMessageBox.ShowError($"No Application with ID = {ApplicationID}");
                return false;
            }

            _FillApplicationInfo();
            return true;
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowPersonInfo(_Application.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
