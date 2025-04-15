using BusinessDLVDLayer;
using DVLD_Buisness;
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
    public partial class InterNationalLicense : Form
    {
        public InterNationalLicense()
        {
            InitializeComponent();
        }

        private DataTable _ListInternationaLicense = ClsInternationalLicense.GetAllInternationalLicenses();

        private void _RefreshDataInternationalLicense()
        {
            _ListInternationaLicense = ClsInternationalLicense.GetAllInternationalLicenses();
            DataViewInternaionalLicense.DataSource = _ListInternationaLicense;
            lblRecords.Text=DataViewInternaionalLicense.RowCount.ToString();

        }
        private void InterNationalLicense_Load(object sender, EventArgs e)
        {
            _RefreshDataInternationalLicense();

            // RowCount Return Actual Rows and New Row for Entering Data
            if(DataViewInternaionalLicense.RowCount > 0 )
            {
                // Do not Use It In This Condition , not Valid
            }

            CBFilter.SelectedIndex = 0;
            CBActivity.SelectedIndex = 0;

            //Row.Count Return Actual Rows Only , it is Valid

            if (DataViewInternaionalLicense.Rows.Count > 0 )
            {
                DataViewInternaionalLicense.Columns[0].HeaderText = "I.N.l ID";
                DataViewInternaionalLicense.Columns[0].Width = 100;

                DataViewInternaionalLicense.Columns[1].HeaderText = "Application ID";
                DataViewInternaionalLicense.Columns[1].Width = 100;

                DataViewInternaionalLicense.Columns[2].HeaderText = "Driver ID";
                DataViewInternaionalLicense.Columns[2].Width = 100;

                DataViewInternaionalLicense.Columns[3].HeaderText = "L.D.L ID";
                DataViewInternaionalLicense.Columns[3].Width = 100;

                DataViewInternaionalLicense.Columns[4].HeaderText = "Issue Date";
                DataViewInternaionalLicense.Columns[4].Width = 100;

                DataViewInternaionalLicense.Columns[5].HeaderText = "Expiration Date";
                DataViewInternaionalLicense.Columns[5].Width = 100;

                DataViewInternaionalLicense.Columns[6].HeaderText = "Is Active";
                DataViewInternaionalLicense.Columns[6].Width = 100;
            }
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (CBFilter.Text != "None" && CBFilter.Text != "Is Active");
            CBActivity.Visible = (CBFilter.Text == "Is Active");

            _ListInternationaLicense.DefaultView.RowFilter = "";
            lblRecords.Text = _ListInternationaLicense.Rows.Count.ToString();
        }

        private void CBActiviry_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ActiviryCase = false ;

            if (CBActivity.Text == "All")
            {
                _ListInternationaLicense.DefaultView.RowFilter = "";
            }
            else
            {
                ActiviryCase = CBActivity.Text == "Active" ? true : false;

                _ListInternationaLicense.DefaultView.RowFilter = string.Format("{0} = {1}", "IsActive", ActiviryCase);
            }
            lblRecords.Text = _ListInternationaLicense.Rows.Count.ToString();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = "";


            switch (CBFilter.Text)
            {
                case "International License ID":
                    FilterBy = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterBy = "ApplicationID";
                    break;
                case "Driver ID":
                    FilterBy = "DriverID";
                    break;
                case "Issued Local License ID":
                    FilterBy = "IssuedUsingLocalLicenseID";
                    break;
            }

            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                _ListInternationaLicense.DefaultView.RowFilter = "";
            }

            else
            {
                _ListInternationaLicense.DefaultView.RowFilter = string.Format("[{0}]= '{1}' ", FilterBy, txtFilter.Text.Trim());
            }

            lblRecords.Text = DataViewInternaionalLicense.Rows.Count.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLocalLicenseID = (int)DataViewInternaionalLicense.CurrentRow.Cells[0].Value;

            int PersonID = ClsInternationalLicense.Find(InternationalLocalLicenseID).ApplicationPersonID;

            Form fm = new ShowPersonDetails(PersonID);
            fm.ShowDialog();
            _RefreshDataInternationalLicense();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID= (int)DataViewInternaionalLicense.CurrentRow.Cells[0].Value;

            ClsInternationalLicense InternationalLicense = ClsInternationalLicense.Find(InternationalLicenseID);

            Form fm = new frmInternationalLicenseInfo(InternationalLicense);
            fm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int InternationalLicenseID = (int)DataViewInternaionalLicense.CurrentRow.Cells[0].Value;
            int ApplicationPersonID = ClsInternationalLicense.Find(InternationalLicenseID).ApplicationPersonID;
           

            Form fm = new FrmLicenseHistory(ApplicationPersonID);
            fm.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Form fm = new frmNewInternationalLicesnseApplication();
            fm.ShowDialog();
            _RefreshDataInternationalLicense();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}