using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class OnlineQueryP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nif"] == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }
        }

        protected void Unnamed1_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}