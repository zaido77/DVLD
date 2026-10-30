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

namespace DVLD_Presentation.People
{
    public partial class frmListPeople : frmBase
    {
        DataView PeopleView;

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void _FillFilterComboBox()
        {
            cbFilterBy.Items.Clear();

            cbFilterBy.Items.Add("None");

            foreach (DataGridViewColumn col in dgvPeople.Columns)
            {
                if (col.Name != "Date Of Birth")
                    cbFilterBy.Items.Add(col.Name);
            }

            cbFilterBy.SelectedItem = "None";
        }

        private bool _RefreshPeopleList()
        {
            PeopleView = clsPerson.GetAllPeople().DefaultView;
            dgvPeople.DataSource = PeopleView;
            lblRecordsCount.Text = PeopleView.Count.ToString();
            return dgvPeople.RowCount > 0;
        }

        private void _AddNewPerson()
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            //frm.PersonSaved += frmAddEditPerson_PersonSaved;
            _RefreshPeopleList();
        }

        private int _GetSelectedPersonID()
        {
            return (int)dgvPeople.CurrentRow.Cells["Person ID"].Value;
        }

        private void _EditPerson()
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_GetSelectedPersonID());
            //frm.PersonSaved += frmAddEditPerson_PersonSaved;
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void _ShowPersonDetails()
        {
            Form frm = new frmShowPersonInfo(_GetSelectedPersonID());
            frm.ShowDialog();
        }

        private Type _GetSelectedColumnToFilterType()
        {
            DataGridViewColumn ColumnToFilter = dgvPeople.Columns[cbFilterBy.SelectedItem.ToString()];
            return ColumnToFilter.ValueType;
        }

        private string _GetRowFilterString(string ColumnToFilter, string FilterValue)
        {
            //if (cbFilterBy.Text == "PersonID")
            if (_GetSelectedColumnToFilterType() == typeof(int))
                return $"[{ColumnToFilter}] = {FilterValue}";
            else
                return $"[{ColumnToFilter}] LIKE '{FilterValue}%'";
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            if (_RefreshPeopleList())
                _FillFilterComboBox();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnToFilter = cbFilterBy.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && (ColumnToFilter != "None"))
            {
                PeopleView.RowFilter = _GetRowFilterString(ColumnToFilter, txtFilter.Text);
            }
            else
            {
                PeopleView.RowFilter = "";
            }

            lblRecordsCount.Text = PeopleView.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = cbFilterBy.Text != "None";
            txtFilter.Clear();
            txtFilter.Focus();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EditPerson();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson Person = clsPerson.Find(_GetSelectedPersonID()); 

            if (clsMessageBox.ShowWarning($"Are you sure you want to delete Person [{Person.ID}]", 
                "Confirm Delete") == DialogResult.OK)
            {
                if (clsPerson.DeletePerson(Person.ID))
                {
                    clsMessageBox.ShowInfo("Person Deleted Successfully.");
                    clsUtil.DeleteImageFromProjectImagesFolder(Person.ImagePath);
                    _RefreshPeopleList();
                }
                else
                {
                    clsMessageBox.ShowError("Person was not deleted because it has data linked to it.");
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowPersonDetails();
        }

        private void dgvPeopleList_floatClick(object sender, EventArgs e)
        {
            _ShowPersonDetails();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSendEmail(_GetSelectedPersonID());
            frm.ShowDialog();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmsPeople_Opening(object sender, CancelEventArgs e)
        {
            bool IsDataAvailable = dgvPeople.RowCount > 0;

            showDetailsToolStripMenuItem.Enabled = IsDataAvailable;
            editToolStripMenuItem.Enabled = IsDataAvailable;
            deleteToolStripMenuItem.Enabled = IsDataAvailable;
            sendEmailToolStripMenuItem.Enabled = IsDataAvailable;
            phoneCallToolStripMenuItem.Enabled = IsDataAvailable;
        }
    }
}
