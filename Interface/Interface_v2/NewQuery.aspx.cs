using Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nif"] == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }
            else
            {
                if (Request.QueryString["queryok"] != null)
                {
                    txtsubmitquery.Text = "Consulta enviada con éxito.";
                }
                if (Request.QueryString["queryerr"] != null)
                {
                    txtsubmitquery.Text = "Error interno del servidor: La consulta no ha podido enviarse.";
                }
                if (!IsPostBack)
                {
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
                    Fecha.Text = DateTime.Now.ToString("d");
                }
            }
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
                if (en.createConsulta())
                {
                    Response.Redirect("NewQuery.aspx?queryok=true");
                }
                else
                {
                    Response.Redirect("NewQuery.aspx?queryerr=true");
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("NewQuery.aspx?queryerr=true");
            }
        }
    }
}