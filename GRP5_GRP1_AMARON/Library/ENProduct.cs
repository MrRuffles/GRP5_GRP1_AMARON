using System;

public class ENProduct{

    //Properties------------------------------------------------------------------------------------

    private string ProductName;
    public string name{

        get { return this.ProductName;  }

        set { this.ProductName = value; }

    }

    private float ProductPrice;
    public float price{

        get { return this.ProductPrice; }

        set { this.ProductPrice = value; }

    }

    private string ProductDescription;
    public string description {

        get { return this.ProductPrice;  }

        set { this.ProductDescription = value; }

    }


    //----------------------------------------------------------------------------------------------

    //Creates a default product
	public ENProduct(){

        name = "Default Name";
        price = 0.0;
        description = "This a description by default of the product.";                

	}

}//fin class ENProduct
