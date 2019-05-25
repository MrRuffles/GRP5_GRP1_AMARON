using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    public class CADRatting
    {
        private string constring;

        public CADRatting()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        public bool createRatting(ENRatting en)
        {
            bool correct = true;
            SqlConnection conection = new SqlConnection(constring);

            try
            {

                conection.Open();

                using (SqlCommand cmd = new SqlCommand("", conection))
                {

                    cmd.CommandText = "INSERT INTO Rating(value, product, userID, comment) values ("
                        + en.rvalue + "," + en.prodID + ", " + en.user + ", '"+ en.commentPublic + "');";

                    cmd.ExecuteNonQuery();

                }


            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error al inserta el rating en la base de datos. ", ex.Message);
                correct = false;

            }
            finally
            {

                conection.Close();
            }

            return correct;
        }

        public bool readRatting(ENRatting en)
        {
            bool correct = true;
            

            return correct;

        }

        public bool updateRatting(ENRatting en)
        {
            bool correct = true;

            return correct;

        }

        public bool deleteRatting(ENRatting en)
        {
            bool correct = false;

            return correct;
        }
    }
}
