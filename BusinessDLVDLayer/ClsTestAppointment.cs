using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { set; get; }
        public ClsTestTypes.enTestType TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public ClsApplication RetakeTestAppInfo { set; get; }

        public int TestID
        {
            get { return GetTestID(); }
        }


        public ClsTestAppointment()

        {
            this.TestAppointmentID = -1;
            this.TestTypeID = ClsTestTypes.enTestType.VisionTest;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;

        }

        public ClsTestAppointment(int TestAppointmentID, ClsTestTypes.enTestType TestTypeID,
           int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
           int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)

        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestAppInfo = ClsApplication.FindBase(RetakeTestApplicationID);
            Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
           
            this.TestAppointmentID = ClsDataTestAppointment.AddNewTestAppointment((int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return ClsDataTestAppointment.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        public static ClsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = 1; int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (ClsDataTestAppointment.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
            ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new ClsTestAppointment(TestAppointmentID, (ClsTestTypes.enTestType)TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }

        public static DataTable AppointmentTest(int LocalLicenseID , ClsTestTypes.enTestType TestType)
        {
           return ClsDataTestAppointment.AppointmentTest(LocalLicenseID,(int)TestType);
        }

        public static int LastTestID (int LocalaLicenseID , ClsTestTypes.enTestType TestType)
        {
            return ClsDataTestAppointment.LastTest(LocalaLicenseID,(int)TestType);
        }

        public int GetTestID()
        {
            return ClsDataTestAppointment.GetTestID(this.TestAppointmentID); 
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    Mode = enMode.Update;
                    return _AddNewTestAppointment();
                case enMode.Update:
                    return _UpdateTestAppointment();
            }
            return false;
        }
    }
}
