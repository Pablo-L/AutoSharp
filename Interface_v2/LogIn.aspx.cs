using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace Interface_v2
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ENParticular en = new ENParticular();
        ENEmpresa en_two = new ENEmpresa();

        protected void LoginParticular(object sender, EventArgs e)
        {
            //Pensado como si estubiese hecho con textBox
            en.nifUser = IDParticular.Text;
            if (en.readParticular())
            {
                //quiere decir que existe una empresa con ese cif
                if (en.passwordUser == PassParticular.Text)//No se si esta bien la comparacion o falta algun cast
                {
                    //ahora se puede redireccionar donde sea pertinente
                }
            }
            else
            {
                //el cif no es correcto mostrar label o lo que sea de error
            }
        }


        protected void LoginEmpresa(object sender, EventArgs e)
        {
            //Pensado como si estubiese hecho con textBox
            en_two.Cif = IDEmpresa.Text;
            if (en_two.readEmpresa())
            {
                //quiere decir que existe una empresa con ese cif
                if (en_two.Contrasenya == PassEmpresa.Text)//No se si esta bien la comparacion o falta algun cast
                {
                    //ahora se puede redireccionar donde sea pertinente
                }
            }
            else
            {
                //el cif no es correcto mostrar label o lo que sea de error
            }
        }

    }
}