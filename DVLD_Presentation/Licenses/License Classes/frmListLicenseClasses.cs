using DVLD_Business;
using DVLD_Presentation.Tests.Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Licenses.License_Classes
{
    public partial class frmListLicenseClasses : frmBase
    {
        public frmListLicenseClasses()
        {
            InitializeComponent();
        }

        private void frmListLicenseClasses_Load(object sender, EventArgs e)
        {
            dlLicenseClasses.LoadData(clsLicenseClass.GetAllLicenseClasses);

            if (dlLicenseClasses.HasRows)
            {
                dlLicenseClasses.Columns[0].HeaderText = "ID";
                dlLicenseClasses.Columns[0].Width = 100;

                dlLicenseClasses.Columns[1].HeaderText = "Name";
                dlLicenseClasses.Columns[1].Width = 300;

                dlLicenseClasses.Columns[2].HeaderText = "Description";
                dlLicenseClasses.Columns[2].Width = 450;

                dlLicenseClasses.Columns[3].HeaderText = "Minimum Age";
                dlLicenseClasses.Columns[3].Width = 130;

                dlLicenseClasses.Columns[4].HeaderText = "Validty Length";
                dlLicenseClasses.Columns[4].Width = 130;

                dlLicenseClasses.Columns[5].HeaderText = "Fees";
                dlLicenseClasses.Columns[5].Width = 120;
            }
        }

        private void editLicenseClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditLicenseClass((clsLicenseClass.enLicenseClass)dlLicenseClasses.SelectedRowID);
            frm.ShowDialog();
            dlLicenseClasses.RefreshData();
        }

    }
}
