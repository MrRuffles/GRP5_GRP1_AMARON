using System;
using Library;


namespace Library{

      public class CADBottle{
       
            //Initializates connection string to data base
            public CADBottle() { }

            /*
             * Adds a product to the Data Base
             * Paramaters: product to create
             * Returns: true if the product could be created, false on the contrary
             */
            public bool CreateBottle(ENBottle bottle)
            {

                bool created = false;

                return created;

            }

            /*
             *Reads a bottle from Data Base
             * Parameters: bottle to read
             * Returns: true if the bottle could be read, false on the contrary
             */
            public bool ReadBottle(ENBottle bottle){

                bool read = false;

                return read;

            }

            /*
             * Updates the bottle in the DataBase
             * Parameters: bottle to update
             * Return: true in case that the bottle could be updated, false on the contrary
            */
            public bool UpdateBottle(ENBottle bottle){

                bool updated = false;

                return updated;
            }

            /*
             * Deletes the bottle in the Data Base
             * Parameters: product to delete
             * Return: true in case that the product could be deleted, false on the contrary
            */
            public bool DeleteProduct(ENProduct product)
            {

                bool deleted = false;

                return deleted;

            }

        }
    }


}

