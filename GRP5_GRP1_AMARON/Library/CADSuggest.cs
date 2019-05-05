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
            //constring = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
        }

        public bool createSuggest(ENSuggest en)
        {

            return true;

        }

        public bool readSuggest(ENSuggest en)
        {
            return true;

        }

        public bool updateSuggest(ENSuggest en)
        {
            return true;

        }

        public bool deleteSuggest(ENSuggest en)
        {

            return true;
        }
    }
}