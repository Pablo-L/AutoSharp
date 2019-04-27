using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ENComentario
    {
        private string _id;
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
        
        private DateTime _fecha_hora;

        public DateTime fecha_hora
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
        private string _descripcion;
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
        private int _valoracion;
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
        /// constructor de la entidad
        /// </summary>
        ENComentario()
        {
            id = null;
            fecha_hora = new DateTime();
            descripcion = null;
            valoracion = 0;
        }
        /// <summary>
        /// constructor de copia de la entidad
        /// </summary>
        ENComentario(string i,DateTime dh, string des, int val)
        {
            id = i;
            fecha_hora = dh;
            descripcion = des;
            valoracion = val;
        }
        /// <summary>
        /// Crea un comentario
        /// </summary>
        /// <returns></returns>
        public bool createComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.createComentario(this);
        }
        /// <summary>
        /// Lee un usuario 
        /// </summary>
        /// <returns></returns>
        public bool readComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.readComentario(this);
        }
        /// <summary>
        /// Modifica un comentario
        /// </summary>
        /// <returns></returns>
        public bool updateComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.updateComentario(this);
        }
        /// <summary>
        /// Borra un comentario
        /// </summary>
        /// <returns></returns>
        public bool deleteComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.deleteComentario(this);
        }
    }
}
