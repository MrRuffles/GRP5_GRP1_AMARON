using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Security.Cryptography;

namespace AMARON_INTERFACE
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void ClearBoxes()
        {
            Label_Main.Text = "";
            Label_Main.Visible = false;
            Label_Sending_Success.Visible = false;
            Label_Sending_Error.Visible = false;
            Error_Birth.Text= "Debes ser mayor de 18 años";
            Error_Birth.Visible = false;
            Error_email.Visible = false;
            Label_Duplicate_Error.Visible = false;
        }
        protected void Button_register_click(object sender, EventArgs e)
        {
            bool duplicate = EmailExist();
            DateTime BirthDate = DateTime.ParseExact(tb_birth.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            ClearBoxes();
            if(check_age(BirthDate) && !duplicate )
            {
                HttpPostedFile file = pictureUpload.PostedFile;
                string url = "";
                //check file was submitted
                if (file != null && file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    url = Path.Combine("~/Imagenes/Users/", fname);
                    file.SaveAs(Server.MapPath(url));
                }
                else {
                    url = "~/Imagenes/fotoPerfil.jpg";
                }

                byte[] salt;

                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                var pb = new Rfc2898DeriveBytes(tb_password.Text, salt, 1000);

                byte[] hash = pb.GetBytes(20);

                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                string passw = Convert.ToBase64String(hashBytes);

                //Create user with given info.
                if (tb_empresa.Text == "")
                {
                    ENUser user = new ENUser(0,tb_name.Text, passw, tb_email.Text, BirthDate, url, tb_empresa.Text, tb_delivery_address.Text);

                    if (user.CreateUser())
                    {
                        Label_Sending_Success.Visible = true;
                    }
                    else
                    {
                        Label_Sending_Error.Visible = true;
                    }
                }
                else
                {
                    ENProvider prov = new ENProvider(tb_name.Text, passw, tb_email.Text, BirthDate, url, tb_empresa.Text, tb_delivery_address.Text);

                    if (prov.CreateProvider())
                    {
                        Label_Sending_Success.Visible = true;
                    }
                    else
                    {
                        Label_Sending_Error.Visible = true;
                    }
                }
            }else if (duplicate)
            {
                Label_Duplicate_Error.Visible = true;
            }
        }
        protected bool check_age(DateTime tempDate)
        {
            CultureInfo culture = new CultureInfo("");
            DateTime nowDate = DateTime.Now;
            int years = Convert.ToInt32(nowDate.Subtract(tempDate).TotalDays) / 365;
            
            if (years < 18) {
                Error_Birth.Visible = true;
                return false;
            }
            else
            {
                if(years > 200)
                {
                    Error_Birth.Text = "Introduce una edad válida";
                    Error_Birth.Visible = true;
                    return false;
                }
                else
                {
                    Error_Birth.Visible = false;
                    return true;
                }
            }
        }
        protected bool EmailExist()
        {
            ENUser user = new ENUser();
            user.email = tb_email.Text;
            if (user.EmailExist())
                return true;
            return false;
        }
    }
}