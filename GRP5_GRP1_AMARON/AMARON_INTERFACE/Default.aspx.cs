using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace AMARON_INTERFACE
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            ENLootCrate loot = new ENLootCrate(0, "", 0.0F, "", Image5.ImageUrl.ToString(), "Lootcrate");

            if (loot.readLootCrate())
            {

                Response.Redirect("Product.aspx?id=" + loot.id);
            }

            
        }

        protected void l1_Click(object sender, EventArgs e)
        {

        }

        protected void l2_Click(object sender, EventArgs e)
        {

        }

        protected void l3_Click(object sender, EventArgs e)
        {

        }
    }
}