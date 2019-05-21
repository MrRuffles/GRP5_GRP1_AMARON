//Tamara Elizabeth Salcedo Peinado, 75944876A

using System;
using System.Data;
//using Library.CADProduct;


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

        private string ProductType;
        public string type
        {

            get { return this.ProductType; }

            set { this.ProductType = value; }

        }

        private string ProductDescription;
        public string description
        {

            get { return this.ProductDescription; }

            set { this.ProductDescription = value; }

        }

        private string ProductUrl;
        public string url
        {

            get { return this.ProductUrl; }

            set { this.ProductUrl = value; }

        }

        private CADProduct prodCAD = new CADProduct();


        //----------------------------------------------------------------------------------------------

        /*
         * Creates a default product except for the id
         * Pameter: the id given for the product
         */
        public ENProduct(){

            name = "Default Name";
            price = 0.0F;
            stock = 0;
            description = "This a description by default of the product.";
        }

        //Creates a products with the values that receives in the parameters
        public ENProduct(string name, float price, int stock, string type ,string description, string url){

            this.name = name;
            this.price = price;
            this.stock = stock;
            this.type = type;
            this.description = description;
            this.url = url;
        }

        /*
         * Creates the product in the DataBase
         * Return: true in case that the product could be created, false on the contrary
        */
        public bool CreateProduct(){

            bool created = false;

            created = prodCAD.CreateProduct(this);

            return created;

        }

        /*
         * Reads the product from the data base
         * Return: true in case that the product could be updated, false on the contrary
        */
        public DataTable ReadProductCat(){

            DataTable read = prodCAD.ReadProductCat(this);

            return read;
        }

        /*
         * Updates the product's data in the db
         * Return: true in case that the bottle could be updated, false on the contrary
        */
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