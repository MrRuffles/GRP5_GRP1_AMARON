using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Library{

    public class CADProduct{

        private string constring;

        //Initializates connection string to data base
        public CADProduct() {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        /*
         * Adds a product to the Data Base
         * Paramaters: product to create
         * Returns: true if the product could be created, false on the contrary
         */
        public bool CreateProduct(ENProduct product){

            bool created = false;

            return created;

        }

        /*
         *Reads a product from Data Base
         * Parameters: product to read
         * Returns: true if the product could be read, false on the contrary
         */


        public bool ReadProduct(ENProduct prod)
        {

            SqlConnection con = new SqlConnection(constring);
            bool correct = true;


            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "SELECT * FROM Product where cod='" + prod.id + "';";

                    SqlDataReader auxLectura = cmd.ExecuteReader();

                    while (auxLectura.Read())
                    {
                        
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
        public DataTable ReadProductCat(ENProduct product){

            SqlConnection con = new SqlConnection(constring);

            DataSet set = new DataSet();

            SqlDataAdapter ad = new SqlDataAdapter("Select * from Product;", con);
            ad.Fill(set,"Product");

            DataTable tb = new DataTable();
            tb = set.Tables["Product"];
            return tb;
        }

        public DataTable ReadProductBot(ENProduct product)
        {

            SqlConnection con = new SqlConnection(constring);

            DataSet set = new DataSet();

            SqlDataAdapter ad = new SqlDataAdapter("Select * from Product where type='botella';", con);
            ad.Fill(set, "Product");

            DataTable tb = new DataTable();
            tb = set.Tables["Product"];
            return tb;
        }

        public DataTable ReadProductPack(ENProduct product)
        {

            SqlConnection con = new SqlConnection(constring);

            DataSet set = new DataSet();

            SqlDataAdapter ad = new SqlDataAdapter("Select * from Product where type='pack';", con);
            ad.Fill(set, "Product");

            DataTable tb = new DataTable();
            tb = set.Tables["Product"];
            return tb;
        }

        public DataTable ReadProductMisc(ENProduct product)
        {

            SqlConnection con = new SqlConnection(constring);

            DataSet set = new DataSet();

            SqlDataAdapter ad = new SqlDataAdapter("Select * from Product where type='misc';", con);
            ad.Fill(set, "Product");

            DataTable tb = new DataTable();
            tb = set.Tables["Product"];
            return tb;
        }

        /*
         * Updates the product in the DataBase
         * Parameters: product to update
         * Return: true in case that the product could be updated
        */
        public bool UpdateProduct(ENProduct product){
            bool updated = false;

            return updated;
        }

        /*
         * Deletes the product in the Data Base
         * Parameters: product to delete
         * Return: true in case that the product could be deleted, false on the contrary
        */
        public bool DeleteProduct(ENProduct product){

            bool deleted = false;

            return deleted;

        }


    }//End class CADProduct



}
