using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class AnswerQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cif"] == null)
                {
                    Response.Redirect("~/Inicio.aspx");
                }

                leerPrimera();

                if (Request.QueryString["queryerr"] != null)
                {
                    textAnswerQuery.Text = "Error: Escriba una respuesta";
                }
                else if (Request.QueryString["queryerrserver"] != null)
                {
                    textAnswerQuery.Text = "Error interno del servidor: No ha podido enviarse la respuesta.";
                }
                else if (Request.QueryString["queryok"] != null)
                {
                    textAnswerQuery.Text = "Respuesta enviada con éxito.";
                    leerPrimera();
                }

                if (Cliente.Text == "")
                {
                    Id.Text = "";
                    textAnswerQuery.Text = "No hay consultas pendientes.";
                }
            }
            else
            {
                textAnswerQuery.Text = "";
            }
        }

        private void leerPrimera()
        {
            ENConsulta en = new ENConsulta();
            en.Cif = Session["cif"].ToString();
            en.leerPrimera();
            Id.Text = en.Id.ToString();
            Cliente.Text = en.Nif;
            Fecha.Text = en.Fecha;
            Pregunta.Text = en.Pregunta;
        }
        protected void ResponderConsulta_Click(object sender, EventArgs e)
        {
            if(Respuesta.Text == "")
            {
                Response.Redirect("AnswerQuery.aspx?queryerr=true", false);
            }
            else
            {
                ENConsulta en = new ENConsulta();
                en.Cif = Session["cif"].ToString();
                en.Id = Int32.Parse(Id.Text);
                en.Respuesta = Respuesta.Text;
                if (en.actualizarRespuesta())
                {
                    Response.Redirect("AnswerQuery.aspx?queryok=true", false);
                }
                else
                {
                    Response.Redirect("AnswerQuery.aspx?queryerrserver=true", false);
                }
            }
        }

        protected void ReadNext_Click(object sender, ImageClickEventArgs e)
        {
            if (Cliente.Text != "")
            {
                Respuesta.Text = "";
                ENConsulta en = new ENConsulta();
                en.Cif = Session["cif"].ToString();
                en.Id = Int32.Parse(Id.Text);
                if (en.leerSiguiente())
                {
                    Id.Text = en.Id.ToString();
                    Cliente.Text = en.Nif;
                    Fecha.Text = en.Fecha;
                    Pregunta.Text = en.Pregunta;
                }
            }
            else
            {
                textAnswerQuery.Text = "No hay consultas pendientes.";
            }
        }

        protected void ReadPrev_Click(object sender, ImageClickEventArgs e)
        {
            if (Cliente.Text != "")
            {
                Respuesta.Text = "";
                ENConsulta en = new ENConsulta();
                en.Cif = Session["cif"].ToString();
                en.Id = Int32.Parse(Id.Text);
                if (en.leerAnterior())
                {
                    Id.Text = en.Id.ToString();
                    Cliente.Text = en.Nif;
                    Fecha.Text = en.Fecha;
                    Pregunta.Text = en.Pregunta;
                }
            }
            else
            {
                textAnswerQuery.Text = "No hay consultas pendientes.";
            }
        }
    }
}