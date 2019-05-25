
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace AMARON_INTERFACE
{

    public partial class Product : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {


            ENProduct product = new ENProduct(0, "", 0.00F, 0, "", "", "", "");
            ENBottle bottle = new ENBottle();

            if (product.ReadProduct()) {

                if (product.type == "botella") {

                    if (bottle.ReadBottle()) {

                        //Volume
                        ProductVolumeLabel1.Visible = true;
                        ProductVolumeLabel2.Visible = true;
                        ProductVolumeLabel2.Text = bottle.volume.ToString() + " mL";

                        //Gradde
                        ProductGradeLabel1.Visible = true;
                        ProductGradeLabel2.Visible = true;
                        ProductGradeLabel2.Text = bottle.grade.ToString() + " %";

                        //Alcoholic Type
                        AlcoholTypeLabel1.Visible = true;
                        AlcoholTypeLabel2.Visible = true;
                        AlcoholTypeLabel2.Text = bottle.alcoholicType;

                    }


                }

                //Image url
                ProductImage.ImageUrl = product.url;
                //Product Name
                ProductNameLabel.Text = product.name;
                //Product price
                ProductPriceLabel.Text = product.price.ToString() + "€";
                //Amount to buy

                //

            }
        }//end page load

        protected void AddCartButton_Click(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["damncookie"];

            if (cookie != null){

                Response.Redirect("Cart.aspx");

            }

        }

    }

 

}//end namespace

