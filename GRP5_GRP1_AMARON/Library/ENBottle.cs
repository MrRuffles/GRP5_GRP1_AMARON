using System;

public class ENBottle : ENProduct{ 

    enum AlcoholType{

        NonAlcoholic,
        Gin,
        Rum,
        Whisky,
        Vodka,
        Liquor,
        Tequila,
        Wine,
        Beer,
        Cider,
        Champagne,
        Other
    }


    //Properties--------------------------------------------------------------------------

    private float BottleGrade;
    public float grade{

        get { return this.BottleGrade; }

        //Set the bottle's grade in a range between 0 and 100
        set {

            if (value > 100.0){

                grade = 100.0;

            }else if (value < 0.0){

                grade = 0.0;

            }else{

                this.grade = value;
            }

        }

    }

    private float BottleVolume;
    public float volume{

        get { return this.BottleVolumen; }

        //Controls that the volumen is not 0
        set{

            if (value < 0.0){

                this.BottleVolume = 0.0;

            } else{

                this.BottleVolume = value;
            }
        }

    }

    private AlcoholType Bottletype;
    public AlcoholType type{
        
        get { return this.Bottletype; }

        set{

            bool correctType = false;

            foreach (AlcoholType typeaux in AlcoholType){

                if(value == typeaux){

                    this.Bottletype = value;
                    correctType = true;

                }

            }

            if (!correctType) {

                this.BottleType = AlcoholType.Other;
            }
        }
    }

    //------------------------------------------------------------------------------------

    //Creates a bottle by default
    public ENBottle(){

        this.grade = 0.0;
        this.volume = 0.0;
        this.type = AlcoholType.Other;

	}

    //Creates a bottle with values given in the params
    public ENBottle(float grade, float volume, AlcoholType type){

        this.grade = grade;
        this.volume = volume;
        this.type = type;

    }



}//End Class ENBottle
