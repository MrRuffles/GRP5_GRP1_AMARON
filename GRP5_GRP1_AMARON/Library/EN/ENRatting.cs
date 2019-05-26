using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENRatting
    {
        private int productID;
        private string comment;

        public int prodID
        {
            get
            {
                return this.productID;
            }
            set
            {
                productID = value;
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

        private int userID;
        public int user{

            get { return this.userID;  }
            set { this.userID = value; }
        }

        private int ratingValue;
        public int rvalue
        {
            get { return this.ratingValue; }
            set { this.ratingValue = value; }
        }
       
        public ENRatting(int pID, int uID, string comment, int rval)
        {
            this.productID = pID;
            this.userID = uID;
            this.ratingValue = rval;
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
