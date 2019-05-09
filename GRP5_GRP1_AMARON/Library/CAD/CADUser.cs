//Paula Guadalajara Saiz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    if (user.empresa == "")
                    {
                        cmd.CommandText = "INSERT INTO \"User\" (name, password, email, age, urlImage, address) values ('" + user.name + "', '" + user.pass + "', '" + user.email + "', " + user.age + ", '" + user.url + "', '" + user.address + "');";
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO \"User\" (name, password, email, age, urlImage, empresa, address) values ('" + user.name + "', '" + user.pass + "', '" + user.email + "', " + user.age + ", '" + user.url + "', '" + user.empresa + "', '" + user.address + "');";
                    }
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
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "SELECT email, password FROM \"User\" where email='" + user.email + "' and password='"+ user.pass + "';";

                    SqlDataReader auxLectura = cmd.ExecuteReader();

                    while (auxLectura.Read())
                    {
                        user.email = Convert.ToString(auxLectura[0]);
                        user.pass = Convert.ToString(auxLectura[1]);
                    }

                    auxLectura.Close();
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
