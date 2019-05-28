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
    public partial class ListaOferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cif"] == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }

            if (!IsPostBack)
            {
                BindListView();
                if (Request.QueryString["mssg"] == "true")
                {
                    txtmessage.Text = "Operacion efectuada con éxito.";
                }
                if (Request.QueryString["mssg"] == "false")
                {
                    txtmessage.Text = "Error: la operación no ha podido efectuarse.";
                }
            }

            if (Request.QueryString["mssg"] != null)
            {
                PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                // make collection editable
                isreadonly.SetValue(this.Request.QueryString, false, null);
                // remove
                this.Request.QueryString.Remove("mmssg");
            }
        }

        private void BindListView()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Ofertado.matricula,marca,modelo,imagen,Oferta.descripcion,fecha_inicio,fecha_fin FROM Vehiculo,Ofertado,Oferta WHERE cif='" + Session["cif"].ToString() + "' and Vehiculo.matricula=Ofertado.matricula and Oferta.codigo=Ofertado.codigo", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }

        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "ActualizarCommand")
            {
                ENOferta en = new ENOferta();
                en.Matricula = ((TextBox)e.Item.FindControl("matricula")).Text;
                en.Fin = ((TextBox)e.Item.FindControl("fin")).Text;
                if (en.prorrogarOferta())
                {
                    Response.Redirect("ListaOferta.aspx?mssg=true", false);
                }
                else
                {
                    Response.Redirect("ListaOferta.aspx?mssg=false", false);
                }
            }
            if (e.CommandName == "BorrarCommand")
            {
                ENOferta en = new ENOferta();
                en.Matricula = ((TextBox)e.Item.FindControl("matricula")).Text;
                if (en.eliminarOferta())
                {
                    Response.Redirect("ListaOferta.aspx?mssg=true", false);
                }
                else
                {
                    Response.Redirect("ListaOferta.aspx?mssg=false", false);
                }
            }
        }


        protected void BorrarVehiculo_Click(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}