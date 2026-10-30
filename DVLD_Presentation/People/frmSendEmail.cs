using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DVLD_Presentation.People
{
    public partial class frmSendEmail : frmBase
    {
        clsPerson Person;

        public frmSendEmail(int PersonID)
        {
            InitializeComponent();

            Person = clsPerson.Find(PersonID);
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string EmailURL =
                $"https://mail.google.com/mail/?view=cm" +
                $"&to={Uri.EscapeDataString(Person.Email)}" +
                $"&su={Uri.EscapeDataString(txtSubject.Text)}" +
                $"&body={Uri.EscapeDataString(txtBody.Text)}";

            Process.Start(new ProcessStartInfo
            {
                FileName = EmailURL,
                UseShellExecute = true
            });
        }
    }
}
