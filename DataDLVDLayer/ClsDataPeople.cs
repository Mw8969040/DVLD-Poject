using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataDLVDLayer
{
    public class ClsDataPeople
    {
        public static DataTable ListPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);
            string Query = @"SELECT PersonID , NationalNo , FirstName , SecondName , ThirdName ,LastName, Cast (DateOfBirth as Date ) as BirthDate ,Gendor,Address,Phone,Email,NationalityCountryID  FROM People;";

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

        public static bool FindPerson(int PersonID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref int gendor, ref string email, ref string phone, ref int countryID, ref string nationalNo, ref string address, ref string imagePath, ref DateTime dateOfBirth)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // تحقق من وجود الصف
                {
                    isFound = true;
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString();
                    thirdName = reader["ThirdName"].ToString();
                    lastName = reader["LastName"].ToString();
                    gendor = Convert.ToInt32(reader["Gendor"]);
                    email = reader["Email"].ToString();
                    phone = reader["Phone"].ToString();
                    countryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    nationalNo = reader["NationalNo"].ToString();
                    address = reader["Address"].ToString();
                    imagePath = reader["ImagePath"].ToString();
                    dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
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

        public static bool FindPerson(ref int PersonID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref int gendor, ref string email, ref string phone, ref int countryID,string NationalNo, ref string address, ref string imagePath, ref DateTime dateOfBirth)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // تحقق من وجود الصف
                {
                    isFound = true;
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString();
                    thirdName = reader["ThirdName"].ToString();
                    lastName = reader["LastName"].ToString();
                    gendor = Convert.ToInt32(reader["Gendor"]);
                    email = reader["Email"].ToString();
                    phone = reader["Phone"].ToString();
                    countryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    PersonID = int.Parse(reader["PersonID"].ToString());
                    address = reader["Address"].ToString();
                    imagePath = reader["ImagePath"].ToString();
                    dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
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

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, int Gendor, string Email, string Phone, int CountryID, string NationalNo, string Address, string ImagePath, DateTime DateOfBirth)
        {
            SqlConnection Connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string Query = @"INSERT INTO People (FirstName, SecondName, ThirdName, LastName, Gendor, Email, Phone, NationalityCountryID, NationalNo, Address, ImagePath, DateOfBirth) VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @Gendor, @Email, @Phone, @CountryID, @NationalNo, @Address, @ImagePath, @DateOfBirth);SELECT SCOPE_IDENTITY();"
            ;

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

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
        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName,int Gendor, string Email, string Phone, int CountryID, string NationalNo,  string Address, string ImagePath, DateTime DateOfBirth)
        {
            int RowEffected = 0;

            string Query = @"UPDATE People 
                     SET FirstName=@FirstName,
                         SecondName=@SecondName,
                         ThirdName=@ThirdName,
                         LastName=@LastName,
                         Gendor=@Gendor,
                         Email=@Email,
                         Phone=@Phone,
                         NationalityCountryID=@CountryID,
                         NationalNo=@NationalNo,
                         Address=@Address,
                         ImagePath=@ImagePath,
                         DateOfBirth=@DateOfBirth
                     WHERE PersonID=@PersonID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gendor", Gendor);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                    try
                    {
                        connection.Open();
                        RowEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                       //Handle As You Like
                        return false;
                    }
                }
            }

            return (RowEffected > 0);
        }

        public static bool DeletePerson(int PersonID)
        {
            int RowAffected = 0;
            string Query = @"DELETE FROM People WHERE PersonID=@PersonID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }

            return (RowAffected > 0);
        }

        public static bool IsNationalNoExist(string NationalNo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccess.ConnectionString);

            string Query = "Select found=1 from People where NationalNo=@NationalNo";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

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
