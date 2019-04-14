using System;
using System.Collections.Generic;
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

        public ENCart()
        {
            sum = 0;
        }
        public ENCart(float sum)
        {
            this.sum = sum;
        }

        public bool CreateCart()
        {
            CADCart cart = new CADCart();

            return cart.CreateCart(this);
        }

        public bool ReadCart()
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
