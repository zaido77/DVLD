using DVLD_Business;
using DVLD_Presentation.Applications.Release_Detained_License;
using DVLD_Presentation.Licenses.Local_Licenses;
using DVLD_Presentation.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Licenses.Detained_Licenses
{
    public partial class frmListDetainedLicenses : frmBase
    {
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            dlDetainedLicenses.LoadData(clsDetainedLicense.GetAllDetainedLicenses);
            dlDetainedLicenses.ShowFilterItems("DetainID", "IsReleased", "NationalNo", "FullName", "ReleaseApplicationID");

            if (dlDetainedLicenses.HasRows)
            {
                dlDetainedLicenses.Columns[0].HeaderText = "Detain ID";
                dlDetainedLicenses.Columns[0].Width = 100;

                dlDetainedLicenses.Columns[1].HeaderText = "License ID";
                dlDetainedLicenses.Columns[1].Width = 100;

                dlDetainedLicenses.Columns[2].HeaderText = "Detain Date";
                dlDetainedLicenses.Columns[2].Width = 170;

                dlDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dlDetainedLicenses.Columns[3].Width = 120;

                dlDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dlDetainedLicenses.Columns[4].Width = 150;

                dlDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dlDetainedLicenses.Columns[5].Width = 170;

                dlDetainedLicenses.Columns[6].HeaderText = "National No.";
                dlDetainedLicenses.Columns[6].Width = 130;

                dlDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dlDetainedLicenses.Columns[7].Width = 360;

                dlDetainedLicenses.Columns[8].HeaderText = "Release App.ID";
                dlDetainedLicenses.Columns[8].Width = 140;
            }
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            dlDetainedLicenses.RefreshData();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainLicense();
            frm.ShowDialog();
            dlDetainedLicenses.RefreshData();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            int LicenseID = (int)dlDetainedLicenses.SelectedRow.Cells["LicenseID"].Value;

            Form frm = new frmShowLocalLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = (string)dlDetainedLicenses.SelectedRow.Cells["NationalNo"].Value;

            Form frm = new frmShowPersonInfo(NationalNo);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = (string)dlDetainedLicenses.SelectedRow.Cells["NationalNo"].Value;

            Form frm = new frmShowPersonLicenseHistory(clsPerson.Find(NationalNo).ID);
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaseDetainedLicense((int)dlDetainedLicenses.SelectedRow.Cells["LicenseID"].Value);
            frm.ShowDialog();
            dlDetainedLicenses.RefreshData();
        }

        private void cmsDetainedLicenses_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainedLicenseToolStripMenuItem.Enabled =
                !(bool)dlDetainedLicenses.SelectedRow.Cells["IsReleased"].Value;
        }
    }
}