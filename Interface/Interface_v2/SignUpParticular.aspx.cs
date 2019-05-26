using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class SignUpParticular : System.Web.UI.Page
    {
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
                    txtmessage.Text = "Error: El NIF introducido ya ha sido registrado en esta página.";
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

        protected void Submit_Click(object sender, EventArgs e)
        {
            ENParticular en = new ENParticular();
            en.nifUser = NIF.Text;
            if (en.readParticular() == true)
            {
                Response.Redirect("SignUpParticular.aspx?messg=exists");
            }
            SignUpPart();
        }
        protected void SignUpPart()
        {
            try
            {
                ENParticular en = new ENParticular();
                en.nifUser = NIF.Text;
                en.nameUser = name.Text;
                en.dirUser = direction.Text;
                en.emailUser = email.Text;
                en.passwordUser = pswd.Text;
                en.surNamesUser = lastname.Text;
                en.telfUser = Int32.Parse(telefono.Text);
                en.ibanUser = iban.Text;

                if (en.createParticular())
                {
                    Response.Redirect("SignUpParticular.aspx?messg=true", false);
                }
                else
                {
                    Response.Redirect("SignUpParticular.aspx?messg=false", false);
                }
            }
            catch
            {
                Response.Redirect("SignUpParticular.aspx?messg=false", false);
            }
        }
    }
}