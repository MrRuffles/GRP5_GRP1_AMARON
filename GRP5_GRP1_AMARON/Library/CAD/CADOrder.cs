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
            bool created=true;
          
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("INSERT INTO \"Order\" (userID, state, cost, date) VALUES (" + order.userID + ",'" + order.state + "', " + order.cost + ", '" + order.date.ToString("yyyy-MM-dd") + "')", c);
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


            return created;
        }

        public bool ReadOrder(ENOrder order)
        {
            bool readed = true;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Order where userID='" + order.userID + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    order.userID = int.Parse(dr["userID"].ToString());
                    order.state = dr["state"].ToString();
                    order.cost = float.Parse(dr["cost"].ToString());
                    order.date = (DateTime) dr["date"];
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

            return readed;
        }

        public bool UpdateOrder(ENOrder order)
        {
            bool updated = false;

            return updated;
        }

        public bool DeleteOrder(ENOrder order)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("delete from Order where userID= '" + order.userID + "'", c);
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
