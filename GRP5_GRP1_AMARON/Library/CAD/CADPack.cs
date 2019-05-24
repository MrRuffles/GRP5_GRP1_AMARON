using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Library
{
    class CADPack
    {
        private string constring;
        public CADPack()
        {

        }

        public bool createPack(ENPack en)
        {
            
             SqlConnection con = new SqlConnection(constring);
             bool correct = true;

             try
             {
                 con.Open();
                 using (SqlCommand cmd = new SqlCommand("", con))
                 {
                     cmd.CommandText = "INSERT INTO Product (name, pvp, stock, brand, type, urlImage) values ('" + en.namePack + "', '" + en.pricePack + "', '" + en.stockPack + "', " + en.brandPack + ", '" + en.typePack + "', '" + en.urlPack + "');";
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

        public bool readPack(ENPack en)
        {
            bool ok = true;
            return ok;
        }

        public bool updatePack(ENPack en)
        {
            bool ok = true;
            return ok;
        }

        public bool deletePack(ENPack en)
        {
            bool ok = true;
            return ok;
        }
    }
}
