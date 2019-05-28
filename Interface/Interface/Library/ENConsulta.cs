
using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{

    /// <summary>
    /// ENConsulta
    /// </summary>
    public class ENConsulta
    {
        private int id;
        private string fecha;
        private string cif;
        private string nif;
        private string pregunta;
        private string respuesta;

        public int Id { get => id; set => id = value; }
        /// <summary>
        /// propiedad publica fecha_
        /// </summary>
        public string Fecha { get => fecha; set => fecha = value; }

        /// <summary>
        /// atrivbuto privado id
        /// </summary>

        /// <summary>
        /// propiedad publica id_
        /// </summary>
        public string Cif { get => cif; set => cif = value; }

        public string Nif { get => nif; set => nif = value; }

        /// <summary>
        /// propiedad publica pregunta_
        /// </summary>
        public string Pregunta { get => pregunta; set => pregunta = value; }

        /// <summary>
        /// atributo privado respuesta
        /// </summary>
        public string Respuesta { get => respuesta; set => respuesta = value; }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public ENConsulta()
        {
            this.Id = 0;
            this.Fecha = null;
            this.Nif = null;
            this.Cif = null;
            this.Pregunta = null;
            this.Respuesta = null;
        }

        /// <summary>
        /// constructor por valores
        /// </summary>
        /// <param name="fecha_"> parametro datetime fecha </param>
        /// <param name="id_"> parametro int id </param>
        /// <param name="pregunta_"> parametro string pregunta </param>
        /// <param name="respuesta"> parametro string respuesta </param>
        public ENConsulta(int id, string fecha, string nif, string cif, string pregunta, string respuesta)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Nif = nif;
            this.Cif = cif;
            this.Pregunta = pregunta;
            this.Respuesta = respuesta;
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

        public bool leerPrimera()
        {
            CADConsulta en = new CADConsulta();
            return en.LeerPrimera(this);
        }

        public bool leerSiguiente()
        {
            CADConsulta en = new CADConsulta();
            return en.LeerSiguiente(this);
        }
        public bool actualizarRespuesta()
        {
            CADConsulta en = new CADConsulta();
            return en.ActualizarRespuesta(this);
        }
        public bool leerAnterior()
        {
            CADConsulta en = new CADConsulta();
            return en.LeerAnterior(this);
        }

        public List<ENConsulta> listarConsultas()
        {
            List<ENConsulta> a = new List<ENConsulta>();
            CADConsulta c = new CADConsulta();
            a = c.ListarConsultas(this);

            return a;
        }

        public List<ENConsulta> listarConsultasClientes()
        {
            List<ENConsulta> a = new List<ENConsulta>();
            CADConsulta c = new CADConsulta();
            a = c.ListarConsultasClientes(this);

            return a;
        }

        public ArrayList listarFechas()
        {
            ArrayList a = new ArrayList();
            CADConsulta c = new CADConsulta();
            a = c.ListarFechas(this);

            return a;
        }

        public ArrayList listarFechasPorCif()
        {
            ArrayList a = new ArrayList();
            CADConsulta c = new CADConsulta();
            a = c.ListarFechasPorCif(this);

            return a;
        }
        /// <summary>
        /// lee una consulta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        /*public bool readConsulta()
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
        }*/
    }
}