using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DataDLVDLayer
{
    public class ClsDataTests
    {
        private static string _connectionString = ClsDataAccess.ConnectionString;

        public static bool GetTestInfoByID(int testID, ref int testAppointmentID, ref bool testResult, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Tests WHERE TestID = @TestID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                testAppointmentID = (int)reader["TestAppointmentID"];
                                testResult = (bool)reader["TestResult"];
                                notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";
                                createdByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error if needed
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static bool GetTestInfoByAppointmentID(ref int testID,  int TestAppointmentID, ref bool testResult, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Tests WHERE TestAppointmentID = @TestAppointmentID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                testID = (int)reader["TestID"];
                                testResult = (bool)reader["TestResult"];
                                notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";
                                createdByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error if needed
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static DataTable LicenseTestAppointment(int AppointmentID)
        {
            DataTable  dataTable= new DataTable();

            
            using(SqlConnection  connection = new SqlConnection(_connectionString))
            {
                string Query = "Select TestAppointmentID , AppointmentDate , PaidFees, IsLocked from TestAppointments_View  Where TestAppointmentID = @AppointmentID;";

                using (SqlCommand command =new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("AppointmentID",AppointmentID);
                  
                    try
                    {
                        connection.Open();
                        SqlDataReader Reader = command.ExecuteReader();
                        if(Reader.Read())
                        {
                            dataTable.Load(Reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle As You Like ;
                    }

                }
            }
            return dataTable;

        }

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Tests ORDER BY TestID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error if needed
                    }
                }
            }

            return dt;
        }

        public static int AddNewTest(int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int testID = -1;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                    VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                    
                    UPDATE TestAppointments 
                    SET IsLocked = 1 
                    WHERE TestAppointmentID = @TestAppointmentID;

                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    command.Parameters.AddWithValue("@TestResult", testResult);
                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? DBNull.Value : (object)notes);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            testID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error if needed
                    }
                }
            }

            return testID;
        }

        public static bool UpdateTest(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Tests  
                    SET TestAppointmentID = @TestAppointmentID,
                        TestResult = @TestResult,
                        Notes = @Notes,
                        CreatedByUserID = @CreatedByUserID
                    WHERE TestID = @TestID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", testID);
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    command.Parameters.AddWithValue("@TestResult", testResult);
                    command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? DBNull.Value : (object)notes);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log error if needed
                    }
                }
            }

            return rowsAffected > 0;
        }

        public static byte GetPassedTestCount(int localDrivingLicenseApplicationID)
        {
            byte passedTestCount = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT COUNT(TestTypeID) AS PassedTestCount
                    FROM Tests
                    INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                    WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                        AND TestResult = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
                        {
                            passedTestCount = ptCount;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error if needed
                    }
                }
            }

            return passedTestCount;
        }

        public static int PassedAllTests(int LocalDrivingLicenseApplicationID)
        {

            int Count = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"   SELECT Passed =  Count(Tests.TestResult)
                         from TestAppointments
                         INNER JOIN Tests
                         ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                         WHERE LocalDrivingLicenseApplicationID = 38 and Tests.TestResult=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Result))
                {
                    Count = Result;
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

            return Count ;
        }

    }
}


