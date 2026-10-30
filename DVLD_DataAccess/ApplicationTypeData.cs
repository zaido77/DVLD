using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationTypeData
    {
        public static bool GetApplicationTypeInfoByID(int ID, ref string Title, ref float Fees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Title = (string)reader["ApplicationTypeTitle"];
                    Fees = Convert.ToSingle(reader["ApplicationFees"]);
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

        public static bool UpdateApplicationType(int ID, string Title, float Fees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE ApplicationTypes
                         SET ApplicationTypeTitle = @Title,
                             ApplicationFees = @Fees
                         WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ID);
            command.Parameters.AddWithValue("@Title", Title);
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

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM ApplicationTypes ORDER BY ApplicationTypeTitle ASC";

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
