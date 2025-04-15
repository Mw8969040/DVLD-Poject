using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataDLVDLayer
{
    public class ClsDataLocalLicense
    {
        public static DataTable ListLocalLicense()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = @"SELECT * FROM LocalDrivingLicenseApplications_View;";

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

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(
        int ApplicationID, ref int LocalDrivingLicenseApplicationID,
        ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetLocalDrivingLicenseApplicationInfoByID(
           int LocalDrivingLicenseApplicationID, ref int ApplicationID,
           ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);


            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];



                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
            
        public static int AddNewLocalDrivingLicense(int ApplicationID , int LicenseClassID)
        {
           SqlConnection connection =new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = "insert into LocalDrivingLicenseApplications values (@ApplicationID , @LicenseClassID) ; SELECT SCOPE_IDENTITY() ;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID",LicenseClassID);

            try
            {
                connection.Open();

                object RowEffected = Command.ExecuteScalar();

                connection.Close();

                if(RowEffected!=null && int.TryParse(RowEffected.ToString(),out int Result))
                {
                    return Result;
                }
            }
            catch (Exception ex)
            {
                // Handle As You Like ;
            }

            return -1;
        }

        public static bool UpdatedLocalDrivingLicense(int LocalDrivingLicenseID ,int ApplicationID , int LicenseClassID)
        {
            int RowEffected = 0;
            SqlConnection Connection =new SqlConnection (ClsDataAccess.ConnectionString);

            string Query = @"Update LocalDrivingLicenseApplications Set ApplicationID = @ApplicationID , LicenseClassID = @LicenseClassID where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID";

            SqlCommand Commands=new SqlCommand(Query, Connection);

            Commands.Parameters.AddWithValue("@ApplicationID",ApplicationID);
            Commands.Parameters.AddWithValue("@LicenseClassID",LicenseClassID);
            Commands.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);

            try
            {
                Connection.Open();

                RowEffected = Commands.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                return false;
                // Handle As You Like ;
            }

            return RowEffected > 0;
        }

        public static bool DeleteLocalDrivingLicense(int LocalDrivingLicenseID)
        {
            bool isDeleted = false;
            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        isDeleted = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                     // Handle As You Like ;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return isDeleted;
        }

        public static int GetTrialTest(int LocalDrivingLicenseID , int TestType)
        {
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = @"SELECT Count(*)
                                     FROM Tests
                                     INNER JOIN TestAppointments 
                                         ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                     WHERE TestAppointments.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseID
                                     AND TestAppointments.TestTypeID = @TestType;
                                     ";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseiD", LocalDrivingLicenseID);
            Command.Parameters.AddWithValue("@TestType", TestType);

            try
            {
                connection.Open();

                object RowEffected = Command.ExecuteScalar();

                connection.Close();

                if (RowEffected != null && int.TryParse(RowEffected.ToString(), out int Result))
                {
                    return Result;
                }
            }
            catch (Exception ex)
            {
                // Handle As You Like ;
            }

            return 0;
        }

        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool Attend = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"    SELECT 1  AS DoesExist
                                           FROM LocalDrivingLicenseApplications
                                           INNER JOIN TestAppointments 
                                           ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                                           WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestTypeID
                                          ; ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    Attend = true;
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

            return Attend;

        }

        public static bool IsActive(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsActive = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"Select IsActive =1 from 
                                    LocalDrivingLicenseApplications 
                                    inner join TestAppointments 
                                    on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                                    Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestTypeID and TestAppointments.IsLocked=0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsActive = true;
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

            return IsActive;

        }

        public static bool IsPassed(int LocalDrivingLicenseApplicationID , int TestTypeID)
        {
            bool Passed = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"    SELECT 1     AS IsPassed       FROM LocalDrivingLicenseApplications   INNER JOIN TestAppointments
                            ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID inner join
                            Tests on Tests.TestAppointmentID=TestAppointments.TestAppointmentID 
                            WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestTypeID and Tests.TestResult=1 ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    Passed = true;
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

            return Passed;

        }

        public static int  GetLicenseActive(int ApplicationID, int LicenseClass)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string Query = @"Select LicenseID from Licenses
                              where ApplicationID=@ApplicationID and LicenseClass=@LicenseClass";

            using (SqlCommand Command = new SqlCommand(Query, connection))
            {

                Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);


                try
                {
                    connection.Open();

                    object result = Command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString() ,out int Result))
                    {
                        LicenseID = Result;
                    }
                }
                catch (Exception ex)
                {
                    // Handle As You Like ;
                }

            }

            return LicenseID;

        }
    }
}
