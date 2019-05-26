using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Library;

namespace Interface_v2
{
    public partial class ViewUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nif"] == null)
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
                    ENParticular en = new ENParticular();
                    en.nifUser = Session["nif"].ToString();
                    en.readParticular();
                    NIF.Text = en.nifUser;
                    name.Text = en.nameUser;
                    lastname.Text = en.surNamesUser;
                    direction.Text = en.dirUser;
                    telefono.Text = en.telfUser.ToString();
                    email.Text = en.emailUser;
                    iban.Text = en.ibanUser;
                    pswd.Text = en.passwordUser;
                }
            }
        }

        protected void Btnupdateprofile_Click(object sender, EventArgs e)
        {
            try
            {
                ENParticular en = new ENParticular();
                en.nifUser = NIF.Text;
                en.nameUser = name.Text;
                en.surNamesUser = lastname.Text;
                en.dirUser = direction.Text;
                en.telfUser = Int32.Parse(telefono.Text);
                en.emailUser = email.Text;
                en.ibanUser = iban.Text;
                en.passwordUser = pswd.Text;
                if(en.updateParticular())
                {
                    txtmessage.Text = "Perfil actualizado con éxito.";
                }
                else
                {
                    Response.Redirect("ViewUsuario.aspx?message=true");
                }
            } catch (Exception ex)
            {
                Response.Redirect("ViewUsuario.aspx?message=true");
            }
        }


    }
}