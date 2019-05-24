using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{

    public class CADOrder
    {
        private string constring;
        public CADOrder()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }




        public bool CreateOrder(ENOrder order)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert into Order(userID, state, cost, date) VALUES (" + order.userID + "'" + order.state + "', " + order.cost + ", '" + order.date + "')", c);
                com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
            return true;
        }




        public bool ReadOrder(ENOrder order)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Order where userID='" + order.userID + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    order.state = dr["state"].ToString();
                    order.cost = float.Parse(dr["cost"].ToString());
                    order.date = dr["date"].ToString();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
            return true;
        }





        public bool UpdateOrder(ENOrder order)
        {
            return true;
        }





        public bool DeleteOrder(ENOrder order)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("delete from Order where OrderNum= '" + 5 + "'", c);
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
            return true;
        }
    }
}
