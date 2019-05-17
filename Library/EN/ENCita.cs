using System;

namespace library
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

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Cita()
        {
            id = 0;
            fecha = DateTime.Now;
            motivo = null;
        }

        /// <summary>
        /// Constructor por valor
        /// </summary>
        /// <param name="id_"> Parámetro entero id </param>
        /// <param name="fecha_"> Parámetro datetime fecha </param>
        /// <param name="motivo_"> Parámetro string motivo </param>
        public Cita(int id_, DateTime fecha_, string motivo_)
        {
            id = id_;
            fecha = fecha_;
            motivo = motivo_;

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