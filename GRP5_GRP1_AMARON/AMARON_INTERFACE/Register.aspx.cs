using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AMARON_INTERFACE
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_register_click(object sender, EventArgs e)
        {
            bool echeck = check_email(), pcheck = check_pass();

            if(echeck && pcheck)
            {




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

    }
}