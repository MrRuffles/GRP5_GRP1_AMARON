//Paula Guadalajara Saiz

using System;
using System.Configuration;

namespace Library
{

    public class CADUser
    {

        private string constring;

        /**  Initializes connection string to data base  **/
        public CADUser()
        {
            constring = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
        }

        /**  Adds a new user to data base  **/
        public bool CreateUser(ENUser user)
        {
            return false;
        }

        /**  Reads a user from data base  **/
        public bool ReadUser(ENUser user)
        {
            return false;
        }

        /** Updates a user from data base **/
        public bool UpdateUser(ENUser user)
        {
            return false;
        }

        /**  Deletes a user from data base  **/
        public bool DeleteUser(ENUser user)
        {
            return false;
        }

    }
}
