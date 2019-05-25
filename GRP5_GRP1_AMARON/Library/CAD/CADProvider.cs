//Paula Guadalajara Saiz

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Library
{

    public class CADProvider
    {

        private string constring;

        /**  Initializes connection string to data base  **/
        public CADProvider()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        /**  Adds a new provider to data base  **/
        public bool CreateProvider(ENProvider provider)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;
            string datestring = provider.birth.ToString("yyyy-MM-dd");
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "INSERT INTO Users (name, password, email, birthdate, urlImage, empresa, address) values ('" + provider.name + "', '" + provider.pass + "', '" + provider.email + "', '" + datestring + "', '" + provider.url + "', '" + provider.company + "', '" + provider.address + "');";
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

        /**  Reads a provider from data base  **/
        public bool ReadProvider(ENProvider provider)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;


            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "SELECT empresa FROM Users where email='" + provider.email + "';";
                    SqlDataReader auxLectura = cmd.ExecuteReader();

                    while (auxLectura.Read())
                    {
                        provider.empresa = Convert.ToString(auxLectura[0]);
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

        /** Updates a provider from data base **/
        public bool UpdateProvider(ENProvider provider)
        {
            return false;
        }

        /**  Deletes a provider from data base  **/
        public bool DeleteProvider(ENProvider provider)
        {
            return false;
        }
    }
}
