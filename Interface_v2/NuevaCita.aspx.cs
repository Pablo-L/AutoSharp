using Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class NuevaCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["nif"] == null)
                {
                    Response.Redirect("~/Inicio.aspx");
                }
                if (Request.QueryString["queryok"] != null)
                {
                    txtsubmitquery.Text = "Cita solicitada con éxito.";
                }
                else if (Request.QueryString["queryerr"] != null)
                {
                    txtsubmitquery.Text = "Error interno del servidor: La cita no ha podido solicitarse.";
                }
                ArrayList lista = new ArrayList();
                ENEmpresa en = new ENEmpresa();
                lista = en.listarEmpresas();
                ListItem item;
                int i = 0;
                foreach (string s in lista)
                {
                    item = new ListItem(s, i.ToString());
                    listOfCompanies.Items.Add(item);
                    i++;
                }
            }
            else
            {
                //Fecha.Text = "";
            }
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            Fecha.Text = Calendar.SelectedDate.Day + "/" + Calendar.SelectedDate.Month + "/" + Calendar.SelectedDate.Year;
        }

        protected void SolicitarCita_Click(object sender, EventArgs e)
        {
            try
            {
                ENCita en = new ENCita();
                en.Cif = listOfCompanies.SelectedItem.Text;
                en.Nif = Session["nif"].ToString();
                en.Fecha = Fecha.Text;
                en.Motivo = Pregunta.Text;
                if (en.createCita())
                {
                    Response.Redirect("NuevaCita.aspx?queryok=true", false);
                }
                else
                {
                    Response.Redirect("NuevaCita.aspx?queryerr=true", false);
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("NuevaCita.aspx?queryerr=true", false);
            }
        }
    }
}