using BusinessDLVDLayer;
using Drivers_and_Licenses_Vehicles_Department.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessDLVDLayer.ClsTestTypes;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class ctrlSecheduledTest : UserControl
    {
        public ctrlSecheduledTest()
        {
            InitializeComponent();
        }

        private ClsTestTypes.enTestType _Type;


        private void _CheckTest()
        {
            switch (_Type)
            {
                case ClsTestTypes.enTestType.VisionTest:
                    { 
                        lblTitle.Text = "Vision Test";
                        gbTestType.Text = "Vision Test";
                        pbTestTypeImage.Image = Resources.Vision_512; break;

                    }
                case ClsTestTypes.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "Written Test";
                        gbTestType.Text = "Written Test";
                        pbTestTypeImage.Image = Resources.Written_Test_512; break;
                    }
                case ClsTestTypes.enTestType.StreetTest:
                    {
                        lblTitle.Text = "Street Test";
                        gbTestType.Text = "Street Test";
                        pbTestTypeImage.Image = Resources.driving_test_512; break;
                    }
            }
        }

        public void LoadDataTestAppointment(int TestAppointment,ClsTestTypes.enTestType Type)
        {
            _Type = Type;
            ClsTestAppointment Appointment = ClsTestAppointment.Find(TestAppointment);

            if(Appointment == null)
            {
                MessageBox.Show("Test Appointment not found , try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _CheckTest();

            ClsLocalLicense LocalLicense = ClsLocalLicense.FindByLocalDrivingAppLicenseID(Appointment.LocalDrivingLicenseApplicationID);
            lblLocalDrivingLicenseAppID.Text = LocalLicense.LocalDrivingLicenseID.ToString();
            lblDrivingClass.Text = LocalLicense.LicenseClassInfo.ClassName;
            lblFullName.Text = LocalLicense.FullName;
            lblTrial.Text = LocalLicense.GetTrialTest((int)Type).ToString();
            lblDate.Text = Appointment.AppointmentDate.ToString();
            lblFees.Text=Appointment.PaidFees.ToString();
            lblFees.Text = Appointment.PaidFees.ToString();
            lblTestID.Text=Appointment.TestID.ToString();
        }

        private void pbTestTypeImage_Click(object sender, EventArgs e)
        {

        }
    }
}
