
using System;

namespace Library
{

    /// <summary>
    /// ENConsulta
    /// </summary>
    public class ENConsulta
    {
        /// <summary>
        /// atributo privado fecha
        /// </summary>
        private string fecha;

        /// <summary>
        /// propiedad publica fecha_
        /// </summary>
        public string fecha_ { get => fecha; set => fecha = value; }

        /// <summary>
        /// atrivbuto privado id
        /// </summary>
        private int id;

        /// <summary>
        /// propiedad publica id_
        /// </summary>
        public int id_ { get => id; set => id = value; }

        /// <summary>
        /// atributo privado pregunta
        /// </summary>
        private string pregunta;

        /// <summary>
        /// propiedad publica pregunta_
        /// </summary>
        public string pregunta_ { get => pregunta; set => pregunta = value; }

        /// <summary>
        /// atributo privado respuesta
        /// </summary>
        private string respuesta;

        /// <summary>
        /// propiedad publica respuesta_
        /// </summary>
        public string respuesta_ { get => respuesta; set => respuesta = value; }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public ENConsulta()
        {
            this.fecha_ = null;
            this.id_ = 0;
            this.pregunta_ = null;
            this.respuesta_ = null;
        }

        /// <summary>
        /// constructor por valores
        /// </summary>
        /// <param name="fecha_"> parametro string fecha </param>
        /// <param name="id_"> parametro int id </param>
        /// <param name="pregunta_"> parametro string pregunta </param>
        /// <param name="respuesta"> parametro string respuesta </param>
        public ENConsulta(string fecha_, int id_, string pregunta_, string respuesta)
        {
            this.fecha_ = fecha_;
            this.id_ = id_;
            this.pregunta_ = pregunta_;
            this.respuesta_ = respuesta_;
        }

        /// <summary>
        /// crear una consulta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createConsulta()
        {
            CADConsulta en = new CADConsulta();
            return en.createConsulta(this);
        }

        /// <summary>
        /// lee una consulta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readConsulta()
        {
            CADConsulta en = new CADConsulta();
            return en.readConsulta(this);
        }

        /// <summary>
        /// actualiza una consulta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateConsulta()
        {
            CADConsulta en = new CADConsulta();
            return en.updateConsulta(this);
        }

        /// <summary>
        /// borra una consulta de la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteConsulta()
        {
            CADConsulta en = new CADConsulta();
            return en.deleteConsulta(this);
        }
    }
}