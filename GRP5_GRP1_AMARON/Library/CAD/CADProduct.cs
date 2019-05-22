using System;
using System.Configuration;

namespace Library{

    public class CADProduct{

        private string constring;

        //Initializates connection string to data base
        public CADProduct(){
            constring = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
        }

        /*
         * Adds a product to the Data Base
         * Paramaters: product to create
         * Returns: true if the product could be created, false on the contrary
         */
        public bool CreateProduct(ENProduct product){

            bool created = false;

            return created;

        }

        /*
         *Reads a product from Data Base
         * Parameters: product to read
         * Returns: true if the product could be read, false on the contrary
         */
        public bool ReadProduct(ENProduct product){

            bool read = false;

            return read;

        }

        /*
         * Updates the product in the DataBase
         * Parameters: product to update
         * Return: true in case that the product could be updated
        */
        public bool UpdateProduct(ENProduct product){
            bool updated = false;

            return updated;
        }

        /*
         * Deletes the product in the Data Base
         * Parameters: product to delete
         * Return: true in case that the product could be deleted, false on the contrary
        */
        public bool DeleteProduct(ENProduct product){

            bool deleted = false;

            return deleted;

        }


    }//End class CADProduct



}
