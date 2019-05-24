using System;

namespace Library{

    public class ENBottle : ENProduct{

        
        //Properties--------------------------------------------------------------------------

        private CADBottle bottleCAD;

        private int ProductCod;
        public int cod{

            get { return this.ProductCod;  }

            set{ this.ProductCod = value;  }

        }

        private float BottleGrade;
        public float grade{

            get { return this.BottleGrade; }

            //Set the bottle's grade in a range between 0 and 100
            set{

                if (value > 100.0){

                    BottleGrade = 100.0F;

                }else if (value < 0.0){

                    BottleGrade = 0.0F;

                }else{

                    BottleGrade = value;
                }

            }

        }

        private float BottleVolume;
        public float volume{

            get { return this.BottleVolume; }

            //Controls that the volume is not 0
            set{

                if (value < 0.0) {

                    this.BottleVolume = 0.0F;

                }else{

                    this.BottleVolume = value;
                }
            }

        }

        private string Bottletype;
        public string alcoholicType{

            get { return this.Bottletype; }

            set{

                Bottletype = value;
            }
        }

        //------------------------------------------------------------------------------------

        //Creates a bottle by default
        public ENBottle(){

            this.cod = 0;
            this.grade = 0.0F;
            this.volume = 0.0F;
            this.alcoholicType = "Otro";

        }

        //Creates a bottle with values given in the params
        public ENBottle(int cod, float grade, float volume, string type){

            this.cod = cod;
            this.grade = grade;
            this.volume = volume;
            this.alcoholicType = type;

        }

        /*
          * Creates the product in the DataBase
          * Return: true in case that the product could be created, false on the contrary
         */
        public bool CreateBottle(){

            bool created = false;

            created = bottleCAD.CreateBottle(this);

            return created;
        }

        /*
        * Reads the bottle from the data base
        * Return: true in case that the product could be read, false on the contrary
        */
        public bool ReadBottle(){

            bool read = false;

            read = bottleCAD.ReadBottle(this);

            return read;
        }

        /*
         * Updates the bottle's data in the db
         * Return: true in case that the bottle could be updated, false on the contrary
        */
        public bool UpdateBottle(){

            bool updated = false;

            updated = bottleCAD.UpdateBottle(this);

            return updated;
        }

        /*
         * Deletes the bottle in the data base
         * Return: true in case that the bottle could be updated, false on the contrary
        */
        public bool DeleteBottle(){

            bool deleted = false;

            deleted = bottleCAD.DeleteBottle(this);

            return deleted;
        }



    }//End Class ENBottle

}//end namespace

