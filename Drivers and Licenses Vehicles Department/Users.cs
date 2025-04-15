using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        //  private static DataTable _dtAllUsers = ClsUsers.ListUsers();

        private DataTable _dtUsers = ClsUsers.ListUsers();
            //_dtAllUsers.Copy();
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttons_Bar1_OnCalculationComplete()
        {
            this.Close();
        }

        public void _RefreshDataUsers()
        {
            // _dtAllUsers = ClsUsers.ListUsers();
            _dtUsers = ClsUsers.ListUsers();
              //  _dtAllUsers.Copy();
            DataViewUsers.DataSource = _dtUsers;
            lblRecords.Text=(DataViewUsers.Rows.Count).ToString();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            CBFilter.SelectedIndex = 0;
            CBIsActive.SelectedIndex = 0;

            _RefreshDataUsers();

            if (DataViewUsers.Rows.Count > 0)
            {
                DataViewUsers.Columns[0].HeaderText = "User ID";
                DataViewUsers.Columns[0].Width = 50;

                DataViewUsers.Columns[1].HeaderText = "Person ID";
                DataViewUsers.Columns[1].Width = 50;

                DataViewUsers.Columns[2].HeaderText = "Full Name";
                DataViewUsers.Columns[2].Width = 130;

                DataViewUsers.Columns[3].HeaderText = "User Name";
                DataViewUsers.Columns[3].Width = 70;

                DataViewUsers.Columns[4].HeaderText = "Password";
                DataViewUsers.Columns[4].Width = 70;

                DataViewUsers.Columns[5].HeaderText ="  Is Active";
                DataViewUsers.Columns[5].Width = 70;
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Form fm = new AddUpdateUser(-1);
            fm.ShowDialog();
            _RefreshDataUsers();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fm = new AddUpdateUser(-1);
            fm.ShowDialog();
            _RefreshDataUsers();
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fm = new AddUpdateUser((int)DataViewUsers.CurrentRow.Cells[0].Value);
            fm.ShowDialog();
            _RefreshDataUsers();
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBFilter.Text=="None")
            {
                CBIsActive.Visible= false;
                txtFilter.Visible= false;
                _dtUsers.DefaultView.RowFilter = "";
            }
            else if(CBFilter.Text=="IsActive")
            {
                CBIsActive.Visible= true;
                txtFilter.Visible= false;
            }
            else
            {
                CBIsActive.Visible=false;
                txtFilter.Visible=true;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
               _dtUsers.DefaultView.RowFilter = "";
                return;
            }

            try
            {
                if (CBFilter.Text == "PersonID" || CBFilter.Text=="UserID")
                {
                    _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", CBFilter.Text, txtFilter.Text);
                }
                else
                {
                    _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", CBFilter.Text, txtFilter.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while filtering: " + ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBIsActive.Text=="All")
            {
                _dtUsers.DefaultView.RowFilter = "";
            }
            else if(CBIsActive.Text=="Active")
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", CBFilter.Text, true);
            }
            else if(CBIsActive.Text=="Not Active")
            {

                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}",CBFilter.Text, false);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new ShowUserDetails((int)DataViewUsers.CurrentRow.Cells[0].Value);
            fm.ShowDialog();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this User?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ClsPeople.DeletePerson((int)DataViewUsers.CurrentRow.Cells[0].Value);
                MessageBox.Show("User is deleted successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataUsers();
            }

            else
            {
                MessageBox.Show("User not deleted", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Change_Password((int)DataViewUsers.CurrentRow.Cells[0].Value);
            fm.ShowDialog();
            _RefreshDataUsers();
        }
    }
}
