using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENConsulta;

namespace AutoSharp
{
    //CRUD
    public class CADConsulta
    {
        private string constring;

        public string Constring { get => constring; private set => constring = value; }

        CADConsulta()
        {
            
        }

        ~CADConsulta()
        {

        }
        //imports data from database to ENConsulta
        public void import(ENConsulta e)
        {

        }
        //inserts from ENConsulta into database
        public void insert(ENConsulta e)
        {

        }

        public void importNext(ENConsulta e)
        {

        }

        public void importPrev(ENConsulta e)
        {

        }

        public void delete(ENConsulta e)
        {

        }

    }
}