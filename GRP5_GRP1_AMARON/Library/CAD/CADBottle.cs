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

      public class CADBottle{

        private string constring;

        //Initializates connection string to data base
        public CADBottle() {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

            /*
             * Adds a bottle to the Data Base
             * Paramaters: bottle to create
             * Returns: true if the bottle could be created, false on the contrary
             */
            public bool CreateBottle(ENBottle bottle){

                bool created = false;

                SqlConnection conection = new SqlConnection(constring);

                try{

                    conection.Open();

                    using (SqlCommand cmd = new SqlCommand("", conection)){

                        cmd.CommandText = "INSERT INTO Bottle(product, grade, alcoholicType, volume) values ("
                            + bottle.cod + "," + bottle.grade+ ", '" + bottle.alcoholicType + "', "
                            + bottle.volume + ");";

                        cmd.ExecuteNonQuery();

                    }

                    created = true;

                }
                catch (SqlException ex){

                    Console.WriteLine("Error al inserta la botella en la base de datos. ", ex.Message);

                }finally{

                    conection.Close();
                }

                return created;

            }

            /*
             * Reads a bottle from Data Base
             * Parameters: bottle to read
             * Returns: true if the bottle could be read, false on the contrary
             */
            public bool ReadBottle(ENBottle bottle){

                bool read = false;

                SqlConnection conection = new SqlConnection(constring);

                try{

                    conection.Open();

                    using (SqlCommand cmd = new SqlCommand("", conection)){

                        cmd.CommandText = "SELECT * FROM Bottle where product = '" + bottle.id + "';";

                        SqlDataReader bottleRead = cmd.ExecuteReader();

                        while (bottleRead.Read()){

                            bottle.grade = float.Parse(Convert.ToString(bottleRead[1]));
                            bottle.alcoholicType = Convert.ToString(bottleRead[2]);
                            bottle.volume = float.Parse(Convert.ToString(bottleRead[3]));

                        }

                        bottleRead.Close();

                    }

                    read = true;

                }
                catch (SqlException Ex)
                {

                    Console.WriteLine("No se ha podido recuperar el producto de la base de datos.", Ex.Message);


                }
                finally
                {

                        conection.Close();
                }



                return read;

            }

            /*
             * Updates the bottle in the DataBase
             * Parameters: bottle to update
             * Return: true in case that the bottle could be updated, false on the contrary
            */
            public bool UpdateBottle(ENBottle bottle){

                bool updated = false;

                return updated;
            }

            /*
             * Deletes the bottle in the Data Base
             * Parameters: bottle to delete
             * Return: true in case that the bottle could be deleted, false on the contrary
            */
            public bool DeleteBottle(ENBottle bottle){

                bool deleted = false;

                return deleted;

            }

      }
}

