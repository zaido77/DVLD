using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests.Test_Appointments
{
    public partial class frmTakeTest : frmBase
    {
        private int _TestAppointmentID = -1;
        clsTest _Test;

        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();

            _TestAppointmentID = TestAppointmentID;
        }

        private void _LockUnlockTest(bool IsTestTaken)
        {
            lblLockMessage.Visible = IsTestTaken;
            rbPass.Enabled = !IsTestTaken;
            rbFail.Enabled = !IsTestTaken;
        }

        private void _ResetDefaultValues()
        {
            ctrlTestInfo1.ResetTestData();

            rbPass.Checked = true;
            txtNotes.Clear();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            ctrlTestInfo1.LoadTestInfoByAppointmentID(_TestAppointmentID);

            if (ctrlTestInfo1.LoadedSuccesfully)
                _Test = ctrlTestInfo1.GetTestInfo();
            else
            {
                this.Close();
                return;
            }

            if (_Test.TestResult == clsTest.enTestResult.Pass)
                rbPass.Checked = true;
            else
                rbFail.Checked = true;

            txtNotes.Text = _Test.Notes;

            _LockUnlockTest(_Test.IsTaken);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsMessageBox.ShowWarning("Are you sure you want to save? " +
                "After that you cannot change the Pass/Fail results after you save") == DialogResult.OK)
            {
                _Test.TestResult = rbPass.Checked ? clsTest.enTestResult.Pass : clsTest.enTestResult.Fail;
                _Test.Notes = txtNotes.Text;
                _Test.CreatedByUserID = clsGlobal.CurrentUser.ID;

                if (_Test.Save())
                {
                    clsMessageBox.ShowInfo("Data Saved Succesfully.");
                    btnSave.Enabled = false;
                }
                else
                    clsMessageBox.ShowError("Failed to save data.");
            }
        }

    }
}
