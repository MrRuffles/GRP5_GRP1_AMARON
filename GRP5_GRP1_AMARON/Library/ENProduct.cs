//Tamara Elizabeth Salcedo Peinado, 75944876A

using System;


namespace Library {


    public class ENProduct
    {

        //Properties------------------------------------------------------------------------------------

        private string ProductName;
        public string name
        {

            get { return this.ProductName; }

            set { this.ProductName = value; }

        }

        private float ProductPrice;
        public float price
        {

            get { return this.ProductPrice; }

            set { this.ProductPrice = value; }

        }

        private int ProductStock;
        public int stock
        {

            get { return this.ProductStock; }

            set { this.ProductStock = value; }

        }

        private string ProductDescription;
        public string description
        {

            get { return this.ProductPrice; }

            set { this.ProductDescription = value; }

        }


        //----------------------------------------------------------------------------------------------

        //Creates a default product
        public ENProduct()
        {

            name = "Default Name";
            price = 0.0;
            stock = 0;
            description = "This a description by default of the product.";
        }

        //Creates a products with the values that recives in the parameters
        public ENProduct(string name, float price, int stock, string description)
        {

            this.name = name;
            this.price = price;
            this.stock = stock;
            this.description = description;
        }

        //
        public bool readProduct(){

            CADProduct prodCAD = new CADProduct();

    

        }


    }//fin class ENProduct


}//Fin namespace