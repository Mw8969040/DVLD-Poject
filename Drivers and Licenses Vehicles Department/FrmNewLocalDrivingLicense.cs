using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class FrmNewLocalDrivingLicense : Form
    {

        enum EnMode { AddMode=0 , UpdateMode=1 };
        EnMode enMode;
        int _LocalLicenseID;
        ClsLocalLicense _LocalLicense;
        AddingStatus _AddingStatus =new AddingStatus();
        public FrmNewLocalDrivingLicense()
        {
            InitializeComponent();
            enMode = EnMode.AddMode;

            cardOfPersonWithFilter1.FilterEnabled = true;
            cardOfPersonWithFilter1.ShowButtonAdd = true;
            cardOfPersonWithFilter1.ShowButtonSearch = true;
        }

        public FrmNewLocalDrivingLicense(int LocalLicenseID)
        {
            InitializeComponent();
            _LocalLicenseID = LocalLicenseID;
            enMode=EnMode.UpdateMode;

            cardOfPersonWithFilter1.FilterEnabled = false;
            cardOfPersonWithFilter1.ShowButtonAdd = false;
            cardOfPersonWithFilter1.ShowButtonSearch = false;
        }

        private void _FillComboBoxLicenseClass()
        {
            DataTable dt = ClsLicenseClass.ListLicenseClass();

            foreach(DataRow dr in dt.Rows)
            {
                CBLicenseClass.Items.Add(dr["ClassName"]);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            _FillComboBoxLicenseClass();
            
            if (enMode == EnMode.AddMode)
            {
                LblLDL.Text = "New Local Driving License Application";
                _LocalLicense = new ClsLocalLicense();
                _AddingStatus.Tag = "Local License Added Successfully";
                CBLicenseClass.SelectedIndex = 2;
                LblAppFees.Text = ClsApplicationTypes.Find((int)ClsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();
                LblAppDate.Text = DateTime.Now.ToString();
                LblUser.Text = GLobal.CurrentUser.UserID.ToString();
                ApplicationInfo.Enabled = false;
                return;
            }

            _LocalLicense = ClsLocalLicense.FindByLocalDrivingAppLicenseID(_LocalLicenseID);

            if (_LocalLicense == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalLicenseID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            LblLDL.Text = "Edit Local Driving License With ID = " + _LocalLicenseID;
            LblLDL.Location = new Point((this.ClientSize.Width - LblLDL.Width) / 2, 15);
            ApplicationInfo.Enabled = true;
            cardOfPersonWithFilter1.LoadPersonInfo(_LocalLicense.ApplicationPersonID);
            cardOfPersonWithFilter1.FilterEnabled = false;
            LblID.Text = _LocalLicense.LocalDrivingLicenseID.ToString();
            LblAppDate.Text = _LocalLicense.LastStatusDate.ToString();
            CBLicenseClass.Text = _LocalLicense.LicenseClassInfo.ClassName;
            LblAppFees.Text = _LocalLicense.ApplicationFees.ToString();
            LblUser.Text = _LocalLicense.UserID.ToString();
        }

        private void FrmNewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

            if (enMode == EnMode.UpdateMode || cardOfPersonWithFilter1.PersonID!=-1)
            {
                TabControl.SelectedTab = ApplicationInfo;
                ButtonSave.Visible = true;
                ApplicationInfo.Enabled = true;
                this.ActiveControl = null;
            }

            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = PersonInfo;
            ButtonSave.Visible = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = ClsLicenseClass.Find(CBLicenseClass.Text).ID;

            int ActiveApplicationID = ClsApplication.GetActiveApplicationIDForLicenseClass(cardOfPersonWithFilter1.PersonID, ClsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

            if(ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBLicenseClass.Focus();
                return;
            }

            if (int.TryParse(LblID.Text, out int applicationID))
            {
                _LocalLicense.ApplicationID = applicationID;
            }

            if (enMode==EnMode.UpdateMode)
            {
                _LocalLicense.ApplicationDate=_LocalLicense.ApplicationDate;
                _LocalLicense.LastStatusDate = DateTime.Now;
            }
            else
            {
                _LocalLicense.ApplicationDate = DateTime.Now;
                _LocalLicense.LastStatusDate= DateTime.Now;
            }

            _LocalLicense.LicenseClassID = ClsLicenseClass.Find(CBLicenseClass.Text).ID;
            _LocalLicense.UserID = GLobal.CurrentUser.UserID;
            _LocalLicense.ApplicationTypeID = 1;
            _LocalLicense.ApplicationStatus = ClsApplication.enApplicationStatus.New;
            _LocalLicense.ApplicationPersonID = cardOfPersonWithFilter1.PersonID;
            _LocalLicense.ApplicationFees = ClsLicenseClass.Find(CBLicenseClass.Text).Fees;

            if(_LocalLicense.Save())
            {
               _AddingStatus.ShowDialog();           
            }

            else
            {
                MessageBox.Show("Error in saving Application.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (enMode == EnMode.AddMode)
            {
                LblLDL.Location = new Point((this.ClientSize.Width - LblLDL.Width) / 2, 15);
                LblID.Text = _LocalLicense.LocalDrivingLicenseID.ToString();
                LblLDL.Text = "Edit Local Driving License With ID = " + _LocalLicense.LocalDrivingLicenseID;
            }
        }
    }
}
