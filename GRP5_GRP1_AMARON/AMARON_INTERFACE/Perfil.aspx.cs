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
                ENUser user = new ENUser(0,"","",cookie["username"], new DateTime(), "","","");
                if (user.ReadUserPerfil())
                {
                    name.Text = user.name;
                    birth.Text = user.birth.ToString("dd-MM-yyyy");
                    mail.Text = user.email;
                    address.Text = user.address;
                    if (user.empresa!="")
                    {
                        company.Visible = true;
                        company1.Text = user.empresa;
                        productos.Visible = true;
                        pedidios.Visible = false;
                    }
                    fotoPerfil.ImageUrl = user.url;
                }
            }
        }

        protected void verPedidos(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];
            ENUser user = new ENUser(0,"","",cookie["username"], new DateTime(), "","","");
            if (user.ReadID())
            {
                Response.Redirect("Orders.aspx?userID=" + user.userID);
            }
        }

        protected void editarPerfil(object sender, EventArgs e)
        {
            Response.Redirect("EditarPerfil.aspx");
        }

        protected void crearProducto(object sender, EventArgs e)
        {
            Response.Redirect("AddNewProduct.aspx");
        }
    }
}