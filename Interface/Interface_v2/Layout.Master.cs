using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_v2
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["nif"] != null)
            {
                txtuser.Text = "Usuario: " + Session["nif"].ToString();
                txtrol.Text = "PARTICULAR";
            }
            else if(Session["cif"] != null)
            {
                txtuser.Text = "Usuario: " + Session["cif"].ToString();
                txtrol.Text = "EMPRESA";
            }
            else
            {
                if (HeaderMenu.FindItem("/Citas") != null)
                {
                    HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Citas"));
                }
                if (HeaderMenu.FindItem("/Perfil") != null)
                {
                    HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Perfil"));
                }
                if (HeaderMenu.FindItem("/Salir") != null)
                {
                    HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Salir"));
                }
                if (HeaderMenu.FindItem("/Consultas") != null)
                {
                    HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Consultas"));
                }
                if (HeaderMenu.FindItem("/Vehiculos") != null)
                {
                    HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Vehiculos"));
                }
            }
        }
        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void HeaderMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            MenuItem selectedItem = HeaderMenu.SelectedItem;
            if (selectedItem.Text.ToString() == "Salir")
            {
                Session.Clear();
                Response.Redirect("~/Inicio.aspx");
            }
            if(selectedItem.Text.ToString() == "Perfil")
            {
                if(Session["nif"] != null)
                {
                    Response.Redirect("~/ViewUsuario.aspx");
                }
                if (Session["cif"] != null)
                {
                    Response.Redirect("~/ViewEmpresa.aspx");
                }
            }
            if (selectedItem.Text.ToString() == "Consultas")
            {
                if (Session["nif"] != null)
                {
                    Response.Redirect("~/OnlineQueryP.aspx");
                }
                if (Session["cif"] != null)
                {
                    Response.Redirect("~/OnlineQueryE.aspx");
                }
            }
            if (selectedItem.Text.ToString() == "Citas")
            {
                if (Session["nif"] != null)
                {
                    Response.Redirect("~/CitaCliente.aspx");
                }
                if (Session["cif"] != null)
                {
                    Response.Redirect("~/CitaEmpresa.aspx");
                }
            }
            if (selectedItem.Text.ToString() == "Vehiculos")
            {
                if (Session["nif"] != null)
                {
                    Response.Redirect("~/VehiculosParticular.aspx");
                }
                if (Session["cif"] != null)
                {
                    Response.Redirect("~/VehiculosEmpresa.aspx");
                }
            }
        }
    }
}