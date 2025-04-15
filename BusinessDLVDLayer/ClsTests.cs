using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsTests
    {
        enum EnMode { AddNew =0 , Update=1 }
        EnMode Mode;

     
       public int TestID { get; set; }
       public int TestAppointmentID { get; set; }
       public bool TestResult { get; set; }
       public string Notes { get; set; }
       public int CreatedByUserID { get; set; }

        public ClsTests()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = -1;
            Mode = EnMode.AddNew;

        }

        private ClsTests(int TestID, int TestAppointmentID, bool TestResult, string Notes , int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            Mode= EnMode.Update;
        }

        private bool _AddNewTest()
        {
            //call DataAccess Layer 

            this.TestID = ClsDataTests.AddNewTest(this.TestAppointmentID,
                this.TestResult, this.Notes, this.CreatedByUserID);


            return (this.TestID != -1);
        }

        private bool _UpdateTest()
        {
            //call DataAccess Layer 

            return ClsDataTests.UpdateTest(this.TestID, this.TestAppointmentID,
                this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public static ClsTests Find(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

            if (ClsDataTests.GetTestInfoByID(TestID,
            ref TestAppointmentID, ref TestResult,
            ref Notes, ref CreatedByUserID))

                return new ClsTests(TestID,
                        TestAppointmentID, TestResult,
                        Notes, CreatedByUserID);
            else
                return null;

        }

        public static ClsTests FindByTestAppointment(int TestAppointmentID)
        {
            int TestID = -1;
            bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

            if (ClsDataTests.GetTestInfoByAppointmentID(ref TestID,
             TestAppointmentID, ref TestResult,
            ref Notes, ref CreatedByUserID))

                return new ClsTests(TestID,
                        TestAppointmentID, TestResult,
                        Notes, CreatedByUserID);
            else
                return null;

        }


        public static DataTable GetAllTests()
        {
            return ClsDataTests.GetAllTests();

        }

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (_AddNewTest())
                    {

                        Mode = EnMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case EnMode.Update:

                    return _UpdateTest();

            }

            return false;
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return ClsDataTests.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

       
    }
}
