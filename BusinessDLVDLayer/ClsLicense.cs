using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsLicense
    {

        enum EnMode { AddMode =0 , UpdateMode = 1 };
        EnMode Mode = EnMode.AddMode;
        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public ClsDrivers DriverInfo;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int   LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public string IssueReasonText
        {
            get
            {
                return GetTextIssueReason(IssueReason);
            }
        }

        public ClsLicenseClass LicenseClassInfo { get; set; }
        public  ClsLicense ()
        {
           this. LicenseID = -1;
           this. ApplicationID = -1;
           this. DriverID = -1;
           this. LicenseClassID = -1;
           this. IssueDate = DateTime.Now;
           this. ExpirationDate = DateTime.Now;
           this. Notes = string.Empty;
           this. PaidFees = 0;
           this. IsActive = false;
           this.LicenseClassInfo = new ClsLicenseClass();
           this. IssueReason = enIssueReason.FirstTime;
           this. CreatedByUserID = -1;

            Mode = EnMode.AddMode;
        }

        private ClsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID,
           DateTime IssueDate, DateTime ExpirationDate, string Notes,
           float PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)

        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            this.DriverInfo = ClsDrivers.FindByDriverID(this.DriverID);
            this.LicenseClassInfo = ClsLicenseClass.Find(this.LicenseClassID);

            Mode = EnMode.UpdateMode;
        }

        private bool _AddNewLicense()
        {
            //call DataAccess Layer 

            this.LicenseID = ClsDataLicense.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID,
               this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
               this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);


            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            //call DataAccess Layer 

            return ClsDataLicense.UpdateLicense(this.ApplicationID, this.LicenseID, this.DriverID, this.LicenseClassID,
               this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
               this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }

        public static ClsLicense Find(int LicenseID)
        {
            int ApplicationID = -1; int DriverID = -1; int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = 0; bool IsActive = true; int CreatedByUserID = 1;
            byte IssueReason = 1;
            if (ClsDataLicense.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass,
            ref IssueDate, ref ExpirationDate, ref Notes,
            ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new ClsLicense(LicenseID, ApplicationID, DriverID, LicenseClass,
                                     IssueDate, ExpirationDate, Notes,
                                     PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddMode:
                    if (_AddNewLicense())
                    {

                        Mode = EnMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case EnMode.UpdateMode:

                    return _UpdateLicense();

            }

            return false;
        }

        //public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
        //{
        //    return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        //}

        public static DataTable ListLicneseByDriverID(int DriverID)
        {
            return ClsDataLicense.ListLicenseByDriverID(DriverID);
        }

        private string GetTextIssueReason(enIssueReason IssueReason)
        {
            switch(IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.LostReplacement:
                    return "Replacement For Lost";
                case enIssueReason.DamagedReplacement:
                    return "Replacement For Damaged";
                default:
                    return "First Time";
            }
        }
    }
}
