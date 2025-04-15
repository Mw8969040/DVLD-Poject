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
    public partial class FrmTakeTest : Form
    {
       private int _TestAppointmentID;
        public FrmTakeTest(int TestAppointmentID , ClsTestTypes.enTestType TestType)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            ctrlSecheduledTest1.LoadDataTestAppointment(TestAppointmentID, TestType);
        }

        ClsTests _Tests = new ClsTests();
        AddingStatus _Status = new AddingStatus();
        ClsTestAppointment _Appointment ;

        private bool IsLocked()
        {
            _Appointment = ClsTestAppointment.Find(_TestAppointmentID);

            if(_Appointment != null )
            {
                return _Appointment.IsLocked == true; 
            }

            return false;
        }

        private void _LockScreen()
        {

            rbFail.Enabled = false;
            rbPass.Enabled = false;
            txtNotes.Enabled = false;
            btnSave.Enabled = false;
        }

        private void _LoadDataTestAndLockForm()
        {
            _Tests = ClsTests.FindByTestAppointment(_TestAppointmentID);

            if(_Tests == null )
            {
                MessageBox.Show("Test Not Found, Try again","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _LockScreen();
            
            if (_Tests.TestResult)
            {
                rbPass.Checked = true;
            }
            else
            {
                rbFail.Checked = true ;
            }

            txtNotes.Text = _Tests.Notes;

            lblUserMessage.Visible = true;
        }

        private void FrmTakeTest_Load(object sender, EventArgs e)
        {
            if(IsLocked())
            {
                _LoadDataTestAndLockForm();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private bool CheckTestResult()
        {
            if(rbPass.Checked)
            {
                return true; 
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!CheckTestResult())
            {
                _Tests.TestResult = false;
            }

            else
            {
                _Tests.TestResult = true;
            }

            _Tests.TestAppointmentID=_TestAppointmentID;
            _Tests.Notes=txtNotes.Text;
            _Tests.CreatedByUserID = GLobal.CurrentUser.UserID;

            _Appointment.IsLocked = true;

            if(_Tests.Save())
            {
                _Status.Tag = "Data Saved Successfully !";
                _Status.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error in saving User.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
