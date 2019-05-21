using Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AMARON_INTERFACE
{
    public partial class Catalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENProduct prod = new ENProduct("",0.00F,0,"","","");
            //ENBottle bot = new ENBottle(0F,0.0F,);

            DataTable t = prod.ReadProductCat();

            //t.Rows[0][6].ToString();
            //string d=t.Rows[0][1].ToString() + " " + t.Rows[0]["stock"].ToString() + " ml.";
            

            foreach (DataRow row in t.Rows)
            {
                /*ImageButton i = new ImageButton
                {
                    ID = "Image" + row[0],
                    ImageUrl = row[6].ToString()
                };*/
                Image5.ImageUrl = row[6].ToString();

            }
        }
    }
}