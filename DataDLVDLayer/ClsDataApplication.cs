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
    public class ClsDataApplication
    {

        public static bool GetApplicationInfoByID(int ApplicationID,ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID,ref byte ApplicationStatus, ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                ApplicantPersonID = (int)reader["ApplicantPersonID"];
                                ApplicationDate = (DateTime)reader["ApplicationDate"];
                                ApplicationTypeID = (int)reader["ApplicationTypeID"];
                                ApplicationStatus = (byte)reader["ApplicationStatus"];
                                LastStatusDate = (DateTime)reader["LastStatusDate"];
                                PaidFees = Convert.ToSingle(reader["PaidFees"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"INSERT INTO Applications ( 
                            ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,
                            PaidFees,CreatedByUserID)
                             VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                      @ApplicationStatus,@LastStatusDate,
                                      @PaidFees,   @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
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


            return ApplicationID;
        }


        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            bool isUpdated = false;
            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                string query = @"UPDATE Applications SET ApplicantPersonID = @ApplicantPersonID, 
                         ApplicationDate = @ApplicationDate, ApplicationTypeID = @ApplicationTypeID, 
                         ApplicationStatus = @ApplicationStatus, LastStatusDate = @LastStatusDate, 
                         PaidFees = @PaidFees, CreatedByUserID = @CreatedByUserID 
                         WHERE ApplicationID = @ApplicationID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isUpdated = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }
            return isUpdated;
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            bool isDeleted = false;
            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isDeleted = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }
            return isDeleted;
        }

        public static bool UpdateStatus(int ApplicationID, int Status)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                string query = @"Update  Applications
                            set
                                ApplicationStatus = @Status, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID = @ApplicationID; ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("status", Status);
                command.Parameters.AddWithValue("LastStatusDate", DateTime.Now);
                try
                {
                    connection.Open();
                     rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
                return (rowsAffected > 0);
            }
        }

        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID=@ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);
            command.Parameters.AddWithValue("LastStatusDate", DateTime.Now);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}
