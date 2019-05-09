using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace AMARON_INTERFACE
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];
            if (cookie != null)
            {
                
                login_menu_button.Visible = false;
                register_menu_button.Visible = false;
                menu_logoff.Visible = true;
                username_menu_label.Visible = true;
                //username_menu_label.Text = Response.Cookies["authcookie"]["username"];
                username_menu_label.Text = cookie["username"];

            }
            else
            {
                login_menu_button.Visible = true;
                register_menu_button.Visible = true;
                menu_logoff.Visible = false;
                username_menu_label.Visible = false;
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
        protected void ImageButtonHeader_Click(object sender, ImageClickEventArgs e)
        {
            //if (Page.IsValid)
            //{
                Response.Redirect("Perfil.aspx");
            //}
        }
    }
}