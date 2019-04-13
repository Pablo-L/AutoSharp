using System;

namespace library
{
    public class CADOferta
    {

        private string constring;
        public string Constring { get => constring; set => constring = value; }


        public CADOferta() { }


        public bool importCADOferta(ENOferta enOferta) { }

        public bool insertCADOferta(ENOferta enOferta) { }

        public bool updateCADOferta(ENOferta enOferta) { }

        public bool deleteCADOferta(ENOferta enOferta) { }

        //public void importNextCADOferta(ENCita enOferta) { }

        //public void importPrevCADOferta(ENCita enOferta) { }

    }
}