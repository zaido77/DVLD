using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Global_Controls
{
    public partial class ctrlTitle : UserControl
    {
        public string TitleText
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public Font TitleFont
        {
            get
            {
                return lblTitle.Font;
            }
            set
            {
                lblTitle.Font = value;
            }
        }

        public ctrlTitle()
        {
            InitializeComponent();

            lblTitle.ForeColor = clsUISettings.MainColor;
        }
    }
}