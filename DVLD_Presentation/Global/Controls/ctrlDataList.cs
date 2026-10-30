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
    public partial class ctrlDataList : UserControl
    {
        public event EventHandler RowDoubleClick;

        protected Func<DataTable> _GetAllFunc;
        protected DataTable _dtAllRecords;

        public override ContextMenuStrip ContextMenuStrip
        {
            get { return dgvRecords.ContextMenuStrip; }
            set { dgvRecords.ContextMenuStrip = value; }
        }

        public DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode
        {
            get { return dgvRecords.AutoSizeColumnsMode; }
            set { dgvRecords.AutoSizeColumnsMode = value; }
        }

        public DataGridViewColumnCollection Columns
        {
            get { return dgvRecords.Columns;}
        }

        public int RowCount
        {
            get { return dgvRecords.RowCount; }
        }

        public bool HasRows
        {
            get { return RowCount > 0; }
        }

        public DataGridViewRow SelectedRow
        {
            get { return dgvRecords.CurrentRow; }
        }

        public int SelectedRowID
        {
            get { return HasRows ? (int)dgvRecords.CurrentRow.Cells[0].Value : -1; }
        }

        public ctrlDataList()
        {
            InitializeComponent();
        }

        public virtual void RefreshData()
        {
            _dtAllRecords = _GetAllFunc?.Invoke();
            dgvRecords.DataSource = _dtAllRecords;
            lblRecordsCount.Text = _dtAllRecords.Rows.Count.ToString();
        }

        public virtual void LoadData(Func<DataTable> GetAllFunc)
        {
            _GetAllFunc = GetAllFunc;
            RefreshData();
        }

        public void Clear()
        {
            _dtAllRecords.Clear();
            lblRecordsCount.Text = "0";
        }

        private void dgvRecords_DoubleClick(object sender, EventArgs e)
        {
            RowDoubleClick?.Invoke(this, EventArgs.Empty);
        }

    }
}
