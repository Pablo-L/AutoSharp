﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class ListaOferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CarDetails_Command(object source, CommandEventArgs e)
        {

            Response.Redirect("~/DetallesCoches.aspx?matricula=" + e.CommandArgument.ToString());

        }

        protected void BorrarOferta_Click(object sender, EventArgs e)
        {

        }
    }
}