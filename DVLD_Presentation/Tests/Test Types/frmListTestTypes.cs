using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests.Test_Types
{
    public partial class frmListTestTypes : frmBase
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            dlTestTypes.LoadData(clsTestType.GetAllTestTypes);

            if (dlTestTypes.HasRows)
            {
                dlTestTypes.Columns[0].HeaderText = "ID";
                dlTestTypes.Columns[0].Width = 120;

                dlTestTypes.Columns[1].HeaderText = "Title";
                dlTestTypes.Columns[1].Width = 220;

                dlTestTypes.Columns[2].HeaderText = "Description";
                dlTestTypes.Columns[2].Width = 480;

                dlTestTypes.Columns[3].HeaderText = "Fees";
                dlTestTypes.Columns[3].Width = 120;
            }
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateTestType((clsTestType.enTestType)dlTestTypes.SelectedRowID);
            frm.ShowDialog();
            frmListTestTypes_Load(null, null);
            //dlTestTypes.RefreshData();
        }

    }
}
