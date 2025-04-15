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
    public partial class CardInternationalLicenseInfoWithFilter : UserControl
    {
        public CardInternationalLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private bool _GbFilterEnabled = true;

        private bool _IsLocalLicenseFound = false;

        private ClsLicense _License;

        private bool _ShowButtonSearchLicense = false;
        public ClsLicense License
        {
            get { return _License; }
        }

        public int DriverID
        {
            get { return cardLocalLicenseInfo1.DriverID; }
        }

        public int LicenseID
        {
            get { return cardLocalLicenseInfo1.LicenseID; }
        }

        public bool IsActive
        {
            get { return cardLocalLicenseInfo1.IsActive; }
        }
        public bool IsLocalLicenseFound
        {
            set { _IsLocalLicenseFound = value; }
            get { return _IsLocalLicenseFound; }
        }

        public bool GbFilterEnabled
        {
            get { return _GbFilterEnabled; }

            set { _GbFilterEnabled = value;
                GBFilter.Enabled = _GbFilterEnabled;
                 }
        }

        public bool ShowButtonSearchLicense
        {
            get { return _ShowButtonSearchLicense; }
            set
            {
                _ShowButtonSearchLicense = value;
                ButtonSearch.Visible = _ShowButtonSearchLicense;
            }
            
        }
        private void CardLocalLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {
            txtFilterLicense.Focus(); 
        }


        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int LicenseID = -1;

            if( txtFilterLicense.Text!="" && int.TryParse(txtFilterLicense.Text , out int Licenseid))
            {
                 LicenseID= Licenseid;
            }

            else
            {
                return;
            }

            _License = ClsLicense.Find(LicenseID);

            if (_License == null)
            {
                MessageBox.Show("License Not Found , Try Again ","Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
                _IsLocalLicenseFound = false;
                cardLocalLicenseInfo1.ResetData();
                return;
            }

            _IsLocalLicenseFound = true;
            cardLocalLicenseInfo1 .LoadData(License);
        }

        private void cardLocalLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void txtFilterLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
