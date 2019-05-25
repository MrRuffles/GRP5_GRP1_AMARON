using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Library
{
    public class CADCart
    {
        private string constring;

        public CADCart()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        public bool CreateCart(ENCart cart)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "INSERT INTO Cart (userID, cod, amount, sum) values (" + cart.CartUserID + ", " + cart.CartCod + ", " + cart.CartCantidad + ", " + cart.CartSum + ");";
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

        public DataTable ReadCart(ENCart cart)
        {
            SqlConnection con = new SqlConnection(constring);

            DataSet set = new DataSet();

            SqlDataAdapter ad = new SqlDataAdapter("Select * from Cart;", con);
            ad.Fill(set, "Cart");

            DataTable tb = new DataTable();
            tb = set.Tables["Cart"];
            return tb;
        }

        public bool UpdateCart(ENCart cart)
        {
            bool updated = false;

            return updated;
        }

        public bool DeleteCart(ENCart cart)
        {
            SqlConnection con = new SqlConnection(constring);
            bool correct = true;

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("", con))
                {
                    cmd.CommandText = "Delete from Cart where userID =" + cart.CartUserID + ";";
                    cmd.ExecuteNonQuery();
      
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine("Failed operation. Error: {0}", e.Message);
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
