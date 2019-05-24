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

        private DateTime OrderDate;
        public DateTime date
        {
            get { return OrderDate; }
            set { OrderDate = value; }
        }

        public ENOrder(int userID, string state, float cost, DateTime date)
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
            date = DateTime.Now;
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
