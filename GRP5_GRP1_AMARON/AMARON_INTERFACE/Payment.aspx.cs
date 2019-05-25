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
        float paga = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["damncookie"];

            if(cookie != null)
            {
                ENUser user = new ENUser(0,"", "",cookie["username"],new DateTime(),"","","");
                if (user.ReadUserPerfil())
                {
                    Direccion.Text = user.address;

                }
                ENCart cart = new ENCart(0,0,0.0F,0);
                DataTable table = cart.ReadCart();
                
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    paga = float.Parse(table.Rows[i][3].ToString()) * float.Parse(table.Rows[i][4].ToString()) + paga;
                    
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
            HttpCookie cookie = Request.Cookies["damncookie"];
            if (check_caducidad())
            {
                ENUser user = new ENUser(0,"","",cookie["username"],new DateTime(),"","","");

                if (user.ReadID())
                {
                    ENCart cart = new ENCart(0,user.userID,0.0F,0);

                    ENOrder order = new ENOrder(user.userID,"pagado",paga,DateTime.Now);
                    if (order.CreateOrder())
                    {
                        cart.DeleteCart();
                    }

                }



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