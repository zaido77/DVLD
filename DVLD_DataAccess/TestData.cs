using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestData
    {
        public static bool GetTestInfoByTestID(int TestID, ref int TestAppointmentID, ref byte TestResult,
            ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = Convert.ToByte(reader["TestResult"]);

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";
                    
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

        public static bool GetTestInfoByAppointmentID(int TestAppointmentID, ref int TestID, 
            ref byte TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Tests WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    TestID = (int)reader["TestID"];
                    TestResult = Convert.ToByte(reader["TestResult"]);

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";
                    
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

        public static int AddNewTest(int TestAppointmentID, byte TestResult,
            string Notes, int CreatedByUserID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Tests
                         (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                         VALUES
                         (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);

                         SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            
            if (!string.IsNullOrEmpty(Notes.Trim()))
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    TestID = (int)result;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, byte TestResult,
            string Notes, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Tests
                         SET TestAppointmentID = @TestAppointmentID,
                             TestResult = @TestResult,
                             Notes = @Notes,
                             CreatedByUserID = @CreatedByUserID
                         WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            
            if (!string.IsNullOrEmpty(Notes.Trim()))
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value); 
            
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

        public static bool IsTestExistByAppointmentID(int TestAppointmentID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Tests WHERE TestAppointmentID = @TestAppointmentIDestID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                IsExist = (result != null);
            }
            catch (Exception)
            {
                IsExist = false;
            }
            finally
            {
                connection.Close();
            }

            return IsExist;
        }

        public static bool IsTestPassedFor(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsPassed = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found=1 FROM Tests T
                             INNER JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID
                             WHERE TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                             AND TA.TestTypeID = @TestTypeID
                             AND T.TestResult = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                IsPassed = (result != null);
            }
            catch (Exception)
            {
                IsPassed = false;
            }
            finally
            {
                connection.Close();
            }

            return IsPassed;
        }

    }
}
