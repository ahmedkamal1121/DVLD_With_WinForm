using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{
    public class clsDataAccess
    {
        public static DataTable GetAllPeople(string Filter = "", string serech = "")
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

 

            string query = @"SELECT        People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth,
  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption 
, Countries.CountryName ,People.Phone, People.Email, 
                         People.ImagePath
FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID";



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

        public static DataTable GetAllPeopleWithFilter(string Filter = "", string serech = "")
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from people where " + Filter + " like '' + @serech + '%' ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Filter", Filter);
            command.Parameters.AddWithValue("@serech", serech);

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

        public static bool chickNoIsFound(string NaNo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select found=1 where exists (select top 1 * from People where NationalNo = @NaNo)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NaNo", NaNo);

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

        public static DataTable LoadCountries()
        {
         DataTable dt = new DataTable();
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries order by CountryName";

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

        public static bool FindCOUNTRY(string Name , ref int  ID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = " select CountryID from Countries  where CountryName = @CountryName";
          

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["CountryID"];
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

                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool FindCOUNTRYById(ref string Name,  int CountryID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = " select CountryName from Countries  where CountryID = @CountryID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Name = (string)reader["CountryName"];
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

                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }


    }





}
