using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataDLVDLayer
{
    public class ClsDataCountry
    {
        public static bool FindCountryByID(int CountryID, ref string CountryName)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"SELECT * FROM Countries Where CountryID=@CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // تحقق من وجود الصف
                {
                    isFound = true;
                    CountryName = reader["CountryName"].ToString();
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

         public static bool FindCountryByName(ref int  CountryID ,string CountryName)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"SELECT * FROM Countries Where CountryName=@CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // تحقق من وجود الصف
                {
                    isFound = true;
                    CountryID =int.Parse( reader["CountryID"].ToString());
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable ListCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = @"SELECT * FROM Countries;";

            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (optional)
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


    }
}

