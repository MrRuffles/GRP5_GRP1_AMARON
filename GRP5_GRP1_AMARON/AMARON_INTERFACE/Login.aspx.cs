using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AMARON_INTERFACE
{
    public partial class Login : System.Web.UI.Page
    {
        string uemail = "admin@admin";
        string pass = "password";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void login_button_Click(object sender, EventArgs e)
        {
            
            // 1st compare email and password and validate it.
            if (login_email.Text == uemail && login_password.Text == pass)
            {
                HttpCookie cookie = new HttpCookie("damncookie");
                // 2nd create persistent cookie to store user information.
                cookie["username"] = login_email.Text;
                cookie["password"] = login_password.Text;
                cookie.Expires = DateTime.Now.AddHours(1);
                Response.Cookies.Add(cookie);
                Response.Redirect("Default.aspx");
            }
            else
            {

            }
        }
    }
}