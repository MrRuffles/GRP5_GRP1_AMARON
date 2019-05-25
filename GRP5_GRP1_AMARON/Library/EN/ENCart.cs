using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENCart
    {
        private float sum;
        public float CartSum
        {
            get { return sum; }
            set { sum = value; }
        }
        private int amount;
        public int CartCantidad
        {
            get { return amount; }
            set { amount = value; }
        }

        private int userID;
        public int CartUserID
        {
            get { return userID; }
            set { userID = value; }
        }
  
        private int cod;
        public int CartCod
        {
            get { return cod; }
            set { cod = value; }
        }



        public ENCart()
        {
            sum = 0;
        }
        public ENCart(int cod, int userID, float sum, int amount )
        {
            this.sum = sum;
            this.cod = cod;
            this.userID = userID;
            this.amount = amount;
        }

        public bool CreateCart()
        {
            CADCart cart = new CADCart();

            return cart.CreateCart(this);
        }

        public DataTable ReadCart()
        {
            CADCart cart = new CADCart();

            return cart.ReadCart(this);
        }

        public bool UpdateCart()
        {
            CADCart cart = new CADCart();

            return cart.UpdateCart(this);
        }

        public bool DeleteCart()
        {
            CADCart cart = new CADCart();

            return cart.DeleteCart(this);
        }
    }
}
