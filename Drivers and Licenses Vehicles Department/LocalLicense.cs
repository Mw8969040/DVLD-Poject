using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class LocalLicense : Form
    {
        public LocalLicense()
        {
            InitializeComponent();
        }

        private DataTable _dtLocalLicense=ClsLocalLicense.ListLocalLicense();

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshDataLocalLicense()
        {
            _dtLocalLicense = ClsLocalLicense.ListLocalLicense();
            DataViewLocalLicense.DataSource = _dtLocalLicense;
            lblRecords.Text=DataViewLocalLicense.Rows.Count.ToString();
        }

        private void LocalLicense_Load(object sender, EventArgs e)
        {
            _RefreshDataLocalLicense();

            CBFilter.SelectedIndex = 0;
            CBStatus.SelectedIndex = 0;

            if(DataViewLocalLicense.Rows.Count > 0)
            {
                DataViewLocalLicense.Columns[0].HeaderText = "LDL AppID";
                DataViewLocalLicense.Columns[0].Width = 70;

                DataViewLocalLicense.Columns[1].HeaderText = "Driving Class";
                DataViewLocalLicense.Columns[1].Width = 100;

                DataViewLocalLicense.Columns[2].HeaderText = "National No";
                DataViewLocalLicense.Columns[2].Width = 50;

                DataViewLocalLicense.Columns[3].HeaderText = "Full Name";
                DataViewLocalLicense.Columns[3].Width = 120;

                DataViewLocalLicense.Columns[4].HeaderText = "Application Date";
                DataViewLocalLicense.Columns[4].Width = 100;

                DataViewLocalLicense.Columns[5].HeaderText = "Passed Test";
                DataViewLocalLicense.Columns[5].Width= 50;

                DataViewLocalLicense.Columns[6].HeaderText = "Status";
                DataViewLocalLicense.Columns[6].Width = 100;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Form fm=new FrmNewLocalDrivingLicense();
            fm.ShowDialog();
            _RefreshDataLocalLicense();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new FrmNewLocalDrivingLicense((int)DataViewLocalLicense.CurrentRow.Cells[0].Value);
            fm.ShowDialog();
            _RefreshDataLocalLicense();
        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)DataViewLocalLicense.CurrentRow.Cells[0].Value;

            ClsLocalLicense LocalDrivingLicenseApplication =
                ClsLocalLicense.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.DeleteLocalLicense())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDataLocalLicense();
                }
                else
                {
                    MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           txtFilter.Visible = (CBFilter.Text != "None" && CBFilter.Text != "Status");
            CBStatus.Visible = (CBFilter.Text == "Status");

            _dtLocalLicense.DefaultView.RowFilter = "";
            lblRecords.Text = _dtLocalLicense.Rows.Count.ToString();
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBStatus.Text =="All")
            {
                _dtLocalLicense.DefaultView.RowFilter = "";
            }
            else
            {
                _dtLocalLicense.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", CBFilter.Text, CBStatus.Text);
            }
            lblRecords.Text = DataViewLocalLicense.Rows.Count.ToString();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = "";


            switch(CBFilter.Text)
            {
                case "LDLAppID":
                    FilterBy = "LocalDrivingLicenseApplicationID";
                    break;
                case "Full Name":
                    FilterBy = "FullName";
                    break;
                case "National No":
                    FilterBy = "NationalNo";
                    break;
            }

            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                _dtLocalLicense.DefaultView.RowFilter = "";
            }

            else if (CBFilter.Text=="LDLAppID")
            {
                _dtLocalLicense.DefaultView.RowFilter=string.Format("[{0}] = {1} ",FilterBy,txtFilter.Text.Trim());
            }

            else
            {
                _dtLocalLicense.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' ", FilterBy, txtFilter.Text.Trim());
            }

            lblRecords.Text = DataViewLocalLicense.Rows.Count.ToString();
        }

        private void CancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to Cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)DataViewLocalLicense.CurrentRow.Cells[0].Value;

            ClsLocalLicense LocalDrivingLicenseApplication =
                ClsLocalLicense.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDataLocalLicense();
                }
                else
                {
                    MessageBox.Show("Could not Concel applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalLicenseID = (int)DataViewLocalLicense.CurrentRow.Cells[0].Value;
            Form fm=new FrmLocalLicenseApplicationInfo(LocalLicenseID);
            fm.ShowDialog();
            _RefreshDataLocalLicense();
        }

        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DataViewLocalLicense.CurrentRow.Cells[0].Value;

            Form fm = new FrmListTestAppointments(LocalDrivingLicenseApplicationID,ClsTestTypes.enTestType.VisionTest);
            fm.ShowDialog();
            _RefreshDataLocalLicense();
        }


        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DataViewLocalLicense.CurrentRow.Cells[0].Value;

            Form fm = new FrmListTestAppointments(LocalDrivingLicenseApplicationID, ClsTestTypes.enTestType.WrittenTest);
            fm.ShowDialog();
            _RefreshDataLocalLicense();
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DataViewLocalLicense.CurrentRow.Cells[0].Value;

            Form fm = new FrmListTestAppointments(LocalDrivingLicenseApplicationID, ClsTestTypes.enTestType.StreetTest);
            fm.ShowDialog();
            _RefreshDataLocalLicense();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseID = (int)DataViewLocalLicense.CurrentRow.Cells[0].Value;
            ClsLocalLicense LocalLicense = ClsLocalLicense.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseID);

            Form fm = new FrmLicenseHistory(LocalLicense.ApplicationPersonID);
            fm.ShowDialog();
        }

        private void iSSUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseID = (int)DataViewLocalLicense.CurrentRow.Cells[0].Value;
            Form fm = new FrmIssueLicense(LocalDrivingLicenseID);
            fm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalLicenseID = (int) DataViewLocalLicense.CurrentRow.Cells[0].Value;

            int LicenseID=ClsLocalLicense.FindByLocalDrivingAppLicenseID(LocalLicenseID).GetLicenseActive();
    
            if(LicenseID ==-1)
            {
                MessageBox.Show("License not Found , Try Again !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            ClsLicense License = ClsLicense.Find(LicenseID);

            Form fm = new FrmShowLicenseInfo(License);
            fm.ShowDialog();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
