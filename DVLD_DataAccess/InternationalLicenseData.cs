using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsInternationalLicenseData
    {
        public static bool GetInternationalLicenseInfoByID(int InternationalLicenseID,
            ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive,
            ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetActiveInternationalLicenseByDriverID(int DriverID, 
            ref int InternationalLicenseID, ref int ApplicationID, ref int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive,
            ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TOP 1 * FROM InternationalLicenses 
                             WHERE DriverID = @DriverID AND IsActive = 1
                             ORDER BY InternationalLicenseID DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddNewInternationalLicense(int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate,
            bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO InternationalLicenses
                         (ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                          IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                         VALUES
                         (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID,
                          @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);

                         SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    InternationalLicenseID = (int)result;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return InternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(int InternationalLicenseID,
            int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive,
            int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE InternationalLicenses
                         SET ApplicationID = @ApplicationID,
                             DriverID = @DriverID,
                             IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                             IssueDate = @IssueDate,
                             ExpirationDate = @ExpirationDate,
                             IsActive = @IsActive,
                             CreatedByUserID = @CreatedByUserID
                         WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT 
                                [Int.License ID] = InternationalLicenseID,
                                [Application ID] = ApplicationID,
                                [Driver ID] = DriverID,
                                [L.License ID] = IssuedUsingLocalLicenseID,
                                [Issue Date] = IssueDate,
                                [Expiration Date] = ExpirationDate,
                                [Is Active] = IsActive
                            FROM InternationalLicenses
                            ORDER BY IsActive DESC, ExpirationDate DESC";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT 
                                InternationalLicenseID,
                                ApplicationID,
                                IssuedUsingLocalLicenseID,
                                IssueDate, 
                                ExpirationDate,
                                IsActive
                             FROM InternationalLicenses
                             WHERE DriverID = @DriverID
                             ORDER BY ExpirationDate DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        public static bool UpdateIsActive(int InternationalLicenseID, bool IsActive)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE InternationalLicenses
                             SET IsActive = @IsActive
                             WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
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
}
