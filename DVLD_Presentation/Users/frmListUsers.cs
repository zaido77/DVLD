using DVLD_Business;
using DVLD_Presentation.Global_Classes;
using DVLD_Presentation.People;
using DVLD_Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class frmListUsers : frmBase
    {
        private DataTable _dtAllUsers;

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private int _GetSelectedUserID()
        {
            return (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
        }

        private void _AddNewUser()
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private string _GetTextFilterColumn()
        {
            switch (cbFilterBy.Text)
            {
                case "User ID": return "UserID";
                case "Username": return "Username";
                case "Person ID": return "PersonID";
                case "Full Name": return "FullName";
                default: return "None";
            }
        }
        
        private void _ShowUserDetails()
        {
            Form frm = new frmShowUserInfo(_GetSelectedUserID());
            frm.ShowDialog();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedItem = "None";
            lblRecordsCount.Text = dgvUsers.RowCount.ToString();

            if (_dtAllUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 130;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 130;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 400;

                dgvUsers.Columns[3].HeaderText = "Username";
                dgvUsers.Columns[3].Width = 130;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 130;
            }

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilter.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedItem = "All";
            }
            else
            {
                cbIsActive.Visible = false;
                txtFilter.Visible = (cbFilterBy.Text != "None");
                txtFilter.Clear();
                txtFilter.Focus();
            }

            _dtAllUsers.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvUsers.RowCount.ToString();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = _GetTextFilterColumn();

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.RowCount.ToString();
                return;
            }

            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                _dtAllUsers.DefaultView.RowFilter = $"{FilterColumn} = {txtFilter.Text.Trim()}";
            else
                _dtAllUsers.DefaultView.RowFilter = $"{FilterColumn} LIKE '{txtFilter.Text.Trim()}%'";

            lblRecordsCount.Text = dgvUsers.RowCount.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";

            switch (cbIsActive.Text)
            {
                case "All":
                    _dtAllUsers.DefaultView.RowFilter = "";
                    break;

                case "Yes":
                    _dtAllUsers.DefaultView.RowFilter = $"{FilterColumn} = 1";
                    break;

                case "No":
                    _dtAllUsers.DefaultView.RowFilter = $"{FilterColumn} = 0";
                    break;
            }

            lblRecordsCount.Text = dgvUsers.RowCount.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _AddNewUser();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddNewUser();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser(_GetSelectedUserID());
            frm.ShowDialog();
            _RefreshUsersList();
            //frmListUsers_Load(null, null);

            if (!clsGlobal.CurrentUser.IsActive)
            {
                clsMessageBox.ShowError("Your account is no longer active, " +
                    "You will be exited from the system!", "Deactivated User");
                Application.Exit();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(_GetSelectedUserID());
            frm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSendEmail((int)dgvUsers.CurrentRow.Cells["PersonID"].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = _GetSelectedUserID();

            if (UserID == clsGlobal.CurrentUser.ID)
            {
                clsMessageBox.ShowError("You cannot delete your logged in account.");
                return;
            }

            if (clsMessageBox.ShowWarning($"Are you sure you want to delete User [{UserID}]",
                "Confirm Delete") == DialogResult.OK)
            {
                if (clsUser.DeleteUser(UserID))
                {
                    clsMessageBox.ShowInfo("User Deleted Successfully.");
                    _RefreshUsersList();
                    //frmListUsers_Load(null, null);
                }
                else
                {
                    clsMessageBox.ShowError("User was not deleted due to data connected to it.");
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowUserDetails();
        }

        private void dgvUsersList_floatClick(object sender, EventArgs e)
        {
            _ShowUserDetails();
        }

        private void cmsUsers_Opening(object sender, CancelEventArgs e)
        {
            bool IsActive = (bool)dgvUsers.CurrentRow.Cells["IsActive"].Value;
            
            if (IsActive)
            {
                toggleActiveStatusToolStripMenuItem.Text = "De&activate";
                toggleActiveStatusToolStripMenuItem.Image = Resources.deactivate_32;
            }
            else
            {
                toggleActiveStatusToolStripMenuItem.Text = "&Activate";
                toggleActiveStatusToolStripMenuItem.Image = Resources.activate_32;
            }
            
            toggleActiveStatusToolStripMenuItem.Enabled = 
                (_GetSelectedUserID() != clsGlobal.CurrentUser.ID);
        }

        private void toggleActiveStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(_GetSelectedUserID());

            if (User.IsActive)
            {
                if (User.Deactivate())
                {
                    clsMessageBox.ShowInfo("User Deactivated Successfully.");
                    _RefreshUsersList();
                }
                else
                {
                    clsMessageBox.ShowError("Failed to Deactivated User.");
                }
            }
            else
            {
                if (User.Activate())
                {
                    clsMessageBox.ShowInfo("User Activated Successfully.");
                    _RefreshUsersList();
                }
                else
                {
                    clsMessageBox.ShowError("Failed to Activated User.");
                }
            }
        }

    }
}
