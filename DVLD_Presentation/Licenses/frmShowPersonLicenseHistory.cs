using DVLD_Presentation.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Licenses
{
    public partial class frmShowPersonLicenseHistory : frmBase
    {
        int _PersonID = -1;

        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
        }

        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                ctrlPersonCardWithFilter1.FilterEnabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void ctrlPersonCardWithFilter1_PersonSelected(int PersonID)
        {
            if (PersonID != -1)
                ctrlDriverLicenses1.LoadInfoByPersonID(PersonID);
            else
                ctrlDriverLicenses1.Clear();
        }

        private void frmShowPersonLicenseHistory_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
    }
}
