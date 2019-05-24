using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    public class CADSuggest
    {
        private string constring;

        public CADSuggest()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        public bool createSuggest(ENSuggest en)
        {

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Suggest(Email, Name,Subject,Message) VALUES ('" + en.emailPublic + "','" + en.namePublic + "','" + en.subjectPublic + "','" + en.textPublic + "')", c);
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

        public bool readSuggest(ENSuggest en, int id)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("select * from Suggest where SuggestId = '" + id + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.namePublic = dr["Name"].ToString();
                en.emailPublic = dr["Email"].ToString();
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

        public bool updateSuggest(ENSuggest en)
        {
            return true;
        }

        public bool deleteSuggest(ENSuggest en, int id)
        {

            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("delete from Suggest where SuggestId = " + id.ToString(), c);
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