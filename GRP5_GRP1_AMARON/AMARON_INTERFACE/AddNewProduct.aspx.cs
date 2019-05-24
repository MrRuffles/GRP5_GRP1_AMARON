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
    public partial class AddNewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddP_Click(object sender, EventArgs e)
        {
            HttpPostedFile file = pictureUpload.PostedFile;
            string url = "";
            //check file was submitted
            if (file != null && file.ContentLength > 0)
            {
                string fname = Path.GetFileName(file.FileName);
                url = Path.Combine("~/Imagenes/", fname);
                file.SaveAs(Server.MapPath(url));
            }
            else
            {
                url = "~/Imagenes/fotoPerfil.jpg";
            }

            ENProduct prod = new ENProduct(0,"",0.0F,0,"","","",url);

            if (NewProdTYPRTB.Text == "Botella") { 
                ENBottle bot = new ENBottle();
            }
            prod.name = NewProNameTB.Text;
            prod.stock = Convert.ToInt32(NewProdStockTB.Text);
            prod.type = NewProdTYPRTB.Text;
            prod.price = Convert.ToInt32(NewProdPriceTB.Text);
            prod.brand = NewProdMarca.Text;

            if (prod.CreateProduct())
            {
                Response.Redirect("Catalog.aspx");
            }


        }
    }
}