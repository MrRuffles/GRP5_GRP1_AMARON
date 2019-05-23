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

            ENProduct prod = new ENProduct();

            if (NewProdTYPRTB.Text == "Botella") { 
                ENBottle bot = new ENBottle();
            }
        }
    }
}