using Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindListView();
        }
        private void BindListView()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Ofertado.matricula,marca,modelo,imagen,Oferta.descripcion,fecha_inicio,fecha_fin FROM Vehiculo,Ofertado,Oferta WHERE Vehiculo.matricula=Ofertado.matricula and Oferta.codigo=Ofertado.codigo", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }
    }
}