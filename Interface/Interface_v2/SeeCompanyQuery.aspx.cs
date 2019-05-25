using AjaxControlToolkit;
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
    public partial class SeeCompanyQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cif"] == null)
                {
                    Response.Redirect("~/Inicio.aspx");
                }
                //  ******************************
                ArrayList listaFechas = new ArrayList();
                ENConsulta enCo2 = new ENConsulta();
                enCo2.Cif = Session["cif"].ToString();
                listaFechas = enCo2.listarFechasPorCif();
                ListItem item;
                item = new ListItem("%", "0");
                listOfDates.Items.Add(item);
                int i = 1;
                foreach (string s in listaFechas)
                {
                    item = new ListItem(s, i.ToString());
                    listOfDates.Items.Add(item);
                    i++;
                }
                //  ******************************
            }
        }
        protected void FilterQuery_Click(object sender, EventArgs e)
        {
            ENConsulta enCo = new ENConsulta();
            enCo.Cif = Session["cif"].ToString();
            enCo.Fecha = listOfDates.SelectedItem.Text;
            List<ENConsulta> lista3 = new List<ENConsulta>();
            lista3 = enCo.listarConsultasClientes();
            AccordionPane p;
            foreach (ENConsulta enc in lista3)
            {
                p = new AccordionPane();
                if (enc.Respuesta != "")
                {
                    p.HeaderContainer.Controls.Add(new LiteralControl("Fecha:&nbsp" + enc.Fecha + " Empresa:&nbsp" + enc.Nif + " <span style='color: red;'>Cerrada</span>"));
                }
                else
                {
                    p.HeaderContainer.Controls.Add(new LiteralControl("Fecha:&nbsp" + enc.Fecha + " Empresa:&nbsp" + enc.Nif + " <span style='color: blue;'>Abierta</span>"));
                }
                p.ContentContainer.Controls.Add(new LiteralControl("Pregunta: <br><br>" + enc.Pregunta + "<br><br>Respuesta:<br><br>" + enc.Respuesta));
                acc1.Panes.Add(p);
            }
        }

        protected void listOfDates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}