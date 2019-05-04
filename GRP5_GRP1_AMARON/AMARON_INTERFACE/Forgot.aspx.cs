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

        }
        private void ClearBoxes()
        {
            recover_email.Text = "";
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
            Label_Sending_Success.Visible = false;
            // SendMail("xxx", recover_email.Text.ToString(), "password");
            // If email exists in DB, send an email to that address that contains user's password.


            Label_Sending_Success.Visible = true;
        }
    }
}