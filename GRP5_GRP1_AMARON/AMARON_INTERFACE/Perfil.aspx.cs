using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;


namespace AMARON_INTERFACE
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];

            if (cookie != null)
            {
                ENUser user = new ENUser("","",cookie["username"],0,"","","");

                if (user.ReadUserPerfil())
                {
                    name.Text = user.name;
                    age.Text = Convert.ToString(user.age);
                    mail.Text = user.email;
                    address.Text = user.address;
                    if (user.empresa!="")
                    {
                        company.Visible = true;
                        company1.Text = user.empresa;
                    }
                    fotoPerfil.ImageUrl = user.url;
                }
            }
        }

        protected void verPedidos(object sender, EventArgs e)
        {
            Response.Redirect("Orders.aspx");
        }

        protected void editarPerfil(object sender, EventArgs e)
        {
            Response.Redirect("EditarPerfil.aspx");
        }
    }
}