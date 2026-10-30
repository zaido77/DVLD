using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Global_Controls
{
    public partial class ctrlDataListWithFilter : ctrlDataList
    {
        public ctrlDataListWithFilter()
        {
            InitializeComponent();
        }

        private void _FillFilterComboBox(params string[] FilterItemsToShow)
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.Add("None");

            foreach (DataGridViewColumn column in dgvRecords.Columns)
            {
                if (!FilterItemsToShow.Any())
                    cbFilterBy.Items.Add(column.Name);
                else
                {
                    if (FilterItemsToShow.Contains(column.Name))
                        cbFilterBy.Items.Add(column.Name);
                }
            }
            
            cbFilterBy.SelectedItem = "None";
        }

        private Type _GetSelectedFilterColumnType()
        {
            string FilterColumn = cbFilterBy.SelectedItem.ToString();

            if (FilterColumn == "None")
                return null;

            DataGridViewColumn ColumnToFilter = dgvRecords.Columns[FilterColumn];
            return ColumnToFilter.ValueType;
        }

        private string _GetRowFilterString(string FilterColumn, string FilterValue)
        {
            Type FilterColumnType = _GetSelectedFilterColumnType();

            if (FilterColumnType == typeof(int))
                return $"[{FilterColumn}] = {FilterValue}";
            else
                return $"[{FilterColumn}] LIKE '{FilterValue}%'";
        }

        public override void RefreshData()
        {
            cbFilterBy.SelectedItem = "None";
            base.RefreshData();
        }

        public override void LoadData(Func<DataTable> GetAllFunc)
        {
            base.LoadData(GetAllFunc); 
            _FillFilterComboBox();
        }

        // Make sure that Filter Items are written exactly the same as in the Data List.
        public void ShowFilterItems(params string[] FilterItemsToShow)
        {
            _FillFilterComboBox(FilterItemsToShow);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterBy.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(txtFilter.Text.Trim()) && (FilterColumn != "None"))
            {
                _dtAllRecords.DefaultView.RowFilter = _GetRowFilterString(FilterColumn, txtFilter.Text);
            }
            else
            {
                _dtAllRecords.DefaultView.RowFilter = "";
            }

            lblRecordsCount.Text = dgvRecords.RowCount.ToString();
        }

        private void cbAllYesNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterBy.Text;

            switch (cbAllYesNo.Text)
            {
                case "All":
                    _dtAllRecords.DefaultView.RowFilter = "";
                    break;

                case "Yes":
                    _dtAllRecords.DefaultView.RowFilter = $"[{FilterColumn}] = 1";
                    break;

                case "No":
                    _dtAllRecords.DefaultView.RowFilter = $"[{FilterColumn}] = 0";
                    break;
            }

            lblRecordsCount.Text = dgvRecords.RowCount.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_GetSelectedFilterColumnType() == typeof(bool))
            {
                txtFilter.Visible = false;
                cbAllYesNo.Visible = true;
                cbAllYesNo.Focus();
                cbAllYesNo.SelectedItem = "All";
            }
            else
            {
                cbAllYesNo.Visible = false;
                txtFilter.Visible = (cbFilterBy.Text != "None");
                txtFilter.Clear();
                txtFilter.Focus();
            }

            _dtAllRecords.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvRecords.RowCount.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_GetSelectedFilterColumnType() == typeof(int))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
