using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsTestTypeData
    {
        public static bool GetTestTypeInfoByID(int ID, ref string Title, ref string Description, ref float Fees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestTypes WHERE TestTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Title = (string)reader["TestTypeTitle"];
                    Description = (string)reader["TestTypeDescription"];
                    Fees = Convert.ToSingle(reader["TestTypeFees"]);
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

        public static int AddNewTestType(string Title, string Description, float Fees)
        {
            int TestTypeID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestTypes (Title, Description, Fees)
                     VALUES
                     (@Title, @Description, @Fees);

                     SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    TestTypeID = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return TestTypeID;
        }

        public static bool UpdateTestType(int ID, string Title, string Description, float Fees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestTypes
                         SET TestTypeTitle = @Title,
                             TestTypeDescription = @Description,
                             TestTypeFees = @Fees
                         WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);

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

        public static DataTable GetAllTestTypes()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM TestTypes ORDER BY TestTypeID";

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

    }
}
