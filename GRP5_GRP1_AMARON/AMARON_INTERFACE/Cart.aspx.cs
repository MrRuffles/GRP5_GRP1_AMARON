using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AMARON_INTERFACE
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(GridView1.Rows.Count == 0)
            {
                Button.Enabled = false;
            }
        }

        protected void Button_FinCompra(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }
    }
}