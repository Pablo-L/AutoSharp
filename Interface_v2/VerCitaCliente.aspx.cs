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
    public partial class VerCitaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["nif"] == null)
                {
                    Response.Redirect("~/Inicio.aspx");
                }
                //  ******************************
                ArrayList lista = new ArrayList();
                ENEmpresa en = new ENEmpresa();
                lista = en.listarEmpresas();
                ListItem item;
                item = new ListItem("%", "0");
                listOfCompanies.Items.Add(item);
                int i = 1;
                foreach (string s in lista)
                {
                    item = new ListItem(s, i.ToString());
                    listOfCompanies.Items.Add(item);
                    i++;
                }
                //  ******************************
                ArrayList listaFechas = new ArrayList();
                ENCita enCo2 = new ENCita();
                enCo2.Nif = Session["nif"].ToString();
                listaFechas = enCo2.listarFechas();
                ListItem item2;
                item2 = new ListItem("%", "0");
                listOfDates.Items.Add(item2);
                int i2 = 1;
                foreach (string s2 in listaFechas)
                {
                    item2 = new ListItem(s2, i2.ToString());
                    listOfDates.Items.Add(item2);
                    i++;
                }
                //  ******************************
            }
        }

        protected void FilterQuery_Click(object sender, EventArgs e)
        {
            ENCita enCo = new ENCita();
            enCo.Nif = Session["nif"].ToString();
            enCo.Cif = listOfCompanies.SelectedItem.Text;
            enCo.Fecha = listOfDates.SelectedItem.Text;
            List<ENCita> lista3 = new List<ENCita>();
            lista3 = enCo.listarCitas();
            AccordionPane p;
            foreach (ENCita enc in lista3)
            {
                p = new AccordionPane();
                p.HeaderContainer.Controls.Add(new LiteralControl("Fecha:&nbsp" + enc.Fecha + " Empresa:&nbsp" + enc.Cif));
                p.ContentContainer.Controls.Add(new LiteralControl("Motivo: <br><br>" + enc.Motivo));
                acc1.Panes.Add(p);

            }
        }
    }
}