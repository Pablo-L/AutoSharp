using System;

namespace Library
{
    /// <summary>
    /// ENComentario
    /// </summary>
    class ENComentario
    {   
        /// <summary>
        /// Atributo privado _id
        /// </summary>
        private string _id;

        /// <summary>
        /// Propiedad pública id.
        /// </summary>
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        /// <summary>
        /// Atributo privado _fecha_hora
        /// </summary>
        private string _fecha_hora;

        /// <summary>
        /// Propiedad pública fecha_hora
        /// </summary>
        public string fecha_hora
        {
            get
            {
                return _fecha_hora;
            }
            set
            {
                _fecha_hora = value;
            }
        }

        /// <summary>
        /// Atributo privado _descripcion
        /// </summary>
        private string _descripcion;

        /// <summary>
        /// Propiedad pública descripcion
        /// </summary>
        public string descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }

        /// <summary>
        /// Atributo privado _valoracion
        /// </summary>
        private int _valoracion;

        /// <summary>
        /// Propiedad pública valoracion
        /// </summary>
        public int valoracion
        {
            get
            {
                return _valoracion;
            }
            set
            {
                _valoracion = value;
            }
        }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        ENComentario()
        {
            id = null;
            fecha_hora = null;
            descripcion = null;
            valoracion = 0;
        }

        /// <summary>
        /// Constructor por valor
        /// </summary>
        /// <param name="i"> Parámetro string i</param>
        /// <param name="dh"> Parámetro string dh</param>
        /// <param name="des">Parámetro string des</param>
        /// <param name="val"> Parámetro entero val</param>
        ENComentario(string i,string dh, string des, int val)
        {
            id = i;
            fecha_hora = dh;
            descripcion = des;
            valoracion = val;
        }

        /// <summary>
        /// Crea un comentario
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.createComentario(this);
        }

        /// <summary>
        /// Lee un usuario 
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.readComentario(this);
        }

        /// <summary>
        /// Modifica un comentario
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.updateComentario(this);
        }

        /// <summary>
        /// Borra un comentario
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.deleteComentario(this);
        }
    }
}