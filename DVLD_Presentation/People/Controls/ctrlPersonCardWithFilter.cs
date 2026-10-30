using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public delegate void PersonSelectedEventHandler(int PersonID);
        public event PersonSelectedEventHandler PersonSelected;

        //public event Action<int> PersonSelected;
        //protected virtual void OnPersonSelected(int PersonID)
        //{
        //    Action<int> handler = PersonSelected;

        //    if (handler != null)
        //    {
        //        handler(PersonID);
        //    }
        //}

        public int PersonID 
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo 
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }

        public bool FilterEnabled
        {
            get
            {
                return gbFilter.Enabled;
            }
            set
            {
                gbFilter.Enabled = value;
            }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void _SearchPerson()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;
            }


            if (FilterEnabled)
                PersonSelected?.Invoke(PersonID);
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.Text = "Person ID";
            txtFilterValue.Text = PersonID.ToString();

            _SearchPerson();
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            txtFilterValue.Focus();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.PersonSaved += frmAddUpdatePerson_PersonSaved;
            frm.ShowDialog();
        }

        private void frmAddUpdatePerson_PersonSaved(object sender, int PersonID)
        {
            if (ctrlPersonCard1.LoadPersonInfo(PersonID))
            {
                cbFilterBy.Text = "Person ID";
                txtFilterValue.Text = PersonID.ToString();
            }
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessageBox.ShowValidationError();
                return;
            }
                
            _SearchPerson();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if user clicked 'Enter'
            
            //if (e.KeyChar == (char)Keys.Enter)
            if (e.KeyChar == (char)13)
            {
                btnSearchPerson.PerformClick();
            }

            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
