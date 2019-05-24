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
 
        public CADOrder()
        {
           
        }

        public bool CreateOrder(ENOrder order)
        {
            bool updated = false;

            return updated;
        }

        public bool ReadOrder(ENOrder order)
        {
            bool readed = false;

            return readed;
        }

        public bool UpdateOrder(ENOrder order)
        {
            bool updated = false;

            return updated;
        }

        public bool DeleteOrder(ENOrder order)
        {
            bool deleted = false;

            return deleted;
        }
    }
}
