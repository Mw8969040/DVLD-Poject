using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsLicenseClass
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefultLengthValidity { get; set;}
        public float Fees { get; set;}


        public ClsLicenseClass()
        {
            ID = 0;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 0;
            DefultLengthValidity = 0;
            Fees = 0;
        }

        private  ClsLicenseClass(int iD, string className, string classDescription, int minimumAllowedAge, int defultLengthValidity, float fees)
        {
            ID = iD;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefultLengthValidity = defultLengthValidity;
            Fees = fees;
        }

        public static ClsLicenseClass Find(int ID)
        {
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge=18 , DefultLengthValidity = 10 ;
            float Fees = 0 ;

            if(ClsDataLicenseClass.GetLicenseClassInfoByID(ID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge,ref DefultLengthValidity,ref Fees))
            {
                return new ClsLicenseClass(ID,ClassName,ClassDescription,MinimumAllowedAge,DefultLengthValidity,Fees);
            }
            return null;
        }

        public static ClsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;

            if (ClsDataLicenseClass.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

            

        }

        public static DataTable ListLicenseClass()
        {
            return ClsDataLicenseClass.GetAllLicenseClasses();
        }


    }
}
