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
    public partial class SeeQuery : System.Web.UI.Page
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
                ENConsulta enCo2 = new ENConsulta();
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
            ENConsulta enCo = new ENConsulta();
            enCo.Nif = Session["nif"].ToString();
            enCo.Cif = listOfCompanies.SelectedItem.Text;
            enCo.Fecha = listOfDates.SelectedItem.Text;
            List<ENConsulta> lista3 = new List<ENConsulta>();
            lista3 = enCo.listarConsultas();
            AccordionPane p;
            foreach (ENConsulta enc in lista3)
            {
                p = new AccordionPane();
                if (enc.Respuesta != "")
                {
                    p.HeaderContainer.Controls.Add(new LiteralControl("Fecha:&nbsp" + enc.Fecha + " Empresa:&nbsp" + enc.Cif + " <span style='color: red;'>Cerrada</span>"));
                }
                else
                {
                    p.HeaderContainer.Controls.Add(new LiteralControl("Fecha:&nbsp" + enc.Fecha + " Empresa:&nbsp" + enc.Cif + " <span style='color: blue;'>Abierta</span>"));
                }
                p.ContentContainer.Controls.Add(new LiteralControl("Pregunta: <br><br>" + enc.Pregunta + "<br><br>Respuesta:<br><br>" + enc.Respuesta));
                acc1.Panes.Add(p);
            }
        }
    }
}