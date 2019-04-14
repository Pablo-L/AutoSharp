using System;

namespace library
{
    public class ENCita
    {
        private int id;

        private DateTime fecha;

        private string motivo;

        //private int CIFEmpresa;

        //private int DNIParticular;

        public ENCita() { }

        public ENCita(ENCita enCita)
        {
            id = enCita.id;
            fecha = enCita.fecha;
            motivo = enCita.motivo;
        }

        public void createENCita()
        {
            CADCita en = new CADCita();
            en.createCADCita(this);
        }

        public void readENCita()
        {
            CADCita en = new CADCita();
            en.readCADCita(this);
        }

        public void updateENCita()
        {
            CADCita en = new CADCita();
            en.updateCADCita(this);
        }

        public void deleteENCita()
        {
            CADCita en = new CADCita();
            en.deleteCADCita(this);
        }
    }
}