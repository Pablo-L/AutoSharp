using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace Interface_v2
{
    public partial class SigUpEmpresa : System.Web.UI.Page
    {
        ENEmpresa empresa = new ENEmpresa();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["nif"] != null || Session["cif"] != null)
                {
                    Response.Redirect("~/Inicio.aspx");
                }
                if (Request.QueryString["messg"] == "true")
                {
                    txtmessage.Text = "Registro completado. Usted puede ahora acceder a su cuenta.";
                }
                else if (Request.QueryString["messg"] == "false")
                {
                    txtmessage.Text = "Error interno del servidor: El registro no ha podido llevarse a cabo.";
                }
                else if (Request.QueryString["messg"] == "exists")
                {
                    txtmessage.Text = "Error: El CIF introducido ya ha sido registrado en esta página.";
                }
                if (Request.QueryString["messg"] != null)
                {
                    PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                    // make collection editable
                    isreadonly.SetValue(this.Request.QueryString, false, null);
                    // remove
                    this.Request.QueryString.Remove("messg");
                }
            }
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            ENEmpresa en = new ENEmpresa();
            en.Cif = CIF.Text;
            if (en.readEmpresa() == true)
            {
                Response.Redirect("SignUpEmpresa.aspx?messg=exists");
            }
            SignUpEmpresa();
        }
        protected void SignUpEmpresa()
        {
            try
            {
                ENEmpresa en = new ENEmpresa();
                en.Cif = CIF.Text;
                en.Nombre = name.Text;
                en.Tamanyo = tamanyo_empresa.SelectedItem.Text;
                en.Mail = email.Text;
                en.Direccion = direction.Text;
                en.Telefono = Convert.ToInt32(telefono.Text);
                en.Contrasenya = pswd.Text;

                if (en.createEmpresa())
                {
                    Response.Redirect("SignUpEmpresa.aspx?messg=true",false);
                }
                else
                {
                    Response.Redirect("SignUpEmpresa.aspx?messg=false",false);
                }
            }
            catch
            {
                Response.Redirect("SignUpEmpresa.aspx?messg=false",false);
            }
        }

    }
}