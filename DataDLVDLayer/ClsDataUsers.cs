using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLVDLayer
{
    public class ClsDataUsers
    {
        public static DataTable ListUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = @"SELECT 
            Users.UserID, 
            Users.PersonID,
             People.FirstName + '  ' + People.SecondName + '  ' + People.ThirdName + '  ' + People.LastName AS FullName,
            Users.UserName,       
            Users.Password, 
            Users.IsActive
            FROM Users
             INNER JOIN People ON Users.PersonID = People.PersonID;";

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

        public static bool FindUser(int UserID, ref int PersonID, ref string UserName, ref string Password, ref int IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string query = @"SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    UserName = reader["UserName"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToInt32(reader["IsActive"]);
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

        public static bool FindUser(string UserName, ref int UserID, ref int PersonID, ref string Password, ref int IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string query = @"SELECT * FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = Convert.ToInt32(reader["UserID"]);
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToInt32(reader["IsActive"]);
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


        public static int AddNewUser(int PersonID, string UserName, string Password, int IsActive)
        {
            SqlConnection Connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive) VALUES (@PersonID, @UserName, @Password, @IsActive); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            Connection.Open();
            try
            {
                object RowEffected = command.ExecuteScalar();
                Connection.Close();
                if (RowEffected != null && int.TryParse(RowEffected.ToString(), out int ResultID))
                {
                    return ResultID;
                }
            }
            catch (Exception ex)
            {
                //Handle as you like 
            }
            return -1;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, int IsActive)
        {
            int RowEffected = 0;
            string Query = @"UPDATE Users SET PersonID=@PersonID, UserName=@UserName, Password=@Password, IsActive=@IsActive WHERE UserID=@UserID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

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

        public static bool DeleteUser(int UserID)
        {
            int RowAffected = 0;
            string Query = @"DELETE FROM Users WHERE UserID=@UserID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return (RowAffected > 0);
        }

        public static bool IsUserNameExist(string UserName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = "SELECT 1 FROM Users WHERE UserName=@UserName";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool IsPersonIDNoExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string Query = "Select found=1 from Users where PersonID=@PersonID";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object Reslult = Command.ExecuteScalar();

                if (Reslult != null)
                {
                    IsFound = true;
                }

            }

            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }


    }
}
