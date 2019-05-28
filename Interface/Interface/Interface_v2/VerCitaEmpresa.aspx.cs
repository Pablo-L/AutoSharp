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
    public partial class VerCitaEmpresa : System.Web.UI.Page
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
                ENCita enCo2 = new ENCita();
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

        protected void FiltrarCitas_Click(object sender, EventArgs e)
        {
            ENCita enCo = new ENCita();
            enCo.Cif = Session["cif"].ToString();
            enCo.Fecha = listOfDates.SelectedItem.Text;
            List<ENCita> lista3 = new List<ENCita>();
            lista3 = enCo.listarCitasClientes();
            AccordionPane p;
            foreach (ENCita enc in lista3)
            {
                p = new AccordionPane();
                p.HeaderContainer.Controls.Add(new LiteralControl("Fecha:&nbsp" + enc.Fecha + " Cliente:&nbsp" + enc.Nif));
                p.ContentContainer.Controls.Add(new LiteralControl("Pregunta: <br><br>" + enc.Motivo));
                acc1.Panes.Add(p);
            }
        }
    }
}