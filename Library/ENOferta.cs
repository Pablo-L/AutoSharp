using System;

namespace library
{
    public class ENOferta
    {
        private string id;

        private DateTime inicioOferta;

        private DateTime finOferta;

        private int descuento;

        public ENOferta() { }

        public ENOferta(ENOferta enOferta)
        {
            id = enOferta.id;
            inicioOferta = enOferta.inicioOferta;
            finOferta = enOferta.finOferta;
            descuento = enOferta.descuento;
        }

        public bool createENOferta()
        {
            CADOferta en = new CADOferta();
            en.createCADOferta(this);
        }

        public bool readENOferta()
        {
            CADOferta en = new CADOferta();
            en.readCADOferta(this);
        }

        public bool updateENOferta()
        {
            CADOferta en = new CADOferta();
            en.updateCADOferta(this);
        }

        public bool deleteENOferta()
        {
            CADOferta en = new CADOferta();
            en.deleteCADOferta(this);
        }
    }
}