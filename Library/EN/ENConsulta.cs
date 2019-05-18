using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
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

        public void import(DateTime fecha)
        {
            CADConsulta c = new CADConsulta();
            c.import(this);
        }

        public void importNext(DateTime fecha)
        {
            CADConsulta c = new CADConsulta();
            c.importNext();
        }

        public void importPrev(DateTime fecha)
        {

        }

        ~ENConsulta()
        {

        }
    }
}