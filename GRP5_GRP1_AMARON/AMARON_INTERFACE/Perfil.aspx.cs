﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AMARON_INTERFACE
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void verPedidos(object sender, EventArgs e)
        {
            
        }

        protected void editarPerfil(object sender, EventArgs e)
        {
            Response.Redirect("EditarPerfil.aspx");
        }
    }
}