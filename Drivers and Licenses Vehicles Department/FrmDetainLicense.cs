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
    public partial class FrmDetainLicense : Form
    {
        public FrmDetainLicense()
        {
            InitializeComponent();
        }

        private DataTable _ListDetainedLicense = ClsDetainLicense.GetAllDetainedLicenses();

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshDataDetainedLicense ()
        {
            _ListDetainedLicense = ClsDetainLicense.GetAllDetainedLicenses ();
            DataViewDetainedLicense.DataSource = _ListDetainedLicense;
            lblRecords.Text=DataViewDetainedLicense.Rows.Count.ToString();
        }
        private void FrmDetainLicense_Load(object sender, EventArgs e)
        {
            if (DataViewDetainedLicense.Rows.Count > 0)
            {
               DataViewDetainedLicense.Columns[0].HeaderText = "D.ID";
               DataViewDetainedLicense.Columns[0].Width = 90;

               DataViewDetainedLicense.Columns[1].HeaderText = "L.ID";
               DataViewDetainedLicense.Columns[1].Width = 90;

               DataViewDetainedLicense.Columns[2].HeaderText = "D.Date";
               DataViewDetainedLicense.Columns[2].Width = 160;

               DataViewDetainedLicense.Columns[3].HeaderText = "Is Released";
               DataViewDetainedLicense.Columns[3].Width = 110;

               DataViewDetainedLicense.Columns[4].HeaderText = "Fine Fees";
               DataViewDetainedLicense.Columns[4].Width = 110;

               DataViewDetainedLicense.Columns[5].HeaderText = "Release Date";
               DataViewDetainedLicense.Columns[5].Width = 160;

                DataViewDetainedLicense.Columns[6].HeaderText = "N.No.";
                DataViewDetainedLicense.Columns[6].Width = 90;

               DataViewDetainedLicense.Columns[7].HeaderText = "Full Name";
               DataViewDetainedLicense.Columns[7].Width = 330;

               DataViewDetainedLicense.Columns[8].HeaderText = "Rlease App.ID";
               DataViewDetainedLicense.Columns[8].Width = 150;

            }
        }

        private void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}