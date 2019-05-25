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
        string email = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];

            if (cookie != null)
            {
                ENUser user = new ENUser("", "", cookie["username"], new DateTime(), "", "", "");

                if (user.ReadUserEDPerfil())
                {
                    nameText = user.name; name.Attributes.Add("placeholder",nameText);
                    addressText = user.address; address.Attributes.Add("placeholder", addressText);
                    img.ImageUrl = user.url;
                    url = user.url;
                    passw = user.pass;
                    email = user.email;
                    delete_account_label.Visible = true;
                    delete_request_button.Visible = true;
                    delete_account_button.Visible = false;
                    delete_check_label.Visible = false;
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpPostedFile file = pictureUpload.PostedFile;
            HttpCookie cookie = Request.Cookies["damncookie"];
            if (cookie != null)
            {
                if (file != null && file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    url = Path.Combine("~/Imagenes/Users/", fname);
                    file.SaveAs(Server.MapPath(url));
                }

                ENUser user = new ENUser();
                if (name.Text == "")
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
                    Response.Redirect("Perfil.aspx?ok=" + name.Text);
                }
            }
        }
        protected void Delete_Request(object sender, EventArgs e)
        {
            delete_account_label.Visible = false;
            delete_request_button.Visible = false;
            delete_account_button.Visible = true;
            delete_check_label.Visible = true;
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];
            if (cookie != null)
            {
                ENUser user = new ENUser("", "", email, new DateTime(), "", "", "");
                if (user.ReadUserEDPerfil())
                {
                    if (user.DeleteUser())
                    {

                        Response.Cookies["damncookie"].Expires = DateTime.Now.AddDays(-1);
                        Response.Redirect("Default.aspx");
                    }
                }
            }
        }
    }
}