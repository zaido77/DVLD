using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Licenses.International_Licenses
{
    public partial class frmShowInternationalLicenseInfo : frmBase
    {
        private int _InternationalLicense = -1;

        public frmShowInternationalLicenseInfo(int InternationalLicense)
        {
            InitializeComponent();

            _InternationalLicense = InternationalLicense;
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseCard1.LoadInfo(_InternationalLicense);
        }
    }
}
