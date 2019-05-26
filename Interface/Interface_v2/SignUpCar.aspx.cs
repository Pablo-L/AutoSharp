using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class SignUpCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cif"] == null)
                {
                    Response.Redirect("~/Inicio.aspx");
                }
                if (Request.QueryString["messg"] == "true")
                {
                    txtmessage.Text = "Registro completado.";
                }
                else if (Request.QueryString["messg"] == "false")
                {
                    txtmessage.Text = "Error interno del servidor: El registro no ha podido llevarse a cabo.";
                }
                if (Request.QueryString["messg"] != null)
                {
                    PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                    // make collection editable
                    isreadonly.SetValue(this.Request.QueryString, false, null);
                    // remove
                    this.Request.QueryString.Remove("messg");
                }
            }
        }
        protected void SignUpVehiculo()
        {
            try
            {
                ENVehiculo en = new ENVehiculo();
                en.vendedorVehiculo = Session["cif"].ToString();
                en.matriculaVehiculo = matricula.Text;
                en.combustibleVehiculo = combustible.Text;
                en.colorVehiculo = color.Text;
                en.añoVehiculo = Int32.Parse(anyo.Text);
                en.marcaVehiculo = marca.Text;
                en.modeloVehiculo = modelo.Text;
                en.potenciaVehiculo = Int32.Parse(power.Text);
                en.kilometrosVehiculo = Int32.Parse(km.Text);
                en.precioVehiculo = Int32.Parse(precio.Text);
                en.imagenVehiculo = image.Text;
                en.descripcionVehiculo = description.Text;

                if (en.createVehiculo())
                {
                    Response.Redirect("SignUpCar.aspx?messg=true", false);
                }
                else
                {
                    Response.Redirect("SignUpCar.aspx?messg=false", false);
                }
            }
            catch
            {
                Response.Redirect("SignUpCar.aspx?messg=false", false);
            }
        }

        protected void submit_Click_Click(object sender, EventArgs e)
        {
            SignUpVehiculo();
        }
    }
}