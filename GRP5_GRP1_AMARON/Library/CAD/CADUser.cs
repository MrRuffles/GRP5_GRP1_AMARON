//Paula Guadalajara Saiz

using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Library
{

    public class CADUser
    {

        private string constring;

        /**  Initializes connection string to data base  **/
        public CADUser()
        {
            constring = ConfigurationManager.ConnectionStrings["AmaronDataBase"].ConnectionString;
        }

        /**  Adds a new user to data base  **/
        public bool CreateUser(ENUser user)
        {
            SqlConnection con = new SqlConnection(constring);
            return true;
        }

        /**  Reads a user from data base  **/
        public bool ReadUser(ENUser user)
        {
            return true;
        }

        /** Updates a user from data base **/
        public bool UpdateUser(ENUser user)
        {
            return true;
        }

        /**  Deletes a user from data base  **/
        public bool DeleteUser(ENUser user)
        {
            return true;
        }

    }
}
