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
        string comp = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];

            if (cookie != null)
            {
                ENUser user = new ENUser("", "", cookie["username"], 0, "", "", "");

                if (user.ReadUserPerfil())
                {
                    name.Text = user.name;
                    mail.Text = user.email;
                    address.Text = user.address;
                    img.ImageUrl = user.url;
                    age.Text = Convert.ToString(user.age);
                    passw = user.pass;
                    comp = user.empresa;
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpPostedFile file = pictureUpload.PostedFile;

            string url = "";
            if (file != null && file.ContentLength > 0)
            {
                string fname = Path.GetFileName(file.FileName);
                url = Path.Combine("~/Imagenes/Users/", fname);
                file.SaveAs(Server.MapPath(url));
            }

            ENUser user = new ENUser("", "", "", 0,"", "", "");

            user.name = name.Text;
            if (pass.Text == "")
            {
                user.pass = passw;
            }
            else
            {
                user.pass = pass.Text;
            }
            user.email = mail.Text;
            user.age = Convert.ToInt32(age.Text);
            if (file == null)
            {
                user.url = img.ImageUrl;
            }
            else
            {
                user.url = url;
            }
            user.address = address.Text;
            user.empresa = comp;

            if (user.UpdateUser())
            {
                Response.Redirect("Perfil.aspx");
            }
        }
    }

        
    }