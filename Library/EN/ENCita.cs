using System;

namespace Library
{
    /// <summary>
    /// ENCita
    /// </summary>
    public class ENCita
    {
        /// <summary>
        /// Atributo privado id
        /// </summary>
        private int id;

        /// <summary>
        /// Atributo privado fecha
        /// </summary>
        private DateTime fecha;

        /// <summary>
        /// Atributo privado motivo
        /// </summary>
        private string motivo;

        //private int CIFEmpresa;

        //private int DNIParticular;

        public ENCita()
        {

        }

        public ENCita(int id_, DateTime fecha_, string motivo_)
        {

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