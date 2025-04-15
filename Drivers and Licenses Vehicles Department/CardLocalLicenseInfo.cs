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
    public partial class CardLocalLicenseInfo : UserControl
    {
        public CardLocalLicenseInfo()
        {
            InitializeComponent();
        }

        private int _LicenseID;

        private ClsLocalLicense _LocalLicense;

        private int _DriverID;
   
        private bool _IsActive;

        public ClsLocalLicense LocalLicense
        {
            get { return _LocalLicense; }
        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }

       
        public bool IsActive
        {
            get { return _IsActive; }
        }

        public int DriverID
        {
            get { return _DriverID; }
        }

        public void LoadData(ClsLicense license)
        {
           
            _LicenseID = license.LicenseID;
            _DriverID = license.DriverID;
            _IsActive = license.IsActive;
           
            lblClass.Text = license.LicenseClassInfo.ClassName.ToString();
            lblFullName.Text = license.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text =license.LicenseID.ToString();
            lblNationalNo.Text = license.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = license.DriverInfo.PersonInfo.Gendor==0 ? "Male" : "Female" ;
            lblIssueDate.Text = license.IssueDate.ToString("dd/MM/yyyy");
            lblIssueReason.Text=license.IssueReason.ToString();
            lblNotes.Text = license.Notes;
            lblIsActive.Text = license.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text=license.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lblDriverID.Text=license.DriverID.ToString();
            lblExpirationDate.Text=license.ExpirationDate.ToString("dd/MM/yyyy");

            if (license.DriverInfo.PersonInfo.ImagePath == "")
            {
                pbPersonImage.Image = (license.DriverInfo.PersonInfo.Gendor == 0 ? Properties.Resources.Male_512 : Properties.Resources.Female_512);
            }
            else
            {
                pbPersonImage.Load(license.DriverInfo.PersonInfo.ImagePath);
            }
        }

        public void ResetData()
        {
            lblClass.Text = "[????]";
            lblFullName.Text = "[????]";
            lblLicenseID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblGendor.Text = "[????]";
            lblIssueReason.Text = "[????]";
            lblIssueDate.Text = "[????]";
            lblNotes.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblDriverID.Text = "[????]";
            lblExpirationDate.Text = "[????]";
            pbPersonImage.Image=Properties.Resources.Male_512;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CardLocalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
