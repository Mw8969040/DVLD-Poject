using BusinessDLVDLayer;
using Drivers_and_Licenses_Vehicles_Department.Properties;
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
using static BusinessDLVDLayer.ClsTestTypes;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class FrmListTestAppointments : Form
    {
        ClsTestTypes.enTestType _TestType;

        int _LocalLicneseID;
        int _AppointmentID = -1;
        public FrmListTestAppointments(int LocalDrivingLicenseApplicationID , ClsTestTypes.enTestType Type)
        {
            InitializeComponent();
            _TestType = Type;
            cardDrivingLicenseApplication1.LoadDataByID(LocalDrivingLicenseApplicationID);
            _LocalLicneseID = cardDrivingLicenseApplication1.LocalDrivingLicenseID;
        }

        private void _LoadByTest()
        {
            switch (_TestType)
            {
                case ClsTestTypes.enTestType.VisionTest:
                    { 
                        LblTitle.Text = "Vision Test Appointment";
                        pbTestTypeImage.Image = Resources.Vision_512; break;
                    }
                case ClsTestTypes.enTestType.WrittenTest:
                    {
                       LblTitle.Text = "Written Test Appointment";
                        pbTestTypeImage.Image = Resources.Written_Test_512; break;
                    }
                case ClsTestTypes.enTestType.StreetTest:
                    {
                        LblTitle.Text = "Written Test Appointment";
                        pbTestTypeImage.Image = Resources.driving_test_512; break;
                    }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadByTest();

            _RefreshDataViewTests();

            if (dgvLicenseTestAppointments.Rows.Count > 0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }
          
        }

        private void _RefreshDataViewTests()
        {
            dgvLicenseTestAppointments.DataSource = ClsTestAppointment.AppointmentTest(_LocalLicneseID, _TestType) ;
        }
        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            ClsLocalLicense LocalLicense = ClsLocalLicense.FindByLocalDrivingAppLicenseID(_LocalLicneseID);

            if (LocalLicense == null)
            {
                MessageBox.Show("Local License not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التأكد من عدم وجود موعد نشط
            if (LocalLicense.IsActive(_TestType))
            {
                MessageBox.Show("Person already has an active appointment for this test. You cannot add a new appointment.",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التأكد من عدم السماح بإعادة الاختبار إذا كان الشخص قد نجح بالفعل
            if (LocalLicense.IsPassed(_TestType))
            {
                MessageBox.Show("This person already passed this test before. You can only retake failed tests.",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            FrmScduleTest fm = new FrmScduleTest(LocalLicense.LocalDrivingLicenseID, _AppointmentID, _TestType);

            fm.ShowDialog();

            FrmListTestAppointments_Load(null, null);
        }


        private void updateTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int) dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            ClsTestAppointment Appointment=ClsTestAppointment.Find(AppointmentID);

            if(Appointment ==null)
            {
                MessageBox.Show("Appointment not found ,try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form fm = new FrmScduleTest(_LocalLicneseID, AppointmentID, _TestType);
            fm.ShowDialog();
            _RefreshDataViewTests();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;
            Form fm=new FrmTakeTest(AppointmentID ,_TestType);
            fm.ShowDialog();
            _RefreshDataViewTests();
        }
    }
}
