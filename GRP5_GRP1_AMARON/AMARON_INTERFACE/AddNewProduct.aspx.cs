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

        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        protected void addProductBT_Click(object sender, EventArgs e)
        {

             ENProduct newProduct = new ENProduct(0, "", 0.00F, 0, "", "", "", "");

            float bottleGrade = 0.0F;
            float bottleVolume = 0.0F;
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
                
                newProduct.price = float.Parse(NewProdPriceTB.Text); //Puede dar excepcion

                pruebaPrice.Text = float.Parse(NewProdPriceTB.Text).ToString();

                newProduct.name = NewProdNameTB.Text;
                newProduct.brand = NewProdBrandTB.Text;
                newProduct.stock = Convert.ToInt32(NewProdStockTB.Text);
                newProduct.url = url;

                //Item[0] -> Botella Alcohol, Item[1] -> Miscelanea
                if (ProdTypeDropDown.Items[0].Selected){

                    newProduct.type = "botella";

                }else if (ProdTypeDropDown.Items[1].Selected){

                    newProduct.type = "miscelanea";

                }


                //In case the descriptión is not empty
                if (NewProdDescriptionTB.Text != ""){

                    newProduct.description = NewProdDescriptionTB.Text;

                }


                //For bottle 
                if (ProdTypeDropDown.Items[0].Selected){

                    //Los parse pueden dar excepciones
                    bottleGrade = float.Parse(NewProdGradeTB.Text);
                    Label1.Text = float.Parse(NewProdGradeTB.Text).ToString();
                    bottleVolume = float.Parse(NewProdVolumeTB.Text);
                    Label2.Text = float.Parse(NewProdVolumeTB.Text).ToString();
                    bottleType = AlcoholicTypeDropDown.Text;

                }

                

                if (ProdTypeDropDown.Items[1].Selected && newProduct.CreateProduct()){

                    ProductCreatedLabel.Visible = true;
                    ErrorCreatingProductLabel.Visible = false;


                }else if (ProdTypeDropDown.Items[0].Selected){

                    if (newProduct.CreateProduct()){

                        if (newProduct.ReadProduct()){

                            productCod = newProduct.id;
                            ENBottle newBottle = new ENBottle(productCod, bottleGrade, bottleVolume, bottleType);

                            if (newBottle.CreateBottle()){

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
                    NewProdGradeTB.BorderColor = System.Drawing.Color.Red;
                    NewProdVolumeTB.BorderColor = System.Drawing.Color.Red;
                }
                

            }
            
        }

        protected void ProdTypeDropDown_SelectedIndexChanged(object sender, EventArgs e){

            //If Miscelaneus is selected, hide add bottle options
            if(ProdTypeDropDown.Items[1].Selected){

                //Alcoholic type
                AlcoholicTypeLabel.Visible = false;
                AlcoholicTypeDropDown.Visible = false;

                //Bottle 
                NewProdVolumeLabel.Visible = false;
                NewProdVolumeTB.Visible = false;

                //Grade
                NewProdGradeLabel.Visible = false;
                NewProdGradeTB.Visible = false;


            }else if (ProdTypeDropDown.Items[0].Selected){

                //Alcoholic type
                AlcoholicTypeLabel.Visible = true;
                AlcoholicTypeDropDown.Visible = true;

                //Bottle 
                NewProdVolumeLabel.Visible = true;
                NewProdVolumeTB.Visible = true;

                //Grade
                NewProdGradeLabel.Visible = true;
                NewProdGradeTB.Visible = true;


            }
        }
    }
}