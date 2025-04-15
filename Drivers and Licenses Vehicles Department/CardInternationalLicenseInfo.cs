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
    public partial class CardInternationalLicenseInfo : UserControl
    {


        public CardInternationalLicenseInfo()
        {
            InitializeComponent();
        }



        private int _InternationalLicenseID;

        private ClsLocalLicense _InternationalLicense;

        public ClsLocalLicense InternationalLicense
        {
            get { return _InternationalLicense; }
        }

        public int LocalLicenseID
        {
            get { return _InternationalLicenseID; }
        }
        private void CardInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(ClsInternationalLicense InternationalLicense)
        {
            lblInternationalLicenseID.Text =InternationalLicense.InternationalLicenseID.ToString();
            lblLocalLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = InternationalLicense.IssueDate.ToString("dd/MM/yyyy");
            lblExpirationDate.Text = InternationalLicense.ExpirationDate.ToString("dd/MM/yyyy");
            lblApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = InternationalLicense.IsActive == true ? "True" : "false";
            lblDriverID.Text =InternationalLicense.DriverID.ToString();
            lblFullName.Text = InternationalLicense.FullName;
            lblNationalNo.Text = InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblDateOfBirth.Text = InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lblGendor.Text = InternationalLicense.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
