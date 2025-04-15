using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static BusinessDLVDLayer.ClsApplication;

namespace BusinessDLVDLayer
{
    public class ClsApplication
    {
        public enum EnMode { AddMode=0 , UpdateMode=1};
       
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public EnMode Mode = EnMode.AddMode;
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public string FullName { get { return ClsPeople.Find(ApplicationPersonID).FullName; } }
        public enApplicationStatus ApplicationStatus {  get; set; }
        public DateTime LastStatusDate { get; set; }
        public float ApplicationFees { get; set; }
        public int UserID { get; set; }
        public ClsApplicationTypes ApplicationTypeInfo;
        public ClsUsers UserInfo { get; set; }



        public ClsLicenseClass LicenseClassInfo;
        public string StatusText
        {
            get
            {

                switch (this.ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }

        public ClsApplication()
        {
            ApplicationID = 0;
            ApplicationPersonID = 0;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            ApplicationFees = 0;
            UserID = 0;
            ApplicationTypeID = 0;
            ApplicationDate = DateTime.Now;
            Mode=EnMode.AddMode;
        }


        public ClsApplication(int applicationID, int applicationPersonID, DateTime applicationDate, int applicationTypeID, enApplicationStatus applicationStatus, DateTime lastStatusDate, float applicationFees, int userID)
        {
            ApplicationID = applicationID;
            ApplicationPersonID = applicationPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeInfo = ClsApplicationTypes.Find(ApplicationTypeID);
            this.UserInfo = ClsUsers.Find(userID);
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            ApplicationFees = applicationFees;
            UserID = userID;
            Mode = EnMode.UpdateMode;
        }

        public static ClsApplication FindBase(int ApplicationID)
        {
            int ApplicationPersonID = 0, ApplicationTypeID = 0, UserID = 0;
            byte ApplicationStatus = 1;
            float ApplicationFees = 0;
            DateTime ApplicationDate = DateTime.Now;  
            DateTime LastStatusDate = DateTime.Now;

            if (ClsDataApplication.GetApplicationInfoByID(ApplicationID,ref ApplicationPersonID,ref ApplicationDate,ref ApplicationTypeID,ref ApplicationStatus,ref LastStatusDate,ref ApplicationFees,ref UserID))
            {
                return new ClsApplication(ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID,(enApplicationStatus) ApplicationStatus, LastStatusDate, ApplicationFees, UserID);
            }

            return null;
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return ClsDataApplication.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }

        private bool _AddApplication()
        {
            this.ApplicationID = ClsDataApplication.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.ApplicationFees, this.UserID);
            return this.ApplicationID !=-1;
        }

        private bool _UpdateApplication()
        {
            return ClsDataApplication.UpdateApplication(this.ApplicationID, this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.ApplicationFees, this.UserID);
        }

        public  bool DeleteApplication()
        {
            return ClsDataApplication.DeleteApplication(this.ApplicationID);
        }

        public bool SetComplete()
        {
            return ClsDataApplication.UpdateStatus(ApplicationID, 3);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case EnMode.AddMode:
                    if(_AddApplication())
                    {
                        Mode = EnMode.UpdateMode;
                        return true;                  
                    }
                    break;
                case EnMode.UpdateMode:
                    return _UpdateApplication();
                   
            }
            return false;
        }
    }

}
