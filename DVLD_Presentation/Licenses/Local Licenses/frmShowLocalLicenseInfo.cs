using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Licenses.Local_Licenses
{
    public partial class frmShowLocalLicenseInfo : frmBase
    {
        public frmShowLocalLicenseInfo(int LicenseID)
        {
            InitializeComponent();

            ctrlDriverLocalLicenseCard1.LoadDriverLicenseInfo(LicenseID);
        }
    }
}
