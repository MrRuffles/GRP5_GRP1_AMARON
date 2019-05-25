
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

            HttpCookie cookie = Request.Cookies["damncookie"];

            if (cookie == null)
            {
                //Rating
                 RatingLabel.Visible = false;
                 UpdatePanel1.Visible = false;

                //Comments
                CommentLabel.Visible = false;
                CommentTextBox.Visible = false;

                //Boton send Rating
                SendRating.Visible = false;
            }

            ENProduct product = new ENProduct(0, "", 0.0F, 0, "", "", "", "");
            ENBottle bottle = new ENBottle();

            product.id = Convert.ToInt32(Request.QueryString["id"]);

            if (product.ReadProductFromCatalog())
            {

                //Limt the amount to buy to the product stock
                AmountRV.MaximumValue = Convert.ToString(product.stock);
                AmountRV.MinimumValue = "1";

                //Image url
                ProductImage.ImageUrl = product.url;
                //Product Name
                ProductNameLabel.Text = product.name;
                //Product price
                ProductPriceLabel.Text = product.price.ToString() + "€";
                //Brand
                ProductBrandLabel.Text = product.brand;
                //Descripción
                DescriptionTextLabel.Text = product.description;

                if (product.type == "botella")
                {

                    bottle.id = product.id;

                    if (bottle.ReadBottle())
                    {


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
                }
            }else
            {
                ENLootCrate loot = new ENLootCrate(0, "", 0.0F, "", "", "");

                loot.id = Convert.ToInt32(Request.QueryString["id"]);

                if(loot.readLootCrate()) {

                    //Hide Marca
                    MarcaLabel.Visible = false;
                    ProductBrandLabel.Visible = false;

                    //Hide choose amount
                    ProdAmount.Visible = false;
                    CantidadLabel.Visible = false;

                    //hide add to cart
                    AddCartButton.Visible = false;

                    //Show Image
                    ProductImage.ImageUrl = loot.url;

                    //Show name
                    ProductNameLabel.Text = loot.nameLootCrate;

                    //Show price
                    ProductPriceLabel.Text = Convert.ToString(loot.price);

                    //Show description
                    DescriptionTextLabel.Text = loot.descriptionLootCrate;


                }
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

        protected void SendRating_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(Request.QueryString["id"]); 
            HttpCookie cookie = Request.Cookies["damncookie"];

            ENUser user = new ENUser(0, "", "", cookie["username"], new DateTime(),  "", "", "");
            

            if (user.ReadID())
            {
                ENRatting rating = new ENRatting(productID, user.userID, CommentTextBox.Text, ratingStars.CurrentRating);

                if (rating.createRatting()){

                    RatingSavedLabel.Visible = true;

                }

            }


        }
    }

 

}//end namespace

