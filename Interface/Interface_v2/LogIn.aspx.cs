using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Library;

namespace Interface_v2
{
    public partial class LogIn : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginEmpresa(object sender, EventArgs e)
        {

        }

        protected void Btnloginp_Click1(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
            try
            {
                string uid = IDParticular.Text;
                string pass = PassParticular.Text;
                c.Open();
                string query = "select * from Particular where nif='" + uid + "'and clave='" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {
                    Session["nif"] = IDParticular.Text.Trim();
                    Response.Redirect("~/Inicio.aspx");
                }
                c.Close();
            } catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}