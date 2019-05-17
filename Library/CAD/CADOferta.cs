using System;

namespace Library
{
    public class CADOferta
    {

        private string constring;
        public string Constring { get => constring; set => constring = value; }


        public CADOferta() { }


        public bool createCADOferta(ENOferta enOferta) { }

        public bool readCADOferta(ENOferta enOferta) { }

        public bool updateCADOferta(ENOferta enOferta) { }

        public bool deleteCADOferta(ENOferta enOferta) { }

        //public void importNextCADOferta(ENCita enOferta) { }

        //public void importPrevCADOferta(ENCita enOferta) { }

    }
}