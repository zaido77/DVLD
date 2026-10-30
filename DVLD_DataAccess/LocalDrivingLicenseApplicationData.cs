using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLocalDrivingLicenseApplicationData
    {
        public static bool GetLocalDrivingLicenseApplicationInfoByID(int ID, ref int ApplicationID, 
            ref int LicenseClassID, ref byte PassedTests, ref int IssuedLicenseID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                SELECT 
                	LDLA.*,
                	PassedTests = (
                		SELECT COUNT(*) FROM LocalDrivingLicenseApplications LDLA
                		INNER JOIN TestAppointments TA 
                            ON LDLA.LocalDrivingLicenseApplicationID = TA.LocalDrivingLicenseApplicationID
                		INNER JOIN Tests T 
                            ON TA.TestAppointmentID = T.TestAppointmentID
                		WHERE LDLA.LocalDrivingLicenseApplicationID = @ID AND T.TestResult = 1),
                    IssuedLicenseID = (
		                SELECT LicenseID FROM Licenses L
		                WHERE LDLA.ApplicationID = L.ApplicationID)
                FROM LocalDrivingLicenseApplications LDLA
                WHERE LDLA.LocalDrivingLicenseApplicationID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    PassedTests = Convert.ToByte(reader["PassedTests"]);

                    if (reader["IssuedLicenseID"] != DBNull.Value)
                        IssuedLicenseID = (int)reader["IssuedLicenseID"];
                    else
                        IssuedLicenseID = -1;
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

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                     VALUES
                     (@ApplicationID, @LicenseClassID);

                     SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    LocalDrivingLicenseApplicationID = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int ID, int ApplicationID, int LicenseClassID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE LocalDrivingLicenseApplications
                         SET ApplicationID = @ApplicationID,
                             LicenseClassID = @LicenseClassID
                         WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM LocalDrivingLicenseApplications 
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM vwLocalDrivingLicenseApplications
                             ORDER BY Status DESC, [Application Date] DESC";

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

        public static int GetAssociatedApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT ApplicationID FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    ApplicationID = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return ApplicationID;
        }

    }
}
