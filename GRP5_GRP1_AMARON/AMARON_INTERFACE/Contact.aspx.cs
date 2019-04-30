
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
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        
        private void ClearBoxes()
        {

            form_name.Value = "";
            form_email.Value = "";
            form_subject.Value = "";
            form_message.Value = "";

        }
        
        
        protected bool SendMail (string name, string email, string subject, string message, string option) 
        {
            try
            {
                MailMessage toSend = new MailMessage();
                toSend.Subject = "AMARON Contact Form Mail from " + email;
                toSend.From = new MailAddress("contactformamaron@gmail.com");
                toSend.To.Add("ContactFormAMARON@gmail.com");
                toSend.Body = "From:\t" + name + "\n";
                toSend.Body += "Email:\t" + email + "\n\n";
                toSend.Body += "Requested:\t"+ option+ "\n";
                toSend.Body += "Subject:\t" + subject + "\n";
                toSend.Body += "Message:\n" + message + "\n";

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
        
        protected void Button_send_click(object sender, EventArgs e)
        {

            
            string option = form_option.SelectedValue;
            string name = form_name.Value.ToString();
            string email = form_email.Value.ToString();
            string subject = form_subject.Value.ToString();
            string message = form_message.Value.ToString();
            try
            {
                if ((option != "") &&  SendMail(name, email, subject, message, option))
                {
                    if (option == "Suggestion")
                    {
                        ENSuggest ensug = new ENSuggest(name, email, subject, message);
                        ensug.createSuggest();
                    }
                    if (option == "Support")
                    {
                        ENSupport ensupport = new ENSupport(name, email, subject, message);
                        ensupport.createSupport();
                    }
                    Label_Sending_Success.Visible = true;
                    ClearBoxes();
                }
                else
                {
                    Label_Sending_Error.Visible = true;
                }
                
            }
            catch (Exception ex)
            {
                Label_Main.Text = ex.Message;
                Label_Main.Visible = true;
            }
        }

    }
}