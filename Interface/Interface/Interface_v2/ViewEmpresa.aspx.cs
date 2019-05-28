using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class ViewEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cif"] == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["message"] != null)
                    {
                        txtmessage.Text = "Error interno del servidor: El perfil no ha podido actualizarse con éxitos.";
                    }
                    ENEmpresa en = new ENEmpresa();
                    en.Cif = Session["cif"].ToString();
                    en.readEmpresa();
                    CIF.Text = en.Cif;
                    name.Text = en.Nombre;
                    size.Text = en.Tamanyo;
                    direction.Text = en.Direccion;
                    telefono.Text = en.Telefono.ToString(); ;
                    pswd.Text = en.Contrasenya;
                    email.Text = en.Mail;
                }
            }
        }

        protected void Btnupdateprofile_Click(object sender, EventArgs e)
        {
            try
            {
                ENEmpresa en = new ENEmpresa();
                en.Cif = CIF.Text;
                en.Nombre = name.Text;
                en.Tamanyo = size.Text;
                en.Direccion = direction.Text;
                en.Telefono = Int32.Parse(telefono.Text);
                en.Contrasenya = pswd.Text;
                en.Mail = email.Text;
                if (en.updateEmpresa())
                {
                    txtmessage.Text = "Perfil actualizado con éxito.";
                }
                else
                {
                    Response.Redirect("ViewEmpresa.aspx?message=true");
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("ViewEmpresa.aspx?message=true");
            }
        }
    }
}