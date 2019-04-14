//Paula Guadalajara Saiz

using System;
using System.Configuration;

namespace Library
{

    public class CADProvider
    {

        private string constring;

        /**  Initializes connection string to data base  **/
        public CADProvider()
        {
            constring = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
        }

        /**  Adds a new provider to data base  **/
        public bool CreateProvider(ENProvider provider)
        {
            return false;
        }

        /**  Reads a provider from data base  **/
        public bool ReadProvider(ENProvider provider)
        {
            return false;
        }

        /** Updates a provider from data base **/
        public bool UpdateProvider(ENProvider provider)
        {
            return false;
        }

        /**  Deletes a provider from data base  **/
        public bool DeleteProvider(ENProvider provider)
        {
            return false;
        }
    }
}
