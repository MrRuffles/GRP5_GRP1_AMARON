using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENOrder
    {

        private string OrderState;
        public string state
        {
            get { return OrderState; }
            set { OrderState = value; }
        }

        private float OrderCost;
        public float cost
        {
            get { return OrderCost; }
            set { OrderCost = value; }
        }

        private string OrderDate;
        public string date
        {
            get { return OrderDate; }
            set { OrderDate = value; }
        }

        public ENOrder()
        {
            state = "";
            cost = 0;
            date = "0/0/0";
        }
    }
}
