using BusinessDLVDLayer;
using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class ClsInternationalLicense : ClsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public ClsDrivers DriverInfo;
        public int InternationalLicenseID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public ClsInternationalLicense()
        {
            // تحديد نوع التطبيق هنا كترخيص دولي جديد
            this.ApplicationTypeID = (int)ClsApplication.enApplicationType.NewInternationalLicense;

            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = true;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        public ClsInternationalLicense(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            enApplicationStatus ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID,
            int InternationalLicenseID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive)
        {
            // التعامل مع الطبقة الأساسية
            base.ApplicationID = ApplicationID;
            base.ApplicationPersonID = ApplicantPersonID;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationTypeID = (int)ClsApplication.enApplicationType.NewInternationalLicense;
            base.ApplicationStatus = ApplicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.ApplicationFees = PaidFees;
            base.UserID = CreatedByUserID;

            // إعداد المتغيرات الخاصة بالترخيص الدولي
            this.InternationalLicenseID = InternationalLicenseID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            this.DriverInfo = ClsDrivers.FindByDriverID(this.DriverID);

            Mode = enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            // استدعاء طبقة الوصول إلى البيانات
            this.InternationalLicenseID = ClsDataInternationalLicense.AddInternationalLicense(
                this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,
                this.IsActive, this.CreatedByUserID
            );

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            // استدعاء طبقة الوصول إلى البيانات
            return ClsDataInternationalLicense.UpdateInternationalLicense(
                this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID
            );
        }

        public static ClsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = 1;

            if (ClsDataInternationalLicense.FindInternationallicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID,
                ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                // العثور على التطبيق الأساسي
                ClsApplication Application = ClsApplication.FindBase(ApplicationID);

                return new ClsInternationalLicense(
                    Application.ApplicationID,
                    Application.ApplicationPersonID,
                    Application.ApplicationDate,
                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                    Application.ApplicationFees, Application.UserID,
                    InternationalLicenseID, DriverID, IssuedUsingLocalLicenseID,
                    IssueDate, ExpirationDate, IsActive
                );
            }
            else
                return null;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return ClsDataInternationalLicense.ListInternationalLicense();
        }

        public bool Save()
        {
            // لأننا نرث من الطبقة الأساسية، أولاً نقوم باستدعاء دالة الحفظ في الطبقة الأساسية
            base.Mode = (ClsApplication.EnMode)Mode;
            if (!base.Save())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateInternationalLicense();
            }

            return false;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
             return ClsDataInternationalLicense.GetActiveInternationalLicenseIDByDriverID(DriverID);
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return ClsDataInternationalLicense.GetDriverInternationalLicenses(DriverID);
        }

        public static int DoesHaveInternationalLicenseBefore(int DriverID)
        {
            return ClsDataInternationalLicense.DoesHaveInternationalLicenseBefore(DriverID);
        }

        public static void DeactivateInternationalLicense(int InternationalLicenseID)
        {
            ClsDataInternationalLicense.DeactivateInternationalLicense(InternationalLicenseID);
        }
    }
}
