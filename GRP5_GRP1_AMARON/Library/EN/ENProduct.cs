//Tamara Elizabeth Salcedo Peinado, 75944876A

using System;
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

        private string ProductBrand;
        public string brand{

            get {  return this.ProductBrand;  }

            set { this.ProductBrand = value;  }

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
         * Creates a default product
         */
        public ENProduct(){

            name = "Default Name";
            price = 0.0F;
            stock = 0;
            brand = "Deafult brand";
            type = "miscelanea";
            description = "This a description by default of the product.";
            url = "";
        }

        //Creates a products with the values that receives in the parameters
        public ENProduct(int id, string name, float price, int stock, string brand, string type, string description, string url)
        {

            this.name = name;
            this.price = price;
            this.stock = stock;
            this.brand = brand;
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
        public bool ReadProduct(){

            bool read = false;

            read = prodCAD.ReadProduct(this);

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