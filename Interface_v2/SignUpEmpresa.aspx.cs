using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace Interface_v2
{
    public partial class SigUpEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ENEmpresa en = new ENEmpresa();
        protected void SingUpEmpresa()
        {
            en.Cif = CIF.Text;
            en.Nombre = name.Text;
            en.Tamanyo = tamanyo_empresa.SelectedItem.Value;
            en.Direccion = direction.Text;
            en.Telefono = Convert.ToInt32(telefono.Text);
            en.Contrasenya = pswd.Text;
            if (pswd2.Text != "")
            {
                en.Contrasenya = pswd2.Text;
            }
        }
    }
}