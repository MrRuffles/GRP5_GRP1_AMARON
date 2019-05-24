using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;
using System.Net;
using System.Net.Mail;
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
            Label_Sending_Error.Visible = false;
        }
        /*
        protected bool SendMail(string name, string email, string data)
        {
            try
            {
                MailMessage toSend = new MailMessage
                {
                    Subject = "AMARON Password Recovery System",
                    From = new MailAddress("contactformamaron@gmail.com")
                };
                toSend.To.Add(email);
                toSend.Body = "Hi "+ name +"\n";
                toSend.Body += "This email contains your personal information. \n\n";
                toSend.Body += "Password: "+ data + "\n\n\n";
                toSend.Body += "This is an automatic email from AMARON. Please do not reply back, you can contact us at the website contact form.\n";

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
        */
        protected void Send_email_Click(object sender, EventArgs e)
        {
            ClearBoxes();

            /*
            // If email exists in DB, change password for that email and send it back to that email address.
            
                ENUser user = new ENUser();
                user.email = recover_email.Text.ToString();
                if(user.ReadUser())
                {
                    //Changes DB password for this user
                    user.changepassword("defaultpassword");
                    //If info can be sent, then show success message
                    if(SendMail(user.name, user.email, user.password))
                    {
                        Label_Sending_Success.Visible = true;
                    }else{
                        Label_Main.Text = "An error occurred while sending email";
                        Label_Main.Visible = true;
                    }

                }else{
                    Label_Sending_Error.Visible = true;        
                }
            */

        }
    }
}