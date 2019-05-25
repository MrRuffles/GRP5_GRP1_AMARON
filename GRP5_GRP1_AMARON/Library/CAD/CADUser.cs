//Paula Guadalajara Saiz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

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
                    cmd.CommandText = "INSERT INTO Users (name, password, email, birthdate, urlImage, address) values ('" + user.name + "', '" + user.pass + "', '" + user.email + "', '" + user.birth.ToString("yyyy-MM-dd") + "', '" + user.url + "', '" + user.address + "');";
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
            string savedPass="";
            

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "SELECT email, password FROM Users where email='" + user.email + "';"; // "' and password='" + user.pass + "';";

                    SqlDataReader auxLectura = cmd.ExecuteReader();

                    while (auxLectura.Read())
                    {
                        user.email = Convert.ToString(auxLectura[0]);
                        savedPass = Convert.ToString(auxLectura[1]);

                    }

                    if(!auxLectura.HasRows)
                    {
                        correct = false;
                    }
                    else
                    {
                        byte[] hashBytes = Convert.FromBase64String(savedPass);
                        byte[] salt = new byte[16];
                        Array.Copy(hashBytes, 0, salt, 0, 16);
                        var pbkdf2 = new Rfc2898DeriveBytes(user.pass, salt, 1000);
                        byte[] hash = pbkdf2.GetBytes(20);

                        for (int i = 0; i < 20; i++)
                            if (hashBytes[i + 16] != hash[i])
                                correct = false;
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

        /**  Reads a user from data base to show data on the profile page  **/
        public bool ReadUserPerfil(ENUser user)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "SELECT * FROM Users where email='" + user.email + "';";

                    SqlDataReader auxLectura = cmd.ExecuteReader();

                    while (auxLectura.Read())
                    {
                        user.name = Convert.ToString(auxLectura[1]);
                        user.email = Convert.ToString(auxLectura[3]);
                        user.birth = Convert.ToDateTime(auxLectura[4]);
                        user.url = Convert.ToString(auxLectura[5]);
                        if(auxLectura[6] != null) {
                            user.empresa = Convert.ToString(auxLectura[6]);
                        }
                        user.address = Convert.ToString(auxLectura[7]);
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

        public bool ReadUserEDPerfil(ENUser user)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "SELECT * FROM Users where email='" + user.email + "';";

                    SqlDataReader auxLectura = cmd.ExecuteReader();

                    while (auxLectura.Read())
                    {
                        user.name = Convert.ToString(auxLectura[1]);
                        user.pass = Convert.ToString(auxLectura[2]);
                        user.email = Convert.ToString(auxLectura[3]);
                        user.birth = Convert.ToDateTime(auxLectura[4]);
                        user.url = Convert.ToString(auxLectura[5]);
                        if (auxLectura[6] != null)
                        {
                            user.empresa = Convert.ToString(auxLectura[6]);
                        }
                        user.address = Convert.ToString(auxLectura[7]);
                    }

                    byte[] hashBytes = Convert.FromBase64String(user.pass);
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    var pbkdf2 = new Rfc2898DeriveBytes(user.pass, salt, 1000);
                    byte[] hash = pbkdf2.GetBytes(20);

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

        public bool EmailExist(ENUser user)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "SELECT email, password FROM Users where email='" + user.email + "';"; // "' and password='" + user.pass + "';";
                    SqlDataReader auxLectura = cmd.ExecuteReader();
                    while (auxLectura.Read())
                    {
                        user.email = Convert.ToString(auxLectura[0]);
                    }
                    if (!auxLectura.HasRows)
                    {
                        correct = false;
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
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {

                byte[] salt;

                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                var pb = new Rfc2898DeriveBytes(user.pass, salt, 1000);

                byte[] hash = pb.GetBytes(20);

                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                string hashpass= Convert.ToBase64String(hashBytes);


                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "UPDATE Users set name='" + user.name + "', password='" + hashpass + "', urlImage='" + user.url + "', address='" + user.address +"' where email='" + user.email + "';";
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

        /**  Deletes a user from data base  **/
        public bool DeleteUser(ENUser user)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "delete from Users where email='" + user.email + "';";
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

    }
}
