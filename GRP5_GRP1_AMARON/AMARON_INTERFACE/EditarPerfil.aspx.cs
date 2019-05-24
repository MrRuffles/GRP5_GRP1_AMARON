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
    public partial class EditarPerfil : System.Web.UI.Page
    {

        string passw = "";
        string nameText = "";
        string url = "";
        string addressText = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];

            if (cookie != null)
            {
                ENUser user = new ENUser("", "", cookie["username"], 0, "", "", "");

                if (user.ReadUserEDPerfil())
                {
                    nameText = user.name;
                    addressText = user.address;
                    img.ImageUrl = user.url;
                    url = user.url;
                    passw = user.pass;
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpPostedFile file = pictureUpload.PostedFile;
            HttpCookie cookie = Request.Cookies["damncookie"];

            if (file != null && file.ContentLength > 0)
            {
                string fname = Path.GetFileName(file.FileName);
                url = Path.Combine("~/Imagenes/Users/", fname);
                file.SaveAs(Server.MapPath(url));
            }

            ENUser user = new ENUser();
            if (name.Text=="")
            {
                user.name = nameText;
            }
            else
            {
                user.name = name.Text;
            }
            if (pass.Text == "")
            {
                user.pass = passw;
            }
            else
            {
                user.pass = pass.Text;
            }

            user.url = url;

            if (address.Text == "")
            {
                user.address = addressText;
            }
            else
            {
                user.address = address.Text;
            }
            

            user.email = cookie["username"];

            if (user.UpdateUser())
            {
                Response.Redirect("Perfil.aspx?ok="+name.Text);
            }
        }
    }

        
    }