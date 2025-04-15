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
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private DataTable _ListDrivers =ClsDrivers.ListDrivers();

        private void Drivers_Load(object sender, EventArgs e)
        {
            CBFilter.SelectedIndex = 0;

            _RefreshDataDrivers();

            if(DataViewDrivers.Rows.Count > 0)
            {
                DataViewDrivers.Columns[0].HeaderText = "Driver ID";
                DataViewDrivers.Columns[0].Width = 90;

                DataViewDrivers.Columns[1].HeaderText = "Person ID";
                DataViewDrivers.Columns[1].Width = 90;

                DataViewDrivers.Columns[2].HeaderText = "National No";
                DataViewDrivers.Columns[2].Width = 90;

                DataViewDrivers.Columns[3].HeaderText = "Full Name";
                DataViewDrivers.Columns[3].Width = 170;

                DataViewDrivers.Columns[4].HeaderText = "Date";
                DataViewDrivers.Columns[4].Width = 100;

                DataViewDrivers.Columns[5].HeaderText = "Active License";
                DataViewDrivers.Columns[5].Width = 100;
            }
        }

        private void _RefreshDataDrivers()
        {
            _ListDrivers =ClsDrivers.ListDrivers();
            DataViewDrivers.DataSource = _ListDrivers;
            lblRecords.Text=(DataViewDrivers.Rows.Count).ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttons_Bar1_OnCalculationComplete()
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID =(int) DataViewDrivers.CurrentRow.Cells[1].Value;

            Form fm=new ShowPersonDetails(PersonID);
            fm.ShowDialog();
        }

        private void IssueInternationalLincenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented yet .", "Issue International License", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void ShowLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID =(int) DataViewDrivers.CurrentRow.Cells[1].Value;

            Form fm=new FrmLicenseHistory(PersonID);
            fm.ShowDialog();
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBFilter.Text=="None")
            {
                txtFilter.Visible = false;
                _ListDrivers.DefaultView.RowFilter = "";
            }
            else
            {

                txtFilter.Visible=true;
                txtFilter.Clear();
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text) )
            {
                _ListDrivers.DefaultView.RowFilter = "";
                return;
            }

            string FilterText = "";

            switch (CBFilter.Text)
            {

                case "Driver ID":
                    FilterText = "DriverID";
                    break;

                case "Person ID":
                    FilterText = "PersonID";
                    break;

                case "National No":
                    FilterText = "NationalNo";
                    break;

                case "Full Name":
                    FilterText = "FullName";
                    break;
            }

            if (FilterText == "PersonID" || FilterText == "DriverID")
            {
                _ListDrivers.DefaultView.RowFilter = string.Format(" [{0}] = {1}", FilterText, txtFilter.Text.Trim());
            }
            else
            {
                _ListDrivers.DefaultView.RowFilter = string.Format(" [{0}] Like '{1}%' ", FilterText, txtFilter.Text.Trim());
            }
        }
    }
}
