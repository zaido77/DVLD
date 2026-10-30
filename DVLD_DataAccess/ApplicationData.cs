using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clsApplicationData
    {
        enum enStatus { New = 1, Cancelled = 2, Completed = 3 }

        public static bool GetApplicationInfoByID(int ID, ref int ApplicantPersonID, ref DateTime ApplicationDate,
                ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate,
                ref float PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
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


        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate,
                int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate,
                float PaidFees, int CreatedByUserID)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate,
                        ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                        VALUES
                        (@ApplicantPersonID, @ApplicationDate,
                        @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                        
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

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


        public static bool UpdateApplication(int ID, int ApplicantPersonID, DateTime ApplicationDate,
                int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate,
                float PaidFees, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Applications
                             SET ApplicantPersonID = @ApplicantPersonID,
                                 ApplicationDate = @ApplicationDate,
                                 ApplicationTypeID = @ApplicationTypeID,
                                 ApplicationStatus = @ApplicationStatus,
                                 LastStatusDate = @LastStatusDate,
                                 PaidFees = @PaidFees,
                                 CreatedByUserID = @CreatedByUserID
                             WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ID);
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


        public static bool DeleteApplication(int ApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool CancelApplication(int ApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = $@"UPDATE Applications 
                             SET ApplicationStatus = {(int)enStatus.Cancelled}
                             WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool IsApplicationExist(int PersonID, int LicenseClassID, byte Status, ref int ActiveApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT A.ApplicationID FROM Applications A
                   INNER JOIN LocalDrivingLicenseApplications LA ON A.ApplicationID = LA.ApplicationID
                   WHERE A.ApplicantPersonID = @PersonID AND
                         LA.LicenseClassID = @LicenseClassID AND
                         A.ApplicationStatus = @Status";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@Status", Status);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    ActiveApplicationID = -1;
                else
                    ActiveApplicationID = (int)result;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID != -1;
        }

    }
}
