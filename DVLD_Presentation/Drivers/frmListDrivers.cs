using DVLD_Business;
using DVLD_Presentation.Licenses;
using DVLD_Presentation.Licenses.International_Licenses;
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

namespace DVLD_Presentation.Drivers
{
    public partial class frmListDrivers : frmBase
    {
        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            dlDrivers.LoadData(clsDriver.GetAllDrivers);
            dlDrivers.ShowFilterItems("Driver ID", "Person ID", "National No.", "Full Name");

            if (dlDrivers.HasRows)
            {
                dlDrivers.Columns[0].Width = 120;
                dlDrivers.Columns[1].Width = 120;
                dlDrivers.Columns[2].Width = 140;
                dlDrivers.Columns[3].Width = 320;
                dlDrivers.Columns[4].Width = 170;
                dlDrivers.Columns[5].Width = 150;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dlDrivers.SelectedRow.Cells["Person ID"].Value;

            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dlDrivers.SelectedRow.Cells["Person ID"].Value;

            Form frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void dlDrivers_RowDoubleClick(object sender, EventArgs e)
        {
            int PersonID = (int)dlDrivers.SelectedRow.Cells["Person ID"].Value;

            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }
    }
}
