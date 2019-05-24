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

        }

        public bool createLootCrate(ENLootCrate loot)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "INSERT INTO Product (name, pvp, stock, brand, type, urlImage) values ('" + loot.nameLootCrate + "', '" + loot.priceLootCrate + "', '" + loot.stockLootCrate + "', " + loot.brandLootCrate + ", '" + loot.typeLootCrate + "', '" + loot.urlLootCrate + "');";
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

        public bool readLootCrate(ENLootCrate loot)
        {
            bool ok = true;
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
