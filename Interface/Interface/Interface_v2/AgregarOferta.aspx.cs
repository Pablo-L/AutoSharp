using Library;
using System;
using System.Collections;
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
    public partial class AgregarOferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cif"] == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["mssg"] == "true")
                    {
                        txtmssg.Text = "Oferta creada con éxito.";
                    }
                    if (Request.QueryString["mssg"] == "false")
                    {
                        txtmssg.Text = "Error interno del servidor: No ha podido crearse la oferta.";
                    }
                    if (Request.QueryString["mssg"] == "exists")
                    {
                        txtmssg.Text = "Error: Ya existe una oferta activa para este vehículo.";
                    }
                    rellenarDrowDownList();
                }
                else
                {
                    txtmssg.Text = "";
                }
                if (Request.QueryString["mssg"] != null)
                {
                    PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                    // make collection editable
                    isreadonly.SetValue(this.Request.QueryString, false, null);
                    // remove
                    this.Request.QueryString.Remove("mssg");
                }
               vehiculoSeleccionado();
            }
        }

        private void rellenarDrowDownList()
        {
            // Listado de ofertas disponibles
            ArrayList lista = new ArrayList();
            ENOferta en = new ENOferta();
            lista = en.listarOfertas();
            ListItem item;
            int i = 1;
            foreach (string s in lista)
            {
                item = new ListItem(s, i.ToString());
                listOfOferts.Items.Add(item);
                i++;
            }
            // Listado de vehículos del anunciante
            ENVehiculo enV = new ENVehiculo();
            enV.vendedorVehiculo = Session["cif"].ToString();
            lista = enV.listarVehiculosPorEmpresa();
            i = 0;
            foreach (string s in lista)
            {
                item = new ListItem(s, i.ToString());
                listOfVehicles.Items.Add(item);
                i++;
            }
        }

        private void vehiculoSeleccionado()
        {
            ENVehiculo en = new ENVehiculo();
            en.matriculaVehiculo = listOfVehicles.SelectedItem.Text;
            en.readVehiculo();
            marca.Text = en.marcaVehiculo;
            matricula.Text = en.matriculaVehiculo;
            modelo.Text = en.modeloVehiculo;
            precio.Text = en.precioVehiculo.ToString() + " €";
            combustible.Text = en.combustibleVehiculo;
            km.Text = en.kilometrosVehiculo.ToString();
            potencia.Text = en.potenciaVehiculo.ToString();
            color.Text = en.colorVehiculo;
            imgAuto.Attributes["src"] = en.imagenVehiculo;
        }

        protected void AgregarOferta_Click(object sender, EventArgs e)
        {
            ENOferta en = new ENOferta();
            en.Codigo = listOfOferts.SelectedItem.Value;
            en.Matricula = listOfVehicles.SelectedItem.Text;
            // Comprueba si el vehículo tiene alguna oferta activa
            if (en.existsOfertado())
            {
                Response.Redirect("AgregarOferta.aspx?mssg=exists");
            }
            en.Inicio = fechaIni.Text;
            en.Fin = fechaFin.Text;
            if(en.createOferta())
            {
                Response.Redirect("AgregarOferta.aspx?mssg=true");
            }
            else
            {
                Response.Redirect("AgregarOferta.aspx?mssg=false");
            }

        }
    }
}