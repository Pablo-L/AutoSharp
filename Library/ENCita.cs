using System;

namespace Library
{
    /// <summary>
    /// ENCita
    /// </summary>
    public class ENCita
    {
        /// <summary>
        /// Atributo privado ID
        /// </summary>
        private int id;

        /// <summary>
        /// propiedad publica id_
        /// </summary>
        public int id_ { get => id; set => id = value; }

        /// <summary>
        /// Atributo privado fecha
        /// </summary>
        private DateTime fecha;

        /// <summary>
        /// propiedad publica fecha_
        /// </summary>
        public DateTime fecha_ { get => fecha; set => fecha = value; }

        /// <summary>
        /// Atributo privado motivo
        /// </summary>
        private string motivo;
        internal object aux;

        /// <summary>
        /// propiedad publica motivo_
        /// </summary>
        public string motivo_ { get => motivo; set => motivo = value; }

        /// <summary>
        /// propiedad publica cif
        /// </summary>
        //private int CIFEmpresa { get => cif; set => cif = value; }

        /// <summary>
        /// propiedad publica dni
        /// </summary>
        //private int DNIParticular { get => dni; set => dni = value; }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public ENCita()
        {
            this.id_ = 0;
            this.fecha_ = DateTime.Now;
            this.motivo_ = null;
        }

        /// <summary>
        /// Constructor por valor
        /// </summary>
        /// <param name="id_"> Parámetro entero id </param>
        /// <param name="fecha_"> Parámetro datetime fecha </param>
        /// <param name="motivo_"> Parámetro string motivo </param>
        public ENCita(int id_, DateTime fecha_, string motivo_)
        {
            this.id_ = id_;
            this.fecha_ = fecha_;
            this.motivo_ = motivo_;

        }

        /// <summary>
        /// crear una cita en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createCita()
        {
            CADCita en = new CADCita();
            return en.createCita(this);
        }

        /// <summary>
        /// lee una cita en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readCita()
        {
            CADCita en = new CADCita();
            return en.readCita(this);
        }

        /// <summary>
        /// actualiza una cita en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateCita()
        {
            CADCita en = new CADCita();
            return en.updateCita(this);
        }

        /// <summary>
        /// borra una cita en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteCita()
        {
            CADCita en = new CADCita();
            return en.deleteCita(this);
        }
    }
}