using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENCart
    {
        private float CartSum;
        public float sum
        {
            get { return CartSum; }
            set { CartSum = value; }
        }

        public ENCart()
        {
            sum = 0;
        }
    }
}
