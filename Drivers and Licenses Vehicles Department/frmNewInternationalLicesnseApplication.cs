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
    public partial class frmNewInternationalLicesnseApplication : Form
    {
        public frmNewInternationalLicesnseApplication()
        {
            InitializeComponent();
        }


        ClsInternationalLicense InternationalLicense =new ClsInternationalLicense();

        AddingStatus Status = new AddingStatus();

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewInternationalLicesnseApplication_Load(object sender, EventArgs e)
        {
            lblFees.Text = ClsApplicationTypes.Find((int)ClsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();
            lblIssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MMM/yyyy");
            lblCreatedByUser.Text = GLobal.CurrentUser.UserName;
        }

        private void IssueButton_Click(object sender, EventArgs e)
        {

            if (!cardLocalLicenseInfoWithFilter1.IsLocalLicenseFound)
            {
                MessageBox.Show("Sorry Local License Should Be Active .", "License Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!cardLocalLicenseInfoWithFilter1.IsActive)
            {
                MessageBox.Show("Please select a valid local license.", "License Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int activeInternationalLicenseID = ClsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(cardLocalLicenseInfoWithFilter1.DriverID);

            if (activeInternationalLicenseID != -1)
            {
                MessageBox.Show($"This driver already has an active international license with ID = {activeInternationalLicenseID}.", "License Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LastInternationalLicenseID = ClsInternationalLicense.DoesHaveInternationalLicenseBefore(cardLocalLicenseInfoWithFilter1.DriverID);

            if(LastInternationalLicenseID != -1)
            {
                ClsInternationalLicense.DeactivateInternationalLicense(LastInternationalLicenseID);
            }

            InternationalLicense.DriverID = cardLocalLicenseInfoWithFilter1.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = cardLocalLicenseInfoWithFilter1.LicenseID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);  
            InternationalLicense.ApplicationFees = float.Parse(lblFees.Text);
            InternationalLicense.ApplicationStatus = ClsInternationalLicense.enApplicationStatus.Completed;
            InternationalLicense.ApplicationPersonID = ClsDrivers.FindByDriverID(cardLocalLicenseInfoWithFilter1.DriverID).PersonID;
            InternationalLicense.ApplicationTypeID =(int) ClsApplication.enApplicationType.NewInternationalLicense;
            InternationalLicense.UserID  = InternationalLicense.CreatedByUserID = GLobal.CurrentUser.UserID;

            if (InternationalLicense.Save())
            {
                Status.Tag = "int.License Issued Successfully!";
                Status.ShowDialog(); 
                lblApplicationID.Text = InternationalLicense.ApplicationID.ToString();
                lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
                lblLocalLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
                IssueButton.Enabled = false;
                cardLocalLicenseInfoWithFilter1.GbFilterEnabled = false;
            }
            else
            {
                MessageBox.Show("Failed to issue the international license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
