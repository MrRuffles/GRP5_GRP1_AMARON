using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    public class CADRatting
    {
        private string constring;

        public CADRatting()
        {
            constring = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
        }

        public bool createRatting(ENRatting en)
        {
            bool correct = true;

            return correct;

        }

        public bool readRatting(ENRatting en)
        {
            bool correct = true;
            

            return correct;

        }

        public bool updateRatting(ENRatting en)
        {
            bool correct = true;

            return correct;

        }

        public bool deleteRatting(ENRatting en)
        {
            bool correct = false;

            return correct;
        }
    }
}
