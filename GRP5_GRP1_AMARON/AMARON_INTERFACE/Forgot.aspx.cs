using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
namespace AMARON_INTERFACE
{
    public partial class Forgot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            recover_email.Text = "";
        }
        private void ClearBoxes()
        {
            Label_Sending_Success.Visible = false;
            Label_Main.Text = "";
            Label_Main.Visible = false;
            Label_Finding_Error.Visible = false;
            Label_Update_Error.Visible = false;
        }
        
        protected bool SendMail(string name, string email, string data)
        {
            try
            {
                MailMessage toSend = new MailMessage
                {
                    Subject = "AMARON Recuperación de contraseña",
                    From = new MailAddress("contactformamaron@gmail.com")
                };
                toSend.To.Add(email);
                toSend.Body = "Buenas "+ name +",\n";
                toSend.Body += "Este email contiene tus nuevas credenciales. \n\n";
                toSend.Body += "Email: "+ email + "\n";
                toSend.Body += "Contraseña: "+ data + "\n\n\n";
                toSend.Body += "Este email ha sigo generado automaticamente.\n No conteste a este mensaje, si desea contactarnos puede hacerlo mediante el formulario de la web\n";

                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(toSend.From.Address, "amaronform");
                    smtp.Timeout = 20000;
                }
                smtp.Send(toSend);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        protected void Send_email_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            
            // If email exists in DB, change password for that email and send it back to that email address.
            
                ENUser user = new ENUser();
                user.email = recover_email.Text.ToString();
                if(user.ReadUser())
                {
                //Changes DB password for this user
                    byte[] salt;
                    new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                    var pb = new Rfc2898DeriveBytes(user.pass, salt, 1000);
                    byte[] random = pb.GetBytes(20);
                    string newpass = Convert.ToBase64String(random);

                if (user.UpdateUser())
                    {
                        //If info can be sent, then show success message
                        if (SendMail(user.name, user.email, newpass.ToString()))
                        {
                            Label_Sending_Success.Visible = true;
                        }
                        else
                        {
                            Label_Main.Text = "Ocurrió un error inesperado al enviar su email, contacte con un administrador.";
                            Label_Main.Visible = true;
                        }
                    }
                    else
                    {
                        Label_Update_Error.Visible = true;
                    }
                }else{
                    Label_Finding_Error.Visible = true;        
                }
            

        }
    }
}