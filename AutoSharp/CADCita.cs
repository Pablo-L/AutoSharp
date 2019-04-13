using System;

namespace library
{
	public class CADCita
	{

        private string constring;
        public string Constring { get => constring; set => constring = value; }


        public CADCita() { }


        public bool importCADCita(ENCita enCita) { }

        public bool insertCADCita(ENCita enCita) { }

        public bool updateCADCita(ENCita enCita) { }

        public bool delete(ENCita enCita) { }

        //public void importNextCADCita(ENCita enCita) { }

        //public void importPrevCADCita(ENCita enCita) { }

    }
}