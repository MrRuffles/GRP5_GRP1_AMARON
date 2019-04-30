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

        }

        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Catalog":
                    return;
                case "Contact":
                    Response.Redirect("Contact.aspx");
                    break;
            }
        }
        protected void Button_Login_click(object sender, MenuEventArgs e)
        {
            //Login 
        }
        protected void Button_Register_click(object sender, MenuEventArgs e)
        {
            //Registro
        }
        protected void Button_Logoff_click(object sender, MenuEventArgs e)
        {
            //Logoff when logged
        }

        protected void ImageButtonHeader_Click(object sender, ImageClickEventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}