using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

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
            Error_Birth.Visible = false;
            Error_password.Visible = false;
            Error_email.Visible = false;
        }
        protected void Button_register_click(object sender, EventArgs e)
        {
            ClearBoxes();
            bool echeck = check_email(), pcheck = check_pass(), agecheck = check_age();
            if(echeck && pcheck && agecheck )
            {
                
                //Create user with given info.
                ENUser user = new ENUser(tb_name.Text, tb_password.Text,tb_email.Text,0,"",tb_empresa.Text, tb_delivery_address.Text);
                if (user.CreateUser())
                {
                    Label_Sending_Success.Visible = true;
                }
                else
                {
                    Label_Sending_Error.Visible = true;
                }

            }
        }
        protected bool check_pass()
        {
            if (tb_password_confirm.Text != tb_password.Text)
            {
                Error_password.Visible = true;
                return false;
            }
            else
            {
                Error_password.Visible = false;
                return true;
            }
        }
        protected bool check_email()
        {
            if (tb_email_confirm.Text != tb_email.Text)
            {
                Error_email.Visible = true;
                return false;
            }
            else
            {
                Error_email.Visible = false;
                return true;
            }
        }
        protected bool check_age()
        {
            CultureInfo culture = new CultureInfo("");
            DateTime tempDate = DateTime.ParseExact(tb_birth.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime nowDate = DateTime.Now;
            double years = nowDate.Subtract(tempDate).TotalDays / 365;
            
            if (years < 18) {
                Error_Birth.Visible = true;
                return false;
            }
            else
            {
                Error_Birth.Visible = false;
                return true;
            }
        }

        protected void btnUploadClick(object sender, EventArgs e)
        {


            HttpPostedFile file = pictureUpload.PostedFile;
            //check file was submitted
            if (file != null && file.ContentLength > 0)
            {
                string fname = Path.GetFileName(file.FileName);
                file.SaveAs(Server.MapPath(Path.Combine("~/Imagenes/Users/", fname)));
            }
        }
    }
}