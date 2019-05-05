using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class CADComentario
    {
        /// <summary>
        /// almacena la cadena de conexion con la BBDD
        /// </summary>
        private string constring;
        /// <summary>
        /// Inicializa la cadena de conexion a la BBDD
        /// </summary>
        public CADComentario()
        {
            constring = null;//inicializar cadena
        }
        /// <summary>
        /// Crea un nuevo comentario en BBDD
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool createUsuario(ENComentario en)
        {
            bool creado = false;
            return creado;
        }
        /// <summary>
        /// Lee un Comentario de la BBDD
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readComentario(ENComentario en)
        {
            bool leido = false;
            return leido;
        }
        /// <summary>
        /// Modifica un comentario de la base de datos
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool updateComentario(ENComentario en)
        {
            bool modif = false;
            return modif;
        }
        /// <summary>
        /// Borra un comentario de la base de datos
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool deleteComentario(ENComentario en)
        {
            bool borrado = false;
            return borrado;
        }
    }
}
