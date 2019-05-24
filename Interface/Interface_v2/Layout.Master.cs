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
                txtuser.Text = "Bienvenido " + Session["nif"].ToString();
            }
            else if(Session["cif"] != null)
            {
                txtuser.Text = "Bienvenido " + Session["cif"].ToString();
            }
            else
            {
                if (HeaderMenu.FindItem("/Perfil") != null)
                {
                    HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Perfil"));
                }
                if (HeaderMenu.FindItem("/Salir") != null)
                {
                    HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Salir"));
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
        }
    }
}