using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Library;

namespace AMARON_INTERFACE
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected bool Proveedor(string email)
        {
            ENProvider user = new ENProvider(email);
            user.ReadProvider();
            if (user.empresa == "")
                return false;
            return true;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            cart_menu_button.Visible = false;
            HttpCookie cookie = Request.Cookies["damncookie"];
            if (cookie != null)
            {
                if (!Proveedor(cookie["username"]))
                {
                    cart_menu_button.Visible = true;
                }
                login_menu_button.Visible = false;
                register_menu_button.Visible = false;
                menu_logoff.Visible = true;
                username_menu_button.Visible = true;
                username_menu_button.Text = cookie["username"];
                ENUser u = new ENUser(0, "", "", cookie["username"], new DateTime(), "", "", "");

                if (u.ReadID())
                {
                    cart_menu_button.NavigateUrl = "Cart.aspx?userID=" + u.userID;
                }

            }
            else
            {
                login_menu_button.Visible = true;
                register_menu_button.Visible = true;
                menu_logoff.Visible = false;
                username_menu_button.Visible = false;
            }
        }
        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Home":
                    Response.Redirect("Default.aspx");
                    break;
                case "Catalog":
                    Response.Redirect("Catalog.aspx");
                    break;
                case "Contact":
                    Response.Redirect("Contact.aspx");
                    break;
                case "Cart":
                    Response.Redirect("Cart.aspx");
                    break;
            }
        }
        protected void menu_logoff_click(object sender, EventArgs e)
        {
            Response.Cookies["damncookie"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Default.aspx");
        }

        protected void username_menu_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Perfil.aspx");
        }
    }
}