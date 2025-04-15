using System;
using System.Data;
using BusinessDLVDLayer;
using DataDLVDLayer;

namespace BusinessDLVDLayer
{
    public class ClsDetainLicense
    {
        public enum Enmode { AddMode = 0, UpdateMode = 1 };
        public Enmode Mode = Enmode.AddMode;

        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public float FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public ClsUsers CreatedByUserInfo { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleasedDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public ClsUsers ReleasedByUserInfo { set; get; }
        public int ReleasedApplicationID { set; get; }

        public ClsDetainLicense()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleasedDate = DateTime.MaxValue;
            ReleasedByUserID = -1;
            ReleasedApplicationID = -1;

            Mode = Enmode.AddMode;
        }

        public ClsDetainLicense(int detainID, int licenseID, DateTime detainDate,
            float fineFees, int createdByUserID, bool isReleased,
            DateTime releasedDate, int releasedByUserID, int releasedApplicationID)
        {
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleasedDate = releasedDate;
            ReleasedByUserID = releasedByUserID;
            ReleasedApplicationID = releasedApplicationID;

            CreatedByUserInfo = ClsUsers.Find(CreatedByUserID);
            ReleasedByUserInfo = ClsUsers.Find(ReleasedByUserID);

            Mode = Enmode.UpdateMode;
        }

        private bool _AddNewDetainedLicense()
        {
            DetainID = ClsDataDetainLicense.AddNewDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID);
            return (DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            return ClsDataDetainLicense.UpdateDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Enmode.AddMode:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = Enmode.UpdateMode;
                        return true;
                    }
                    return false;

                case Enmode.UpdateMode:
                    return _UpdateDetainedLicense();
            }
            return false;
        }

        public static ClsDetainLicense Find(int detainID)
        {
            int licenseID = -1;
            DateTime detainDate = DateTime.Now;
            float fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releasedDate = DateTime.MaxValue;
            int releasedByUserID = -1;
            int releasedApplicationID = -1;

            if (ClsDataDetainLicense.GetDetainedLicenseInfoByID(detainID,
                ref licenseID, ref detainDate, ref fineFees,
                ref createdByUserID, ref isReleased,
                ref releasedDate, ref releasedByUserID, ref releasedApplicationID))
            {
                return new ClsDetainLicense(detainID, licenseID, detainDate, fineFees,
                    createdByUserID, isReleased, releasedDate, releasedByUserID, releasedApplicationID);
            }

            return null;
        }

        public static ClsDetainLicense FindByLicenseID(int licenseID)
        {
            int detainID = -1;
            DateTime detainDate = DateTime.Now;
            float fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releasedDate = DateTime.MaxValue;
            int releasedByUserID = -1;
            int releasedApplicationID = -1;

            if (ClsDataDetainLicense.GetDetainedLicenseInfoByLicenseID(licenseID,
                ref detainID, ref detainDate, ref fineFees, ref createdByUserID,
                ref isReleased, ref releasedDate, ref releasedByUserID, ref releasedApplicationID))
            {
                return new ClsDetainLicense(detainID, licenseID, detainDate, fineFees,
                    createdByUserID, isReleased, releasedDate, releasedByUserID, releasedApplicationID);
            }

            return null;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return ClsDataDetainLicense.GetAllDetainedLicenses();
        }

        public static bool IsLicenseDetained(int licenseID)
        {
            return ClsDataDetainLicense.IsLicenseDetained(licenseID);
        }

        public bool ReleaseDetainedLicense(int releasedByUserID, int releasedApplicationID)
        {
            return ClsDataDetainLicense.ReleaseDetainedLicense(DetainID, releasedByUserID, releasedApplicationID);
        }
    }
}
