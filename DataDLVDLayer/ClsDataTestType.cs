using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLVDLayer
{
    public class ClsDataTestType
    {
        public static DataTable ListTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string Query = @"Select * From TestTypes";

            SqlCommand Command = new SqlCommand(Query, Connection);

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

        public static bool UpdateTestTypes(int ID, string Title,string Description , float Fees)
        {
            int RowEffected = 0;
            string Query = @"UPDATE TestTypes SET TestTypeTitle=@Title ,TestTypeDescription=@Description , TestTypeFees=@Fees  WHERE TestTypeID=@ID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@Fees", Fees);
                    command.Parameters.AddWithValue("@Description", Description);
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

        public static bool FindTestByID(int ID, ref string Title,ref string Description, ref float Fees)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"SELECT * FROM TestTypes Where TestTypeID=@ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // تحقق من وجود الصف
                {
                    isFound = true;
                    Title = reader["TestTypeTitle"].ToString();
                    Description = reader["TestTypeDescription"].ToString();
                    Fees = Convert.ToInt32(reader["TestTypeFees"]);
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
