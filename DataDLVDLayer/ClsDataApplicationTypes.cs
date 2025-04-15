using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLVDLayer
{
    public class ClsDataApplicationTypes
    {
        public static DataTable ListAppTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection =new SqlConnection(ClsDataAccess.ConnectionString);

            string Query = @"Select * From ApplicationTypes";

            SqlCommand Command=new SqlCommand(Query, Connection);

            Connection.Open();

            try
            {
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                //Handle As You Like;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool UpdateAppTypes(int ID, string Title, float Fees)
        {
            int RowEffected = 0;
            string Query = @"UPDATE ApplicationTypes SET ApplicationTypeTitle=@Title , ApplicationFees=@Fees  WHERE ApplicationTypeID=@ID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@Fees", Fees);
                 
                    try
                    {
                        connection.Open();
                        RowEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return (RowEffected > 0);
        }

        public static bool FindAppByID(int ID, ref string Title ,ref float Fees)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"SELECT * FROM ApplicationTypes Where ApplicationTypeID=@ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // تحقق من وجود الصف
                {
                    isFound = true;
                    Title = reader["ApplicationTypeTitle"].ToString();
                    Fees = Convert.ToSingle(reader["ApplicationFees"]);
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

    }
}
