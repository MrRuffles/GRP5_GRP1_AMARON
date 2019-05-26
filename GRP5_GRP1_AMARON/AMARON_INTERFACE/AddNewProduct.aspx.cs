using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;


namespace AMARON_INTERFACE
{
    public partial class AddNewProduct : System.Web.UI.Page{

        protected void Page_Load(object sender, EventArgs e){

            ProductCreatedLabel.Visible = false;

            //Control Volume range values
            NewProdVolumeRV.MaximumValue = "999999999999999999999999.99999999999999";
            NewProdVolumeRV.MinimumValue = "0.0";

            //Control Grade range values
            NewProdGradeRV.MaximumValue = "100.00";
            NewProdGradeRV.MinimumValue = "0.0";

            //Control price range values
            NewProdPriceRV.MaximumValue = "999999999999999999999999.99999999999999";
            NewProdPriceRV.MinimumValue = "0.0";

            //Control stock values
            NewProdStockRV.MaximumValue = "999999999999999999999999.99999999999999";
            NewProdStockRV.MinimumValue = "1";


        }

        protected void addProductBT_Click(object sender, EventArgs e){

            ENProduct newProduct = new ENProduct(0, "", 0.00F, 0, "", "", "", "");
            float bottleGrade = 0.0F, bottleVolume = 0.0F;
            string bottleType = "";
            int productCod = 0;
            
            //para la url de la imagen
            HttpPostedFile file = pictureUpload.PostedFile;
            string url = "";

            //check file was submitted
            if (file != null && file.ContentLength > 0){

                string fname = Path.GetFileName(file.FileName);
                url = Path.Combine("~/Imagenes/", fname);
                file.SaveAs(Server.MapPath(url));

            }else{
                url = "~/Imagenes/fotoPerfil.jpg";
            }

           try {
                
                //Get product properties
                newProduct.price = float.Parse(NewProdPriceTB.Text); //Puede dar excepcion
                newProduct.name = NewProdNameTB.Text;
                newProduct.brand = NewProdBrandTB.Text;
                newProduct.stock = Convert.ToInt32(NewProdStockTB.Text);
                newProduct.url = url;

                //Item[0] -> Botella Alcohol, Item[1] -> Miscelanea
                if (ProdTypeDropDown.Items[0].Selected){

                    newProduct.type = "botella";

                }else if (ProdTypeDropDown.Items[1].Selected){

                    newProduct.type = "miscelanea";

                }else if (ProdTypeDropDown.Items[2].Selected){

                    newProduct.type = "pack";

                }

                //In case the description is not empty
                if (NewProdDescriptionTB.Text != ""){

                    newProduct.description = NewProdDescriptionTB.Text;

                }else{

                    newProduct.description = "Este producto aún tiene una descripción";
                }

                                
                //When the product type is "miscelanea" or "pack"
                if (ProdTypeDropDown.Items[1].Selected || ProdTypeDropDown.Items[2].Selected)
                {
                    if (ProdTypeDropDown.Items[2].Selected)
                    {
                        ENPack pack = new ENPack(newProduct.name, newProduct.price, newProduct.description, newProduct.url, newProduct.stock, newProduct.brand);

                        if (pack.createPack())
                        {

                            ProductCreatedLabel.Visible = true;

                        }
                        else
                        {

                            ErrorCreatingProductLabel.Visible = true;

                        }
                    }
                    else {

                        if (newProduct.CreateProduct()) {

                            ProductCreatedLabel.Visible = true;

                        } else {

                            ErrorCreatingProductLabel.Visible = true;

                        }
                    }
                    
                //product type is "botella"
                }else if (ProdTypeDropDown.Items[0].Selected){

                    //Los parse pueden dar excepciones
                    bottleGrade = float.Parse(NewProdGradeTB.Text);
                    bottleVolume = float.Parse(NewProdVolumeTB.Text);
                    bottleType = AlcoholicTypeDropDown.Text;

                    if (newProduct.CreateProduct()){ //Create base product

                        if (newProduct.ReadProductName()){

                            productCod = newProduct.id;
                            ENBottle newBottle = new ENBottle(productCod, bottleGrade, bottleVolume, bottleType);

                            if (newBottle.CreateBottle()){ //Create bottle

                                ProductCreatedLabel.Visible = true;
                                ErrorCreatingProductLabel.Visible = false;
                            }

                        }else{

                            ErrorCreatingProductLabel.Visible = true;
                            ProductCreatedLabel.Visible = false;
                        }
                    }

                }else{

                    ErrorCreatingProductLabel.Visible = true;
                    ProductCreatedLabel.Visible = true;
                }


            }catch(Exception Ex){
                Console.WriteLine("Se ha introducido texto en un campo destinao a ser númerico. ", Ex.Message);

                if (ProdTypeDropDown.Items[1].Selected) {
                    ConvertErrorLabel.Visible = true;
                    NewProdPriceTB.BorderColor = System.Drawing.Color.Red;

                } else if(ProdTypeDropDown.Items[0].Selected){
                    ConvertErrorLabel.Visible = true;
                    NewProdPriceTB.BorderColor = System.Drawing.Color.Red;
                    NewProdGradeTB.BorderColor = System.Drawing.Color.Red;
                    NewProdVolumeTB.BorderColor = System.Drawing.Color.Red;
                }
                

            }
            
        }

        protected void ProdTypeDropDown_SelectedIndexChanged(object sender, EventArgs e){

            //If bottle is selected, hide add bottle options                    
            if (ProdTypeDropDown.Items[0].Selected){

                //Alcoholic type
                AlcoholicTypeLabel.Visible = true;
                AlcoholicTypeDropDown.Visible = true;

                //Bottle 
                NewProdVolumeLabel.Visible = true;
                NewProdVolumeTB.Visible = true;

                //Grade
                NewProdGradeLabel.Visible = true;
                NewProdGradeTB.Visible = true;


            }else {

                //Alcoholic type
                AlcoholicTypeLabel.Visible = false;
                AlcoholicTypeDropDown.Visible = false;

                //Bottle 
                NewProdVolumeLabel.Visible = false;
                NewProdVolumeTB.Visible = false;

                //Grade
                NewProdGradeLabel.Visible = false;
                NewProdGradeTB.Visible = false;

            }

        }
    }
}