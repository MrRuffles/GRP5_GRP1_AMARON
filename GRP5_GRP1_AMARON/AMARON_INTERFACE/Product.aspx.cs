
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace AMARON_INTERFACE{
    
    public partial class Product : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {


            ENProduct product = new ENProduct(0, "", 0.0F, 0, "", "", "", "");
            ENBottle bottle = new ENBottle();

            product.id = Convert.ToInt32(Request.QueryString["id"]);

            if (product.ReadProductFromCatalog() ) {

                //Image url
                ProductImage.ImageUrl = product.url;
                //Product Name
                ProductNameLabel.Text = product.name;
                //Product price
                ProductPriceLabel.Text = product.price.ToString() + "€";
                //Brand
                ProductBrandLabel.Text = product.brand;
                //Descripción
                CommentTextLabel.Text = product.description;

                if (product.type == "botella") {

                    bottle.id = product.id;

                    if (bottle.ReadBottle()) {
                                               

                        //Volume
                        VolumenLabel.Visible = true;
                        ProductVolumeLabel.Visible = true;
                        ProductVolumeLabel.Text = bottle.volume.ToString() + " mL";

                        //Gradde
                        GradoLabel.Visible = true;
                        ProductGradeLabel.Visible = true;
                        ProductGradeLabel.Text = bottle.grade.ToString() + " %";

                        //Alcoholic Type
                        TipoDeAlcoholLabel.Visible = true;
                        ProdAlcoholTypeLabel.Visible = true;
                        ProdAlcoholTypeLabel.Text = bottle.alcoholicType;

                    }


                }//

            }
        }//end page load

        protected void AddCartButton_Click(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["damncookie"];

            if (cookie != null){

                ENProduct producto = new ENProduct(0, "", 0.0F, 0, "", "", "", "");
                ENUser usuario = new ENUser(0, "", "", cookie["username"], new DateTime(), "", "", "");
                
                producto.id = Convert.ToInt32(Request.QueryString["id"]);
                usuario.ReadID();

                if (producto.ReadProductFromCatalog()){

                    ENCart carrito = new ENCart(producto.id, usuario.userID, producto.price, Convert.ToInt32(ProdAmount.Text));

                    if (carrito.CreateCart()){

                        ProductAddedLabel.Visible = true;
                    }


                }


            }else {

                Response.Redirect("Login.aspx");
            }

        }

    }

 

}//end namespace

