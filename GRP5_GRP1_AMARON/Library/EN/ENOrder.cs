using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENOrder
    {
        private int OrderUser;
        public int userID
        {
            get { return OrderUser; }
            set { OrderUser = userID; }
        }

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

        public ENOrder(int userID, string state, float cost, string date)
        {
            this.userID = userID;
            this.state = state;
            this.cost = cost;
            this.date = date;
        }

        public ENOrder()
        {
            state = "";
            cost = 0;
            date = "0/0/0";
        }

        public bool CreateOrder()
        {
            CADOrder order = new CADOrder();

            return order.CreateOrder(this);
        }

        public bool UpdateOrder()
        {
            CADOrder order = new CADOrder();

            return order.UpdateOrder(this);
        }

        public bool ReadOrder()
        {
            CADOrder order = new CADOrder();

            return order.ReadOrder(this);
        }

        public bool DeleteOrder()
        {
            CADOrder order = new CADOrder();

            return order.DeleteOrder(this);
        }
    }
}
