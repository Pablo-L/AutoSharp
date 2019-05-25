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
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["nif"] == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }
            ArrayList lista = new ArrayList();
            ENEmpresa en = new ENEmpresa();
            lista = en.listarEmpresas();
            ListItem item;
            int i = 0;
            foreach (string s in lista)
            {
                item = new ListItem(s,i.ToString());
                listOfCompanies.Items.Add(item);
                i++;
            }
            Fecha.Text = DateTime.Now.ToString("d");
        }

        protected void EnviarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                ENConsulta en = new ENConsulta();
                en.Cif = listOfCompanies.SelectedItem.Text;
                en.Nif = Session["nif"].ToString();
                en.Fecha = Fecha.Text;
                en.Pregunta = Pregunta.Text;
                if(en.createConsulta())
                {
                    txtsubmitquery.Text = "Consulta enviada con éxito";
                }
                else
                {
                    txtsubmitquery.Text = "Error: La consulta no ha podido ser enviada.";
                }
            }
            catch (Exception ex)
            {
                txtsubmitquery.Text = "Error interno del servidor: La consulta no ha podido ser enviada.";
            }
        }

        /*protected void EnviarConsulta_Click(object sender, EventArgs e)
        {
            ENConsulta en = new ENConsulta();
            en.Cif = listOfCompanies.Text;
            en.Nif = Session["nif"].ToString();
            en.Fecha = Fecha.Text;
            en.Pregunta = Pregunta.Text;
            en.createConsulta();
        }*/
    }
}