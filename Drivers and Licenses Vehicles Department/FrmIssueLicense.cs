using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class FrmIssueLicense : Form
    {
        int _LocalDrivingLicenseID;
        ClsLocalLicense _LocalLicense;
        AddingStatus AddingStatus =new AddingStatus();
        public FrmIssueLicense(int LocalDrivingLicenseID)
        {
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            InitializeComponent();

            cardDrivingLicenseApplication1.LoadDataByID(LocalDrivingLicenseID) ;
        }

        private void FrmIssueLicense_Load(object sender, EventArgs e)
        {
           _LocalLicense =ClsLocalLicense.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseID);

            if(_LocalLicense == null)
            {
                MessageBox.Show("Local License Not found , try again ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(!_LocalLicense.IsPassedAllTest())
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

           int LicenseID = _LocalLicense.GetLicenseActive();

            if(LicenseID!=-1)
            {
                MessageBox.Show("Person already has License before ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = _LocalLicense.IssueLicenseForFirstTime(txtNotes.Text ,GLobal.CurrentUser.UserID); 

            if(LicenseID != -1)
            {
                AddingStatus.Tag = "License Issues Successfully !";
                AddingStatus.ShowDialog();
                this.Close();
            }
            else
            {
                AddingStatus.Tag = "License was not issues !";
                AddingStatus.ShowDialog();
            }
        }
    }
}
