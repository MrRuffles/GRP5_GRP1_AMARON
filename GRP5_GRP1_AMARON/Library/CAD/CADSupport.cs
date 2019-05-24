using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    public class CADSupport
    {
        private string constring;

        public CADSupport()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        public bool createSupport(ENSupport en)
        {

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Support(Email, Name,Subject,Message) VALUES ('" + en.emailAddressPublic + "','"+ en.namePublic +"','"+ en.subjectPublic + "','" + en.textPublic +"')", c);
                com.ExecuteNonQuery();
                c.Close();
                return true;
            }
            catch(SqlException ex) {

                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                c.Close();
                return false;
            }
        }

        public bool readSupport(ENSupport en, int id)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("select * from Support where SupportId = '" + id + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.namePublic = dr["Name"].ToString();
                en.emailAddressPublic = dr["Email"].ToString();
                en.subjectPublic = dr["Subject"].ToString();
                en.textPublic = dr["Message"].ToString();

                c.Close();
                return true;
            }
            catch (SqlException ex)
            {

                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                c.Close();
                return false;
            }

        }

        public bool updateSupport(ENSupport en)
        {
            return true;

        }

        public bool deleteSupport(ENSupport en, int id)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("delete from Support where SupportId = '" + id + "'", c);
                com.ExecuteNonQuery();
                c.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                c.Close();
                return false;
            }
        }
    }
}