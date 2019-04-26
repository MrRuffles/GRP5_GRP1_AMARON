using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace AMARON_INTERFACE
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        private void ClearErrorLabels()
        {
            LabelErrorEmail.Text = "";
            LabelErrorName.Text = "";
            LabelErrorSubject.Text = "";
            LabelErrorMsg.Text = "";

        }

        private bool numbersInName(string name)
        {
            string numbers = "0123456789";
            int size = name.Length;
            char[] a = new char[size];
            a = name.ToCharArray();

            for (int i = 0; i < size; i++)
                if (numbers.Contains(a[i]))
                    return true;

            return false;
        }
        protected bool Form_Check(object sender, EventArgs e)
        {
            bool error = false;
            if (tbName.Text.ToString() == "")
            {
                LabelErrorName.Text = "Name is required";

                error = true;
            }
            if (numbersInName(tbName.Text.ToString()))
            {
                LabelErrorName.Text = "Field name can't have numeric values";
                error = true;
            }
            if (tbEmail.Text.ToString() == "" )
            {
                LabelErrorEmail.Text = "Valid email is required: ex@abc.xyz";
                error = true;
            }
            if (error)
                return false;
            else
                return true;
        }
        public void Send_email(object sender, EventArgs e)
        {
            MainLabel.Text = "";
            if (Form_Check(sender, e))
            {
                ClearErrorLabels();
               
                ENSuggest ensug = new ENSuggest(tbName.Text.ToString(), tbEmail.Text.ToString(),tbSubject.Text.ToString(), TextArea1.Value);
                if (ensug.storeSuggest())
                {
                    tbName.Text = "";
                    tbEmail.Text = "";
                    tbSubject.Text = "";
                    TextArea1.Value = "";
                    MainLabel.Text = "Message sent";
                }
                else
                {
                    MainLabel.Text = "An error ocurred when storing your message, try again later...";
                }
            }
            else
            {
                tbName.Text = tbName.Text;
                tbEmail.Text = tbEmail.Text;
                tbSubject.Text = tbSubject.Text;
            }

        }
        
    }
}