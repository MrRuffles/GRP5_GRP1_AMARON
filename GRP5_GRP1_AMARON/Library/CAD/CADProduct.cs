using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;


namespace Library{

    public class CADProduct{

        private string constring;

        //Initializates connection string to data base
        public CADProduct(){
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        /*
         * Adds a product to the Data Base
         * Paramaters: product to create
         * Returns: true if the product could be created, false on the contrary
         */
        public bool CreateProduct(ENProduct product){

            bool created = false;
            SqlConnection conection = new SqlConnection(constring);

            try{

                conection.Open();

                using (SqlCommand cmd = new SqlCommand("", conection)){

                    cmd.CommandText = "INSERT INTO Product(name, pvp, stock, brand, type, description, urlImage) values ('"
                        + product.name + "'," + product.price + ", " + product.stock + ", '" + product.brand + "', '"
                        + product.type + "', '" + product.description + "', '" + product.url + "');";

                    cmd.ExecuteNonQuery();

                }

                created = true;

            }catch (SqlException ex){

                Console.WriteLine("Error al crear product. ", ex.Message);

            }finally{

                conection.Close();
            }
            

            return created;

        }

        /*
         *Reads a product from Data Base
         * Parameters: product to read
         * Returns: true if the product could be read, false on the contrary
         */
        public bool ReadProduct(ENProduct product)
        {

            bool read = false;
            SqlConnection conection = new SqlConnection(constring);

            try{

                conection.Open();

                using (SqlCommand cmd = new SqlCommand("", conection)){

                    cmd.CommandText = "SELECT * FROM Product where name = '" + product.name + "';";

                    SqlDataReader productRead = cmd.ExecuteReader();

                    if(productRead.HasRows){

                        product.id = Convert.ToInt32(productRead[0]);
                        product.name = Convert.ToString(productRead[1]);
                        product.price = (float) Convert.ToDouble(productRead[2]);
                        product.stock = Convert.ToInt32(productRead[3]);
                        product.brand = Convert.ToString(productRead[4]);
                        product.type = Convert.ToString(productRead[5]);
                        product.description = Convert.ToString(productRead[6]);
                        product.url = Convert.ToString(productRead[7]);

                    }

                    productRead.Close();

                }

                read = true;

            }catch(SqlException Ex){

                Console.WriteLine("No se ha podido recuperar el producto de la base de datos.", Ex.Message);


            }finally {

                conection.Close();
            }

            return read;

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

            SqlDataAdapter ad = new SqlDataAdapter("Select * from Product where type='miscelanea';", con);
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
