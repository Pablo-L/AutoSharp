using System;

namespace Library
{
    /// <summary>
    /// CADCita
    /// </summary>
	public class CADCita
	{
        /// <summary>
        /// Atributo privado constring
        /// </summary>
        private string constring;

        /// <summary>
        /// Propiedad pública Constring
        /// </summary>
        public string Constring { get => constring; set => constring = value; }

        /// <summary>
        /// Contructor por defecto
        /// </summary>
        public CADCita()
        {
            //constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }

        /// <summary>
        /// Crea una cita
        /// </summary>
        /// <param name="enCita"> Objeto ENCita</param>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createCita(ENCita enCita)
        {

        }

        /// <summary>
        /// Lee una cita seleccionada en la base de datos
        /// </summary>
        /// <param name="enCita">Objeto ENCita</param>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readCita(ENCita enCita)
        {

        }

        /// <summary>
        /// Actualiza una cita de la base de datos
        /// </summary>
        /// <param name="enCita">Objeto ENCita</param>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateCita(ENCita enCita)
        {

        }

        /// <summary>
        /// Elimina una cita de la base de datos
        /// </summary>
        /// <param name="enCita">Objeto ENCita</param>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteCita(ENCita enCita)
        {

        }

        //public void importNextCADCita(ENCita enCita) { }

        //public void importPrevCADCita(ENCita enCita) { }

    }
}