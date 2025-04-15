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

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class CardScduleTest : UserControl
    {
        public CardScduleTest()
        {
            InitializeComponent();
        }

        public enum EnMode { AddMode=0 , UpdateMode=1 };
        EnMode Mode;

        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        enCreationMode CreationMode;

        ClsTestTypes.enTestType Type = ClsTestTypes.enTestType.VisionTest;

        private ClsLocalLicense _LocalLicense;

        private int _LocalDrivingLicenseID;
        private int _AppointMentID;

        private ClsTestAppointment _Appointment ;
        private AddingStatus _AddingStatus = new AddingStatus();
        public int AppointMentID
        {
            get { return _AppointMentID; }
        }

        public ClsTestAppointment Appointment
        {
            get { return _Appointment; }
        }
        public ClsTestTypes.enTestType TestType
        {
            set; get;
        }

        public bool RetakeInfoGB
        {
            set { gbRetakeTestInfo.Enabled = value; }
        }

        private void _CheckTest()
        {
            switch(TestType)
            {
                case ClsTestTypes.enTestType.VisionTest:
                    {
                        Type = ClsTestTypes.enTestType.VisionTest;
                        lblTitle.Text = "Vision Test";
                        pbTestTypeImage.Image = Resources.Vision_512;  break;
                       
                    }
                case ClsTestTypes.enTestType.WrittenTest:
                    {
                        Type = ClsTestTypes.enTestType.WrittenTest;
                        lblTitle.Text = "Written Test";
                        pbTestTypeImage.Image = Resources.Written_Test_512; break;
                    }
                case ClsTestTypes.enTestType.StreetTest:
                    {
                        Type = ClsTestTypes.enTestType.StreetTest;
                        lblTitle.Text = "Street Test";
                        pbTestTypeImage.Image=Resources.driving_test_512; break;
                    }
            }

            lblTrial.Text = _LocalLicense.GetTrialTest(Convert.ToInt32(TestType)).ToString();
        }

        private void _CheckMode()
        {
            _AddingStatus.Tag = "Test Saved Successfully";

            if (Mode == EnMode.AddMode)
            {

                _Appointment = new ClsTestAppointment();
                return;
            }

            _Appointment = ClsTestAppointment.Find(_AppointMentID);

            if (_Appointment == null)
            {
                MessageBox.Show("Appointment is not found , try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lblLocalDrivingLicenseAppID.Text = _Appointment.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalLicense.LicenseClassInfo.ClassName;
            lblFullName.Text = _LocalLicense.FullName;
            lblTrial.Text = _LocalLicense.GetTrialTest((int)TestType).ToString();
            dtpTestDate.Value = _Appointment.AppointmentDate;
            lblFees.Text = _Appointment.PaidFees.ToString();

            gbRetakeTestInfo.Enabled = true;
            _HandleAppointmentLockedConstraint();
        }

        private void SetUserMessage(string message, bool disableControls = true)
        {
            lblUserMessage.Visible = true;
            lblUserMessage.Text = message;
            dtpTestDate.Enabled = !disableControls;
            btnSave.Enabled = !disableControls;
        }


        private void _HandleAppointmentLockedConstraint()
        {
            if (_Appointment.IsLocked)
            {
                SetUserMessage("Person already sat for the test, appointment loacked.");      
            }
        }

        public void LoadData(int LocalDrivingLicenseID, int AppointMentID)
        {
            if (AppointMentID == -1)
                Mode = EnMode.AddMode;
            else
                Mode = EnMode.UpdateMode;

            _LocalLicense = ClsLocalLicense.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseID);
            _AppointMentID = AppointMentID;

            if (_LocalLicense == null)
            {
                MessageBox.Show("Local Driving License Not Found, try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillData();
        }

        private void _LoadDataRetake()
        {

            if((Mode==EnMode.UpdateMode && _Appointment.RetakeTestApplicationID==-1) ||(Mode==EnMode.AddMode  && CreationMode==enCreationMode.FirstTimeSchedule) )
            {
                gbRetakeTestInfo.Enabled = false;
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }

            else if (CreationMode == enCreationMode.RetakeTestSchedule)
            {
                lblRetakeAppFees.Text = ClsApplicationTypes.Find((int)ClsApplication.enApplicationType.RetakeTest).Fees.ToString();
                gbRetakeTestInfo.Enabled = true;
                lblRetakeTestAppID.Text = _LocalLicense.ApplicationID.ToString();
                lblTotalFees.Text = (Convert.ToSingle(lblRetakeAppFees.Text) + Convert.ToSingle(lblFees.Text)).ToString();
            }
              
        }

        private void _FillData()
        {
            _LocalDrivingLicenseID = _LocalLicense.LocalDrivingLicenseID;

            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseID.ToString();

            lblDrivingClass.Text = _LocalLicense.LicenseClassInfo?.ClassName ?? "Unknown";

            lblFullName.Text = _LocalLicense.FullName;

            dtpTestDate.Value = DateTime.Now;

           lblTotalFees.Text  = lblFees.Text = ClsTestTypes.Find(TestType).Fees.ToString();

            _CheckTest();

            if (_LocalLicense.DoesAttendTestType(TestType))
            {
                CreationMode = enCreationMode.RetakeTestSchedule;
            }
            else
            {
                CreationMode = enCreationMode.FirstTimeSchedule;
            }

            _CheckMode();

            _LoadDataRetake();
           
        }

        private void _SetAppointmentData()
        {
            _Appointment.TestTypeID = Type;
            _Appointment.AppointmentDate = dtpTestDate.Value;
            _Appointment.LocalDrivingLicenseApplicationID = _LocalLicense.LocalDrivingLicenseID;
            _Appointment.PaidFees = int.Parse(lblFees.Text);
            _Appointment.CreatedByUserID = _LocalLicense.UserID;
            _Appointment.IsLocked = false;

            if (CreationMode == enCreationMode.RetakeTestSchedule)
            {
                _Appointment.RetakeTestApplicationID = _LocalLicense.ApplicationID;
            }
        }


            private void btnSave_Click(object sender, EventArgs e)
        {
            _SetAppointmentData();

            if(_Appointment.Save())
            {
                _AddingStatus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
