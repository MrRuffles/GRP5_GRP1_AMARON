using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    class CADLootCrate
    {
        private string constring;

        public CADLootCrate()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        public bool createLootCrate(ENLootCrate loot)
        {
            return true;
        }

        public bool readLootCrate(ENLootCrate loot)
        {
            bool ok = true;


            SqlConnection conection = new SqlConnection(constring);

            try
            {

                conection.Open();

                using (SqlCommand cmd = new SqlCommand("", conection))
                {

                    cmd.CommandText = "SELECT * FROM Lootcrates where urlImage = '" + loot.url + "';";

                    SqlDataReader lootcrateRead = cmd.ExecuteReader();

                    while (lootcrateRead.Read())
                    {
                        loot.id = Convert.ToInt32(lootcrateRead[0]);
                        loot.nameLootCrate = Convert.ToString(lootcrateRead[1]);
                        loot.price = float.Parse(Convert.ToString(lootcrateRead[2]));
                        loot.descriptionLootCrate=Convert.ToString(lootcrateRead[3]);
                        loot.type = Convert.ToString(lootcrateRead[5]);
                    }

                    lootcrateRead.Close();

                }


            }
            catch (SqlException Ex)
            {

                Console.WriteLine("No se ha podido recuperar el producto de la base de datos.", Ex.Message);
                ok = false;

            }
            finally
            {

                conection.Close();
            }

            return ok;
        }

        public bool readLootCrateID(ENLootCrate loot)
        {
            bool ok = true;


            SqlConnection conection = new SqlConnection(constring);

            try
            {

                conection.Open();

                using (SqlCommand cmd = new SqlCommand("", conection))
                {

                    cmd.CommandText = "SELECT * FROM Lootcrates where cod = '" + loot.id + "';";

                    SqlDataReader lootcrateRead = cmd.ExecuteReader();

                    while (lootcrateRead.Read())
                    {
                        
                        loot.nameLootCrate = Convert.ToString(lootcrateRead[1]);
                        loot.price = float.Parse(Convert.ToString(lootcrateRead[2]));
                        loot.descriptionLootCrate = Convert.ToString(lootcrateRead[3]);
                        loot.url = Convert.ToString(lootcrateRead[4]);
                        loot.type = Convert.ToString(lootcrateRead[5]);
                    }

                    lootcrateRead.Close();

                }


            }
            catch (SqlException Ex)
            {

                Console.WriteLine("No se ha podido recuperar el producto de la base de datos.", Ex.Message);
                ok = false;

            }
            finally
            {

                conection.Close();
            }

            return ok;
        }

        public bool updateLootCrate(ENLootCrate loot)
        {
            bool ok = true;
            return ok;
        }

        public bool deleteLootCrate(ENLootCrate loot)
        {
            bool ok = true;
            return ok;
        }
    }
}
