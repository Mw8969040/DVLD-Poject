using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }


        public  ClsCountry() 
        {
            CountryID = -1;
            CountryName = "";
        }

        private ClsCountry(int CountryID , string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static ClsCountry FindCountry(int CountryID)
        {
            string CountryName = "";

            if (ClsDataCountry.FindCountryByID(CountryID, ref CountryName))
            {
                return new ClsCountry(CountryID,CountryName);
            }
            return null;
        }
        public static ClsCountry FindCountry(string CountryName)
        {
            int  CountryID = -1;

            if (ClsDataCountry.FindCountryByName(ref CountryID,CountryName))
            {
                return new ClsCountry(CountryID,CountryName);
            }
            return null;
        }

       public static DataTable ListCountries()
       {
           return ClsDataCountry.ListCountries();
       }
    }
}
