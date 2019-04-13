using System;

namespace Library{

    public class CADProduct{

        //Initializates connection string to data base
        public CADProduct() { }

        /*
         * Adds a product to the Data Base
         * Paramaters: product to create
         * Returns: true if the product could be created
         */
        public bool CreateProduct(ENProduct product) { }

        /*
         *Reads a product from Data Base
         * Parameters: product to read
         * Returns: true if the product could be read
         */
        public bool ReadProduct(ENProduct product)
        {
            bool read = false;

            return read;

        }

        /*
         * Updates the product in the DataBase
         * Parameters: product to update
         * Return: true in case that the product could be updated
        */
        public bool UpdateProduct(ENProduct product)
        {
            bool updated = false;

            return updated;
        }

    }//End class CADProduct



}
