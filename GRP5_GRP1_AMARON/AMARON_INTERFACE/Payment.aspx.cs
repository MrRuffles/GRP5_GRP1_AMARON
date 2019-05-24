using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Globalization;
using System.Security.Cryptography;
using System.Data;

namespace AMARON_INTERFACE
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];

            if(cookie != null)
            {
                ENUser user = new ENUser("", "",cookie["username"],0,"","","");
                if (user.ReadUserPerfil())
                {
                    Direccion.Text = user.address;

                }
                ENCart cart = new ENCart(0,0,0.0F,0);
                DataTable table = cart.ReadCart();
                float paga = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    paga = Convert.ToInt32(table.Rows[i][3].ToString()) * Convert.ToInt32(table.Rows[i][4]) + paga;
                    
                }

                TotalPrice.Text = Convert.ToString(paga) + "€";

            }
            

        }
        protected void Button_ChangeDir(object sender, EventArgs e)
        {
            Response.Redirect("EditarPerfil.aspx");
        }

        protected void Button_FinCompra(object sender, EventArgs e)
        {
            if (check_caducidad())
            {
                ENUser user = new ENUser(0, "", "", "", 0, "", "", "");

                Response.Redirect("Default.aspx");
            }

        }

        protected bool check_caducidad()
        {

            int year = Convert.ToInt32(AnoCad.Text);
            int month = Convert.ToInt32(MesCad.Text);

            if (month > 1 && month < 12)
            {
                Error_Fecha.Visible = false;

                if (year < DateTime.Now.Year)
                {
                    Error_Caducidad.Visible = true;
                    return false;

                }
                else if (year == DateTime.Now.Year && month < DateTime.Now.Month)
                {
                    Error_Caducidad.Visible = true;
                    return false;

                }
                else
                {
                    Error_Caducidad.Visible = false;
                    return true;
                }
                
            }
            else
            {
                Error_Fecha.Visible = true;
                Error_Caducidad.Visible = false;
                return false;
            }
        }
    }
}