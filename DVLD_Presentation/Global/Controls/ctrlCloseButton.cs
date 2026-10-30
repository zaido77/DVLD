using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class ctrlCloseButton : Button
    {
        public override Font Font 
        {
            get
            {
                return btnClose.Font;
            }
            set
            {
                btnClose.Font = value;
            }
        }

        public new Image Image
        {
            get
            {
                return btnClose.Image;
            }
            set
            {
                btnClose.Image = value;
            }
        }

        public ctrlCloseButton()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form CurrentForm = this.FindForm();

            if (CurrentForm != null)
                CurrentForm.Close();
        }
    }
}
