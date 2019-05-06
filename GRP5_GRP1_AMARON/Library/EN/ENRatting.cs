using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENRatting
    {
        private int productValor;
        private string comment;

        public int productValorPublic
        {
            get
            {
                return productValor;
            }
            set
            {
                productValor = value;
            }
        }

        public string commentPublic
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }

        }
       
        public ENRatting(int productValor, string comment)
        {
            this.productValor = productValor;
            this.comment = comment;
        }

        public bool createRatting()
        {

            CADRatting cad = new CADRatting();

            return cad.createRatting(this);
        }

        public bool readRatting()
        {

            CADRatting cad = new CADRatting();

            return cad.readRatting(this);
        }

        public bool updateRatting()
        {
            CADRatting cad = new CADRatting();

            return cad.updateRatting(this);
        }

        public bool deleteRatting()
        {
            CADRatting cad = new CADRatting();

            return cad.deleteRatting(this);
        }
    }
}
