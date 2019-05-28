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
    public partial class EnVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["cif"] == null)
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT matricula,marca,modelo,anyo,color,km,combustible,potencia,imagen,precio FROM Vehiculo WHERE cif='" + Session["cif"].ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }

        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "ActualizarCommand")
            {
                ENVehiculo en = new ENVehiculo();
                en.vendedorVehiculo = Session["cif"].ToString();
                en.marcaVehiculo = ((TextBox)e.Item.FindControl("marca")).Text;
                en.modeloVehiculo = ((TextBox)e.Item.FindControl("modelo")).Text;
                en.matriculaVehiculo = ((TextBox)e.Item.FindControl("matricula")).Text;
                en.combustibleVehiculo = ((TextBox)e.Item.FindControl("combustible")).Text;
                en.colorVehiculo = ((TextBox)e.Item.FindControl("color")).Text;
                en.potenciaVehiculo = Int32.Parse(((TextBox)e.Item.FindControl("potencia")).Text);
                en.añoVehiculo = Int32.Parse(((TextBox)e.Item.FindControl("potencia")).Text);
                en.kilometrosVehiculo = Int32.Parse(((TextBox)e.Item.FindControl("km")).Text);
                en.precioVehiculo = Int32.Parse(((TextBox)e.Item.FindControl("precio")).Text);
                if(en.updateVehiculo())
                {
                    Response.Redirect("EnVenta.aspx?mssg=true", false);
                }
                else
                {
                    Response.Redirect("EnVenta.aspx?mssg=false", false);
                }
            }
            if (e.CommandName == "BorrarCommand")
            {
                ENVehiculo en = new ENVehiculo();
                en.matriculaVehiculo = ((TextBox)e.Item.FindControl("matricula")).Text;
                en.vendedorVehiculo = Session["cif"].ToString();
                if (en.deteleVehiculo())
                {
                    Response.Redirect("EnVenta.aspx?queryok=true", false);
                }
                else
                {
                    Response.Redirect("EnVenta.aspx?mssg=false", false);
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