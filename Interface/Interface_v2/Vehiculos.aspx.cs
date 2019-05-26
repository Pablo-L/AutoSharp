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

namespace Interface_v2
{
    public partial class Vehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindListView();
                RellenarFiltros();
            }
            else
            {
                mssg.Text = "";
            }
        }

        private void BindListView()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
            SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen FROM Vehiculo", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }

        private void BindListViewFilter()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
            string marca = Marca.SelectedItem.Text;
            if (marca == "Seleccione marca") marca = "%";
            string modelo = Modelo.SelectedItem.Text;
            if (modelo == "Seleccione modelo") modelo = "%";
            string año = Año.SelectedItem.Text;
            if (año == "Seleccione año")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen FROM Vehiculo where marca like '" + marca + "' and modelo like '" + modelo + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
            else
            {
                int year = Int32.Parse(año);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen FROM Vehiculo where marca like '" + marca + "' and modelo like'" + modelo + "' and anyo='" + year + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }

        private void BindListViewFilter2()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
            string marca = Marca.SelectedItem.Text;
            if (marca == "Seleccione marca") marca = "%";
            string modelo = Modelo.SelectedItem.Text;
            if (modelo == "Seleccione modelo") modelo = "%";
            string año = Año.SelectedItem.Text;
            if (año == "Seleccione año")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen FROM Vehiculo where marca like '" + marca + "' and modelo like '" + modelo + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
            else
            {
                int year = Int32.Parse(año);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen FROM Vehiculo where marca like '" + marca + "' and modelo like'" + modelo + "' and anyo='" + year + "'", con);
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
            item = new ListItem("Seleccione marca", i.ToString());
            Marca.Items.Add(item);
            item = new ListItem("Seleccione modelo", i.ToString());
            Modelo.Items.Add(item);
            item = new ListItem("Seleccione año", i.ToString());
            Año.Items.Add(item);
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
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ReservarVehiculo_Click(object sender, EventArgs e)
        {

        }

        protected void ComprarVehiculo_Click(object sender, EventArgs e)
        {

        }

        protected void FiltrarVehiculo_Click(object sender, EventArgs e)
        {
            BindListViewFilter();
        }

        protected void Filtrar2Vehiculo_Click(object sender, EventArgs e)
        {
            if(busquedaInf.Text == "")
            {
                mssg.Text = "Error: Escríba parámetros de búsqueda.";
            }
            else
            {
                string search = "%" + busquedaInf.Text + "%";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString());
                SqlDataAdapter sda = new SqlDataAdapter("SELECT marca,modelo,anyo,color,imagen FROM Vehiculo where marca like '" + search + "' or modelo like '" + search + "' or descripcion like '" + search + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
    }
}