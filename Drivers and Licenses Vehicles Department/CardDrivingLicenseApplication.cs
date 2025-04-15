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
    public partial class CardDrivingLicenseApplication : UserControl
    {
        public CardDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private int _LocalDrivingLicenseID = -1;

        private ClsLocalLicense _LocalLicense;

        public int LocalDrivingLicenseID { get { return _LocalDrivingLicenseID; } }

        private void _FillDataLicenseInfo()
        {
            _LocalDrivingLicenseID = _LocalLicense.LocalDrivingLicenseID;

            lblLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseID.ToString();
            lblAppliedFor.Text = _LocalLicense.LicenseClassInfo.ClassName;
            lblPassedTests.Text = ClsTests.GetPassedTestCount(_LocalDrivingLicenseID).ToString();
            cardApplicationBasicInfo1.LoadData(_LocalLicense.ApplicationID);
        }

        public void LoadDataByID(int LocalDrivingLicenseID)
        {
            _LocalLicense = ClsLocalLicense.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseID);

            if (_LocalLicense == null)
            {
                MessageBox.Show("Local License Not Found , Try Again .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillDataLicenseInfo();
        }

        private void CardDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

        }

    }
}
