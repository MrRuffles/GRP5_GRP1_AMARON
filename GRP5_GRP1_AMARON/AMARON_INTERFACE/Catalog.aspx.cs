using Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AMARON_INTERFACE
{
    public partial class Catalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENProduct prod = new ENProduct(0,"",0.00F,0,"","","","");
            

            if (Request.QueryString["cat"] == "bottle")
            {
                DataTable t = prod.ReadProductBot();
                int cont = 0;
                for (int i = -1; i < t.Rows.Count % 3; i++)
                {
                    int obj = t.Rows.Count;
                    TableRow row = new TableRow();
                    if (obj >= 4)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            TableCell cell = new TableCell();
                            HyperLink hy = new HyperLink();
                            Image im = new Image();
                            im.ImageUrl = t.Rows[cont][7].ToString();
                            im.Height = 400;
                            im.Width = 220;
                            hy.ID = t.Rows[cont][0].ToString();
                            hy.CssClass = "card";
                            hy.Text = t.Rows[cont][1].ToString();
                            hy.NavigateUrl = "Product.aspx?id=" + hy.ID.ToString();
                            hy.Controls.Add(im);
                            cell.Controls.Add(hy);
                            row.Cells.Add(cell);
                            cont++;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < obj; j++)
                        {
                            TableCell cell = new TableCell();
                            HyperLink hy = new HyperLink();
                            Image im = new Image();
                            im.ImageUrl = t.Rows[cont][7].ToString();
                            im.Height = 400;
                            im.Width = 220;
                            hy.ID = t.Rows[cont][0].ToString();
                            hy.CssClass = "card";
                            hy.Text = t.Rows[cont][1].ToString();
                            hy.NavigateUrl = "Product.aspx?id=" + hy.ID.ToString();
                            hy.Controls.Add(im);
                            cell.Controls.Add(hy);
                            row.Cells.Add(cell);
                            cont++;
                        }
                    }
                    cat.Rows.Add(row);
                }
            }
            else if (Request.QueryString["cat"] == "packs")
            {
                DataTable t = prod.ReadProductPack();
                int cont = 0;
                for (int i = -1; i < t.Rows.Count % 3; i++)
                {
                    int obj = t.Rows.Count;
                    TableRow row = new TableRow();
                    if (obj >= 4)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            TableCell cell = new TableCell();
                            HyperLink hy = new HyperLink();
                            Image im = new Image();
                            im.ImageUrl = t.Rows[cont][7].ToString();
                            im.Height = 400;
                            im.Width = 220;
                            hy.ID = t.Rows[cont][0].ToString();
                            hy.CssClass = "card";
                            hy.Text = t.Rows[cont][1].ToString();
                            hy.NavigateUrl = "Product.aspx?id=" + hy.ID.ToString();
                            hy.Controls.Add(im);
                            cell.Controls.Add(hy);
                            row.Cells.Add(cell);
                            cont++;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < obj; j++)
                        {
                            TableCell cell = new TableCell();
                            HyperLink hy = new HyperLink();
                            Image im = new Image();
                            im.ImageUrl = t.Rows[cont][7].ToString();
                            im.Height = 400;
                            im.Width = 220;
                            hy.ID = t.Rows[cont][0].ToString();
                            hy.CssClass = "card";
                            hy.Text = t.Rows[cont][1].ToString();
                            hy.NavigateUrl = "Product.aspx?id=" + hy.ID.ToString();
                            hy.Controls.Add(im);
                            cell.Controls.Add(hy);
                            row.Cells.Add(cell);
                            cont++;
                        }
                    }
                    cat.Rows.Add(row);
                }
            }
            else if (Request.QueryString["cat"] == "misc")
            {
                DataTable t = prod.ReadProductMisc();
                int cont = 0;
                for (int i = -1; i < t.Rows.Count % 3; i++)
                {
                    int obj = t.Rows.Count;
                    TableRow row = new TableRow();
                    if (obj >= 4)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            TableCell cell = new TableCell();
                            HyperLink hy = new HyperLink();
                            Image im = new Image();
                            im.ImageUrl = t.Rows[cont][7].ToString();
                            im.Height = 400;
                            im.Width = 220;
                            hy.ID = t.Rows[cont][0].ToString();
                            hy.CssClass = "card";
                            hy.Text = t.Rows[cont][1].ToString();
                            hy.NavigateUrl = "Product.aspx?id=" + hy.ID.ToString();
                            hy.Controls.Add(im);
                            cell.Controls.Add(hy);
                            row.Cells.Add(cell);
                            cont++;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < obj; j++)
                        {
                            TableCell cell = new TableCell();
                            HyperLink hy = new HyperLink();
                            Image im = new Image();
                            im.ImageUrl = t.Rows[cont][7].ToString();
                            im.Height = 400;
                            im.Width = 220;
                            hy.ID = t.Rows[cont][0].ToString();
                            hy.CssClass = "card";
                            hy.Text = t.Rows[cont][1].ToString();
                            hy.NavigateUrl = "Product.aspx?id=" + hy.ID.ToString();
                            hy.Controls.Add(im);
                            cell.Controls.Add(hy);
                            row.Cells.Add(cell);
                            cont++;
                        }
                    }
                    cat.Rows.Add(row);
                }
            }
            else
            {

                DataTable t = prod.ReadProductCat();
                int cont = 0;
                for (int i = -1; i < t.Rows.Count % 3; i++)
                {
                    int obj = t.Rows.Count;
                    TableRow row = new TableRow();
                    if (obj >= 4)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            TableCell cell = new TableCell();
                            HyperLink hy = new HyperLink();
                            Image im = new Image();
                            im.ImageUrl = t.Rows[cont][7].ToString();
                            im.Height = 400;
                            im.Width = 220;
                            hy.ID = t.Rows[cont][0].ToString();
                            hy.CssClass = "card";
                            hy.Text = t.Rows[cont][1].ToString();
                            hy.NavigateUrl = "Product.aspx?id=" + hy.ID.ToString();
                            hy.Controls.Add(im);
                            cell.Controls.Add(hy);
                            row.Cells.Add(cell);
                            cont++;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < obj; j++)
                        {
                            TableCell cell = new TableCell();
                            HyperLink hy = new HyperLink();
                            Image im = new Image();
                            im.ImageUrl = t.Rows[cont][7].ToString();
                            im.Height = 400;
                            im.Width = 220;
                            hy.ID = t.Rows[cont][0].ToString();
                            hy.CssClass = "card";
                            hy.Text = t.Rows[cont][1].ToString();
                            hy.NavigateUrl = "Product.aspx?id=" + hy.ID.ToString();
                            hy.Controls.Add(im);
                            cell.Controls.Add(hy);
                            row.Cells.Add(cell);
                            cont++;
                        }
                    }
                    cat.Rows.Add(row);
                }
            }
        }
    }
}

//ControltoValidate(la id de lo se quiere validar) ErrorMesage Validationexpresion (dentro de regular)