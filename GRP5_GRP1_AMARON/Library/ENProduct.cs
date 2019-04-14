//Tamara Elizabeth Salcedo Peinado, 75944876A

using System;
using Library.CADProduct;


namespace Library {


    public class ENProduct{

        //Properties------------------------------------------------------------------------------------


        private int ProductID;
        public int id{

            get { return this.ProductID; }

            set { ProductID = value; }

        }


        private string ProductName;
        public string name{

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

        private CADProduct prodCAD = new CADProduct();


        //----------------------------------------------------------------------------------------------

        /*
         * Creates a default product except for the id
         * Pameter: the id given for the product
         */
        public ENProduct(int id){

            this.id = id;
            name = "Default Name";
            price = 0.0;
            stock = 0;
            description = "This a description by default of the product.";
        }

        //Creates a products with the values that recives in the parameters
        public ENProduct(int id, string name, float price, int stock, string description){

            this.id = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.description = description;
        }

        /*
         * Updates the product in the DataBase
         * Parameters: product to update
         * Return: true in case that the product could be updated
        */
        public bool CreateProduct(){

            bool created = false;

            created = prodCAD.CreateProduct();

            return created;

        }

        //Reads the product from the data base
        public bool ReadProduct(){

            bool read = false;
            read = prodCAD.ReadProduct(this);

            return read;
        }

        //Updates the product's data in the db
        public bool UpdateProduct(){

            bool updated = false;

            updated = prodCAD.UpdateProduct(this);

            return updated;
            
        }

        //Deletes the product from de data base
        public bool DeleteProduct(){

            bool deleted = false;

            deleted = prodCAD.DeleteProduct(this);

            return deleted;

        }


    }//end class ENProduct


}//end namespace