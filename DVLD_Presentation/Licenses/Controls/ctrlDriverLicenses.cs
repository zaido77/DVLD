using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.Licenses.International_Licenses;
using DVLD_Presentation.Licenses.Local_Licenses;
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
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID = -1;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        
        private void _LoadLocalLicenses()
        {
            dlLocalLicenses.LoadData(() => clsDriver.GetLocalLicenses(_DriverID));

            if (dlLocalLicenses.HasRows)
            {
                dlLocalLicenses.Columns[0].HeaderText = "Lic.ID";
                dlLocalLicenses.Columns[0].Width = 110;

                dlLocalLicenses.Columns[1].HeaderText = "App.ID";
                dlLocalLicenses.Columns[1].Width = 110;

                dlLocalLicenses.Columns[2].HeaderText = "Class Name";
                dlLocalLicenses.Columns[2].Width = 300;

                dlLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dlLocalLicenses.Columns[3].Width = 180;

                dlLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dlLocalLicenses.Columns[4].Width = 180;

                dlLocalLicenses.Columns[5].HeaderText = "Is Active";
                dlLocalLicenses.Columns[5].Width = 120;
            }
        }

        private void _LoadInternationalLicenses()
        {
            dlInternationalLicenses.LoadData(() => clsDriver.GetInternationalLicenses(_DriverID));

            if (dlInternationalLicenses.HasRows)
            {
                dlInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dlInternationalLicenses.Columns[0].Width = 150;

                dlInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dlInternationalLicenses.Columns[1].Width = 130;

                dlInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dlInternationalLicenses.Columns[2].Width = 130;

                dlInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dlInternationalLicenses.Columns[3].Width = 200;

                dlInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dlInternationalLicenses.Columns[4].Width = 200;

                dlInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dlInternationalLicenses.Columns[5].Width = 120;
            }
        }

        private void _ShowLocalLicense()
        {
            Form frm = new frmShowLocalLicenseInfo(dlLocalLicenses.SelectedRowID);
            frm.ShowDialog();
        }

        private void _ShowInternationalLicense()
        {
            Form frm = new frmShowInternationalLicenseInfo(dlInternationalLicenses.SelectedRowID);
            frm.ShowDialog();
        }

        public void LoadInfo(int DriverID)
        {
            if (!clsDriver.IsDriverExist(DriverID))
            {
                clsMessageBox.ShowError($"There is no driver with ID = [{DriverID}]");
                return;
            }

            _DriverID = DriverID;

            _LoadLocalLicenses();
            _LoadInternationalLicenses();
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            if (!clsDriver.IsDriverExist(PersonID, ref _DriverID))
            {
                clsMessageBox.ShowError($"There is no driver with PersonID = [{PersonID}]");
                return;
            }

            _LoadLocalLicenses();
            _LoadInternationalLicenses();
        }

        public void Clear()
        {
            dlLocalLicenses.Clear();
            dlInternationalLicenses.Clear();
        }

        private void showLocalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowLocalLicense();
        }

        private void showInternationalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowInternationalLicense();
        }

        private void dlLocalLicenses_RowDoubleClick(object sender, EventArgs e)
        {
            _ShowLocalLicense();
        }

        private void dlInternationalLicenses_RowDoubleClick(object sender, EventArgs e)
        {
            _ShowInternationalLicense();
        }

        private void cmsLocalLicenses_Opening(object sender, CancelEventArgs e)
        {
            cmsLocalLicenses.Enabled = dlLocalLicenses.HasRows;
        }

        private void cmsInternationalLicenses_Opening(object sender, CancelEventArgs e)
        {
            cmsInternationalLicenses.Enabled = dlInternationalLicenses.HasRows;
        }
    }
}
