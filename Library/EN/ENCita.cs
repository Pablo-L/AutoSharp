using System;

namespace Library
{
    /// <summary>
    /// ENCita
    /// </summary>
    public class ENCita
    {
        private int id;

        /// <summary>
        /// Atributo privado fecha
        /// </summary>
        private DateTime fecha;

        /// <summary>
        /// Atributo privado motivo
        /// </summary>
        private string motivo;

        /// <summary>
        /// propiedad publica cif
        /// </summary>
        private int CIFEmpresa { get => cif; set => cif = value; }

        /// <summary>
        /// propiedad publica dni
        /// </summary>
        private int DNIParticular { get => dni; set => dni = value; }

        public ENCita() { }

        public ENCita(ENCita enCita)
        {
            id = enCita.id;
            fecha = enCita.fecha;
            motivo = enCita.motivo;
        }

        /// <summary>
        /// crear una cita en la bbdd
        /// </summary>
        public bool createCita()
        {
            CADCita en = new CADCita();
            return en.createCita(this);
        }

        /// <summary>
        /// lee una cita en la bbdd
        /// </summary>
        public bool readCita()
        {
            CADCita en = new CADCita();
            return en.readCita(this);
        }

        /// <summary>
        /// actualiza una cita en la bbdd
        /// </summary>
        public bool updateCita()
        {
            CADCita en = new CADCita();
            return en.updateCita(this);
        }

        /// <summary>
        /// borra una cita en la bbdd
        /// </summary>
        public bool deleteCita()
        {
            CADCita en = new CADCita();
            return en.deleteCita(this);
        }
    }
}