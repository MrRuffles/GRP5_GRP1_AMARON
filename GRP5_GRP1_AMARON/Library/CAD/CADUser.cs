//Paula Guadalajara Saiz

using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Library
{

    public class CADUser
    {

        private string constring;

        /**  Initializes connection string to data base  **/
        public CADUser()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        /**  Adds a new user to data base  **/
        public bool CreateUser(ENUser user)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("Esto va perfectisiiiimo");
                }
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "INSERT INTO User (name, password, email, age, urlImage, empresa, address) values ('" + user.name + "', '" + user.pass + "', '" + user.email + "', " + user.age + ", '" + user.url + "', '" + user.empresa + "', '" + user.address + "');";
                    cmd.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                correct = false;
            }
            finally
            {
                con.Close();
            }

            return correct;

        }

        /**  Reads a user from data base  **/
        public bool ReadUser(ENUser user)
        {
            return true;
        }

        /** Updates a user from data base **/
        public bool UpdateUser(ENUser user)
        {
            return true;
        }

        /**  Deletes a user from data base  **/
        public bool DeleteUser(ENUser user)
        {
            return true;
        }

    }
}
