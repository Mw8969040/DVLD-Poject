using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsDrivers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

       public  ClsPeople PersonInfo =new ClsPeople();
        public int DriverID { get; set; }
       public int PersonID { get; set; }
       public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public ClsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            UserID = -1;
            CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private ClsDrivers(int driverID, int personID, int userID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            UserID = userID;
            CreatedDate = createdDate;
            this.PersonInfo =ClsPeople.Find(personID);
            Mode = enMode.Update;
        }

        public static ClsDrivers FindByDriverID(int DriverID)
        {

            int PersonID = -1; int CreatedByUserID = -1; DateTime CreatedDate = DateTime.Now;

            if (ClsDataDrivers.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))

                return new ClsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }

        public static ClsDrivers FindByPersonID(int PersonID)
        {

            int DriverID = -1; int CreatedByUserID = -1; DateTime CreatedDate = DateTime.Now;

            if (ClsDataDrivers.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))

                return new ClsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }
        public static DataTable ListDrivers()
        {
            return ClsDataDrivers.AllDrivers();
        }

        private bool _AddNewDriver()
        {
            //call DataAccess Layer 

            this.DriverID = ClsDataDrivers.AddNewDriver(PersonID, UserID);


            return (this.DriverID != -1);
        }

        private bool _UpdateDriver()
        {
            //call DataAccess Layer 

            return ClsDataDrivers.UpdateDriver(this.DriverID, this.PersonID, this.UserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDriver();

            }

            return false;
        }


    }
}
