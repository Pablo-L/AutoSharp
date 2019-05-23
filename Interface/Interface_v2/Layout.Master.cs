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
                HeaderMenu.Items[0].ChildItems.Add(HeaderMenu.FindItem("/Perfil"));
                HeaderMenu.Items[0].ChildItems.Add(HeaderMenu.FindItem("/Salir"));
            }
            else
            {
                /*MenuItem parent = HeaderMenu.FindItem("Sesion");
                MenuItem s = HeaderMenu.FindItem("Sesion/Salir");
                MenuItem t = HeaderMenu.FindItem("Sesion/Perfil");
                parent.ChildItems.Remove(s);
                parent.ChildItems.Remove(t);*/
                HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Perfil"));
                HeaderMenu.Items[0].ChildItems.Remove(HeaderMenu.FindItem("/Salir"));
            }
        }
        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

    }
}