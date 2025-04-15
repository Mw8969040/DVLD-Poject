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
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllPeople = ClsPeople.ListPeople();

        private DataTable _dtPeople = _dtAllPeople.Copy();
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshDataPeople()
        {
            _dtAllPeople = ClsPeople.ListPeople();
            _dtPeople = _dtAllPeople.Copy();
            DataViewPeople.DataSource = _dtPeople;
            lblRecords.Text=(DataViewPeople.Rows.Count).ToString();
        }

        private void People_Load(object sender, EventArgs e)
        {
            _RefreshDataPeople();
            CBFilter.SelectedIndex = 0;

            if(DataViewPeople.Rows.Count >0)
            {
                DataViewPeople.Columns[0].HeaderText = "Person ID";
                DataViewPeople.Columns[0].Width = 80;  

                DataViewPeople.Columns[1].HeaderText = "National No";
                DataViewPeople.Columns[1].Width = 110; 

                DataViewPeople.Columns[2].HeaderText = "First Name";
                DataViewPeople.Columns[2].Width = 90;  

                DataViewPeople.Columns[3].HeaderText = "Second Name";
                DataViewPeople.Columns[3].Width = 100; 

                DataViewPeople.Columns[4].HeaderText = "Third Name";
                DataViewPeople.Columns[4].Width = 90;

                DataViewPeople.Columns[5].HeaderText = "Last Name";
                DataViewPeople.Columns[5].Width = 90;

                DataViewPeople.Columns[6].HeaderText = "Date Of Birth";
                DataViewPeople.Columns[6].Width = 100; 

                DataViewPeople.Columns[7].HeaderText = "Gendor";
                DataViewPeople.Columns[7].Width = 70;  

                DataViewPeople.Columns[8].HeaderText = "Address";
                DataViewPeople.Columns[8].Width = 130; 

                DataViewPeople.Columns[9].HeaderText = "Phone";
                DataViewPeople.Columns[9].Width = 100; 

                DataViewPeople.Columns[10].HeaderText = "Email";
                DataViewPeople.Columns[10].Width = 140; 

                DataViewPeople.Columns[11].HeaderText = "Nationality";
                DataViewPeople.Columns[11].Width = 100; 


            }
        }

        private void buttons_Bar1_OnCalculationComplete()
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Form fm = new AddPerson(-1);
            fm.ShowDialog();
            _RefreshDataPeople();
        }

        private void People_Resize(object sender, EventArgs e)
        {
            ButtonAdd.Location = new Point(DataViewPeople.Right - ButtonAdd.Width, DataViewPeople.Top - ButtonAdd.Height - 5);
            PicturePeople.Location = new Point(DataViewPeople.Left + (DataViewPeople.Width - PicturePeople.Width) / 2, DataViewPeople.Top - PicturePeople.Height - 50);

        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fm = new AddPerson((int)DataViewPeople.CurrentRow.Cells[0].Value);
            fm.ShowDialog();
            _RefreshDataPeople();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClsUsers.IsPersonIDNotExist((int)DataViewPeople.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("It Can not be Deleted , because it is System Related .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            else if (MessageBox.Show("Are you sure to delete this Person?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ClsPeople.DeletePerson((int)DataViewPeople.CurrentRow.Cells[0].Value);
                MessageBox.Show("Person is deleted successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataPeople();
            }

            else
            {
                MessageBox.Show("Person not deleted", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new ShowPersonDetails((int)DataViewPeople.CurrentRow.Cells[0].Value);
            fm.ShowDialog();
            _RefreshDataPeople();
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = CBFilter.Text != "None";
            _dtPeople.DefaultView.RowFilter = "";
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text) || CBFilter.Text == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                return;
            }

            try
            {
                if (CBFilter.Text == "PersonID")
                {
                       _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", CBFilter.Text,txtFilter.Text);
                }
                else
                {
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", CBFilter.Text, txtFilter.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while filtering: " + ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
