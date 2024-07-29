using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class clsInternationalLicenseData
    {

        public static DataTable GetAllInternationalLicenses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
            SELECT    InternationalLicenseID, ApplicationID,DriverID,
		                IssuedUsingLocalLicenseID , IssueDate, 
                        ExpirationDate, IsActive
		    from InternationalLicenses 
                order by IsActive, ExpirationDate desc";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static int AddNew(int ApplicationID,
             int DriverID, int IssuedUsingLocalLicenseID,
             DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[InternationalLicenses]
                                   ([ApplicationID]
                                   ,[DriverID]
                                   ,[IssuedUsingLocalLicenseID]
                                   ,[IssueDate]
                                   ,[ExpirationDate]
                                   ,[IsActive]
                                   ,[CreatedByUserID])
                             VALUES
                                   (@ApplicationID
                                   ,@DriverID
                                   ,@IssuedUsingLocalLicenseID
                                   ,@IssueDate
                                   ,@ExpirationDate
                                   ,@IsActive
                                   ,@CreatedByUserID)
		                               SELECT SCOPE_IDENTITY();";


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

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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

            return UserID;
        }


        public static bool ChechUserIsFound(int ApplicantPersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT   InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, InternationalLicenses.DriverID, InternationalLicenses.IssuedUsingLocalLicenseID, InternationalLicenses.IssueDate, 
                                             InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive, InternationalLicenses.CreatedByUserID
                    FROM            InternationalLicenses INNER JOIN
                                             Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID
                    where ApplicantPersonID = @ApplicantPersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    IsFound = true;
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }


    }
}
