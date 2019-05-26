using Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2.imagenes
{
    public partial class AgregarOferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //BindListView();
                //RellenarFiltros();
            }
        }

       /* private void BindListView()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen,matricula FROM Vehiculo", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }

        private void BindListViewFilter()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
            string marca = Matricula.SelectedItem.Text;
            if (matricula == "Seleccione Matricula") marca = "%";
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen,matricula FROM Vehiculo where marca like '" + marca + "' and modelo like '" + modelo + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
            else
            {
                int year = Int32.Parse(año);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen,matricula FROM Vehiculo where marca like '" + marca + "' and modelo like'" + modelo + "' and anyo='" + year + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }

        protected void RellenarFiltros()
        {
            ENVehiculo en = new ENVehiculo();
            List<ENVehiculo> lista = new List<ENVehiculo>();
            lista = en.listarVehiculos();
            ListItem item;
            int i = 0;
            item = new ListItem("Seleccione matricula", i.ToString());
            Matricula.Items.Add(item);
            i++;
            foreach (ENVehiculo v in lista)
            {

                if (Marca.Items.FindByText(v.marcaVehiculo) == null)
                {
                    item = new ListItem(v.marcaVehiculo, i.ToString());
                    Marca.Items.Add(item);
                }

                if (Modelo.Items.FindByText(v.modeloVehiculo) == null)
                {
                    item = new ListItem(v.modeloVehiculo, i.ToString());
                    Modelo.Items.Add(item);
                }

                if (Año.Items.FindByText(v.añoVehiculo.ToString()) == null)
                {
                    item = new ListItem(v.añoVehiculo.ToString(), i.ToString());
                    Año.Items.Add(item);
                }
                i++;
            }
        }*/
    }
}