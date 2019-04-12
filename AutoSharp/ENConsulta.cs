using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSharp
{
    public class ENConsulta
    {

        private DateTime fecha_hora;

        public DateTime Fecha_hora { get => fecha_hora; set => fecha_hora = value; }

        ENConsulta(DateTime fecha)
        {
            //validate date here
            CADConsulta c = new CADConsulta();
            c.insert(this);
        }

        ~ENConsulta()
        {

        }



    }
}