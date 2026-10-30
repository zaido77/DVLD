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

namespace DVLD_Presentation.Applications.Application_Types
{
    public partial class frmListApplicationTypes : frmBase
    {
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {
            dlApplicationTypes.LoadData(clsApplicationType.GetAllApplicationTypes);

            if (dlApplicationTypes.HasRows)
            {
                dlApplicationTypes.Columns[0].HeaderText = "ID";
                dlApplicationTypes.Columns[0].Width = 130;

                dlApplicationTypes.Columns[1].HeaderText = "Title";
                dlApplicationTypes.Columns[1].Width = 450;

                dlApplicationTypes.Columns[2].HeaderText = "Fees";
                dlApplicationTypes.Columns[2].Width = 130;
            }
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateApplicationType(dlApplicationTypes.SelectedRowID);
            frm.ShowDialog();
            dlApplicationTypes.RefreshData();
        }
    }
}
