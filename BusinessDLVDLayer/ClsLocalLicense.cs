using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsLocalLicense :ClsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseID {  get; set; }
        public int LicenseClassID { get; set; }

        //public ClsLicenseClass LicenseClass;

        public string FullName
        {
            get { return ClsPeople.Find(ApplicationPersonID).FullName; }
        }

        public ClsLocalLicense()
        {
           
            LocalDrivingLicenseID = -1;
            LicenseClassID = -1;
            Mode=enMode.AddNew;
        }

        private ClsLocalLicense(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID, int LicenseClassID)

        {
            this.LocalDrivingLicenseID = LocalDrivingLicenseApplicationID; ;
            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int)ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.ApplicationFees = PaidFees;
            this.UserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = ClsLicenseClass.Find(LicenseClassID);
            Mode = enMode.Update;
        }

        public static ClsLocalLicense FindByApplicationID(int ApplicationID)
        {
            // 
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            bool IsFound = ClsDataLocalLicense.GetLocalDrivingLicenseApplicationInfoByApplicationID
                (ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application
                ClsApplication Application = ClsApplication.FindBase(ApplicationID);

                //we return new object of that person with the right data
                return new ClsLocalLicense(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicationPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.ApplicationFees, Application.UserID, LicenseClassID);
            }
            else
                return null;


        }
        
        public static ClsLocalLicense FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
        {
            
            int ApplicationID = -1, LicenseClassID = -1;

            bool IsFound = ClsDataLocalLicense.GetLocalDrivingLicenseApplicationInfoByID
                (LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);

            
            if (IsFound)
            {
                //now we find the base application
                ClsApplication Application = ClsApplication.FindBase(ApplicationID);

                //we return new object of that person with the right data
                return new ClsLocalLicense(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicationPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.ApplicationFees, Application.UserID, LicenseClassID);
            }
            else
                return null;
            
            
        }


        private bool _AddNewLicense()
        {
            this.LocalDrivingLicenseID = ClsDataLocalLicense.AddNewLocalDrivingLicense(this.ApplicationID, this.LicenseClassID);
            return this.LocalDrivingLicenseID != -1;
        }

        private bool _UpdateLicense()
        {
            return ClsDataLocalLicense.UpdatedLocalDrivingLicense(this.LocalDrivingLicenseID, this.ApplicationID, this.LicenseClassID);
        }

        public  bool DeleteLocalLicense()
        {
            if (!ClsDataLocalLicense.DeleteLocalDrivingLicense(this.LocalDrivingLicenseID))
                return false;

            return base.DeleteApplication();
        }

        public bool Cancel()
        {
           return ClsDataApplication.UpdateStatus(this.ApplicationID, 2);
        }

        public static DataTable ListLocalLicense()
        {
            return ClsDataLocalLicense.ListLocalLicense();
        }

        public  int GetTrialTest(int TestType)
        {
            return ClsDataLocalLicense.GetTrialTest(this.LocalDrivingLicenseID , TestType);
        }

        public bool DoesAttendTestType(ClsTestTypes.enTestType TestTypeID)

        {
            return ClsDataLocalLicense.DoesAttendTestType(this.LocalDrivingLicenseID, (int)TestTypeID);
        }

        public bool IsActive(ClsTestTypes.enTestType TestType)
        {
          return  ClsDataLocalLicense.IsActive(this.LocalDrivingLicenseID, (int)TestType);
        }
        public bool IsPassed(ClsTestTypes.enTestType TestTypeID)
        {
            return ClsDataLocalLicense.IsPassed(this.LocalDrivingLicenseID,(int)TestTypeID);
        }

        public  bool IsPassedAllTest()
        {
            return ClsTests.GetPassedTestCount(this.LocalDrivingLicenseID)==3;
        }

        public bool Save()
        {
            if(!base.Save()) return false;

            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateLicense();
            }
            return false;
        }

        public int GetLicenseActive()
        {
            return ClsDataLocalLicense.GetLicenseActive(this.ApplicationID, this.LicenseClassID);
        }

        public int IssueLicenseForFirstTime(string Notes, int UserID)
        {
            int DriverID = -1;

            ClsDrivers Driver = ClsDrivers.FindByPersonID(this.ApplicationPersonID);

            if (Driver == null)
            {
                Driver = new ClsDrivers();
                Driver.PersonID = this.ApplicationPersonID;
                Driver.UserID = UserID;

                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = Driver.DriverID;
            }

            // Create new License
            ClsLicense License = new ClsLicense();
            License.ApplicationID = this.ApplicationID;
            License.DriverID = DriverID;
            License.LicenseClassID = this.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefultLengthValidity);
            License.Notes = Notes;
            License.PaidFees = this.LicenseClassInfo.Fees;
            License.IsActive = true;
            License.IssueReason = ClsLicense.enIssueReason.FirstTime;
            License.CreatedByUserID = UserID;

            if (License.Save())
            {
                this.SetComplete();
                return License.LicenseID;
            }
            else
            {
                return -1;
            }
        }

    }
}
