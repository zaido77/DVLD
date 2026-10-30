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
    public partial class frmShowLocalDrivingLicenseApplicationInfo : frmBase
    {
        public frmShowLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            ctrlLocalDrivingLicenseApplicationCard1.LoadApplicationInfo(LocalDrivingLicenseApplicationID);
        }
    }
}
