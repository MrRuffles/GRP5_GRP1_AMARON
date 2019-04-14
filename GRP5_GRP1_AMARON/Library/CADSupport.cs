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
            constring = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
        }

        public bool createSupport(ENSupport en)
        {
           
            return true;

        }

        public bool readSupport(ENSupport en)
        {
            return true;

        }

        public bool updateSupport(ENSupport en)
        {
            return true;

        }

        public bool deleteSupport(ENSupport en)
        {

            return true;
        }
    }
}