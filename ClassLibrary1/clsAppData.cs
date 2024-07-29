using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Security.Policy;

namespace DataAccess
{
    public class clsAppData
    {


        public static DataTable GetAllApps()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT [LocalDrivingLicenseApplicationID]
                              ,[ClassName]
                              ,[NationalNo]
                              ,[FullName]
                              ,[ApplicationDate]
                              ,[PassedTestCount]
                              ,[Status]
                          FROM [dbo].[LocalDrivingLicenseApplications_View]";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dataTable.Load(reader);
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

            return dataTable;

        }


        public static DataTable GetAllClasses()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT ClassName
                                    FROM LicenseClasses";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dataTable.Load(reader);
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

            return dataTable;

        }

        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
          byte ApplicationStatus, DateTime LastStatusDate,
          float PaidFees, int CreatedByUserID)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications ( 
                            ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,
                            PaidFees,CreatedByUserID)
                             VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                      @ApplicationStatus,@LastStatusDate,
                                      @PaidFees,   @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("ApplicantPersonID", @ApplicantPersonID);
            command.Parameters.AddWithValue("ApplicationDate", @ApplicationDate);
            command.Parameters.AddWithValue("ApplicationTypeID", @ApplicationTypeID);
            command.Parameters.AddWithValue("ApplicationStatus", @ApplicationStatus);
            command.Parameters.AddWithValue("LastStatusDate", @LastStatusDate);
            command.Parameters.AddWithValue("PaidFees", @PaidFees);
            command.Parameters.AddWithValue("CreatedByUserID", @CreatedByUserID);




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

        public static bool Find(int ApplicationID, ref int ApplicantPersonID,
                   ref DateTime ApplicationDate, ref int ApplicationTypeID,
                   ref byte ApplicationStatus, ref DateTime LastStatusDate,
                     ref float PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Applications
                                where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                   

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

        public static bool Find(int ApplicationID)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Applications
                                where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
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


        public static bool IsPesronHaveSameClasslicenese(string NationalNo, string cbClasses)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Found=1
                          FROM LocalDrivingLicenseApplications_View
                          where NationalNo = @NationalNo and ClassName = @cbClasses
                          and Status != 'Cancelled' ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@cbClasses", cbClasses);

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


        public static bool ChangeStatus(int ApplicationID, int Status)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[Applications]
                               SET 
                                  [ApplicationStatus] = @Status

                             WHERE ApplicationID = @ApplicationID;
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
