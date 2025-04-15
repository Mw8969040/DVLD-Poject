using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLVDLayer
{
    public class ClsDataInternationalLicense
    {
        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"
            SELECT    InternationalLicenseID, ApplicationID,
		                IssuedUsingLocalLicenseID , IssueDate, 
                        ExpirationDate, IsActive
		    from InternationalLicenses where DriverID=@DriverID
                order by ExpirationDate desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        
        public static bool FindInternationallicenseByID(int InternationalLicenseID ,ref int ApplicationID ,ref int DriverID ,ref int IssuedUsingLocalLicenseID , ref DateTime IssueDate ,ref DateTime ExpirationDate ,ref  bool IsActive ,ref int CreatedByUserID)
        {
            bool IsFound=false;

            SqlConnection Connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = "Select * From InternationalLicenses where InternationalLicenseID = @InternationalLicenseID";
            using (SqlCommand command = new SqlCommand(Query, Connection))
            {
                command.Parameters.AddWithValue("InternationalLicenseID", @InternationalLicenseID);
                Connection.Open();

                try
                {


                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        IsFound = true;
                        InternationalLicenseID = int.Parse(reader["InternationalLicenseID"].ToString());
                        ApplicationID = int.Parse(reader["ApplicationID"].ToString());
                        DriverID = int.Parse(reader["DriverID"].ToString());
                        IssuedUsingLocalLicenseID = int.Parse(reader["IssuedUsingLocalLicenseID"].ToString());
                        IssueDate = DateTime.Parse( reader["IssueDate"].ToString());
                        ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());
                        IsActive = (bool)reader["IsActive"];
                        CreatedByUserID = int.Parse(reader["CreatedByUserID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    IsFound = false;
                }
            }

            return IsFound;
        }

        public static int AddInternationalLicense(int ApplicationID, int DriverID, int IssueUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int LastId = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"
               INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                   VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID) ;   SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssueUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
            // if Adding Process Done Successfully Select SCOPE_IDENTITY() Show Last ID ;
            try
            {
                connection.Open();
                object LastID = command.ExecuteScalar();
                if(LastID != null && int.TryParse(LastID.ToString() , out int ID))
                {
                    LastId = ID;
                }

            }
            catch (Exception ex)
            {
                // You can log the error here if needed
                LastId = -1;
            }
            finally
            {
                connection.Close();
            }

            return LastId;
        }

        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssueUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int ModifiedByUserID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"
              UPDATE InternationalLicenses
              SET ApplicationID = @ApplicationID, DriverID = @DriverID, 
                  IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID, IssueDate = @IssueDate, 
                  ExpirationDate = @ExpirationDate, IsActive = @IsActive, ModifiedByUserID = @ModifiedByUserID
              WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssueUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);
            command.Parameters.AddWithValue("@ModifiedByUserID", ModifiedByUserID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // You can log the error here if needed
                isSuccess = false;
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // You can log the error here if needed
                isSuccess = false;
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }
   
        public static DataTable ListInternationalLicense()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string Query = @"Select  InternationalLicenseID , ApplicationID , DriverID , IssuedUsingLocalLicenseID , IssueDate , ExpirationDate , IsActive from InternationalLicenses
";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Connection.Open();

            try
            {
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
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

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"  
                            SELECT Top 1 InternationalLicenseID
                            FROM InternationalLicenses 
                            where DriverID=@DriverID and GetDate() between IssueDate and ExpirationDate 
                            order by ExpirationDate Desc;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InternationalLicenseID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return InternationalLicenseID;
        }

        public static int DoesHaveInternationalLicenseBefore(int DriverID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"
                    SELECT TOP 1 InternationalLicenseID
                    FROM InternationalLicenses
                    WHERE DriverID = @DriverID
                    ORDER BY ExpirationDate DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Int_LicenseID))
                {
                    InternationalLicenseID = Int_LicenseID;
                }
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return InternationalLicenseID;
        }

        public static void DeactivateInternationalLicense(int InternationalLicenseID)
        {
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string updateQuery = @"
             UPDATE InternationalLicenses
             SET IsActive = 0
             WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
