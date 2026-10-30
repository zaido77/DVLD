using DVLD_Business;
using DVLD_Presentation.Global.Classes;
using DVLD_Presentation.Licenses;
using DVLD_Presentation.Licenses.International_Licenses;
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

namespace DVLD_Presentation.Applications.International_License
{
    public partial class frmListInternationalLicenseApplications : frmBase
    {
        public frmListInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmListInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            dlInternationalLicenseApplications.LoadData(clsInternationalLicense.GetAllInternationalLicenses);

            dlInternationalLicenseApplications.ShowFilterItems("Int.License ID", "Application ID", "Driver ID",
                "L.License ID", "Is Active");

            if (dlInternationalLicenseApplications.HasRows)
            {
                dlInternationalLicenseApplications.Columns[0].Width = 160;
                dlInternationalLicenseApplications.Columns[1].Width = 160;
                dlInternationalLicenseApplications.Columns[2].Width = 150;
                dlInternationalLicenseApplications.Columns[3].Width = 130;
                dlInternationalLicenseApplications.Columns[4].Width = 200;
                dlInternationalLicenseApplications.Columns[5].Width = 200;
                dlInternationalLicenseApplications.Columns[6].Width = 130;
            }
        }

        private void btnNewIntLicenseApplication_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsInternationalLicense InternationalLicense =
                clsInternationalLicense.Find(dlInternationalLicenseApplications.SelectedRowID);

            Form frm = new frmShowPersonInfo(InternationalLicense.DriverInfo.PersonID);
            frm.ShowDialog();

            //int PersonID = clsDriver.FindByDriverID((int)dlInternationalLicenseApplications.SelectedRow.Cells["Driver ID"].Value).PersonID;
            //frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            //frm.ShowDialog();
        }
         
        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowInternationalLicenseInfo(dlInternationalLicenseApplications.SelectedRowID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsInternationalLicense InternationalLicense =
                clsInternationalLicense.Find(dlInternationalLicenseApplications.SelectedRowID);

            Form frm = new frmShowPersonLicenseHistory(InternationalLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void dlInternationalLicenseApplications_RowDoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowInternationalLicenseInfo(dlInternationalLicenseApplications.SelectedRowID);
            frm.ShowDialog();
        }

        private void cmsInternationalLicenseApplications_Opening(object sender, CancelEventArgs e)
        {
            cmsInternationalLicenseApplications.Enabled = dlInternationalLicenseApplications.HasRows;
        }
    }
}
