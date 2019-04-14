using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// CADCompra
/// </summary>
namespace library
{
    public class CADCompra
    {
        /// <summary>
        /// Cadena de conexión de la base de datos
        /// </summary>
        /// <returns></returns>
        private string constring();
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public CADVehiculo()
        {
            //constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }
        /// <summary>
        /// Crea la compra indicada en la bd
        /// </summary>
        /// <param name="en">atributos de la compra a crear</param>
        /// <returns></returns>
        public bool createCompra(ENCompra en)
        {

        }
        /// <summary>
        /// Lee la compra de la base de datos
        /// </summary>
        /// <param name="en">compra a leer</param>
        /// <returns></returns>
        public bool readCompra(ENCompra en)
        {

        }
        /// <summary>
        /// Borra la compra indicada de la base de datos
        /// </summary>
        /// <param name="en">compra a borrar</param>
        /// <returns></returns>
        public bool deleteCompra(ENCompra en)
        {

        }
        /// <summary>
        /// Actualiza la compra indicada de la base de datos
        /// </summary>
        /// <param name="en">compra a actualizar</param>
        /// <returns></returns>
        public bool updateCompra(ENCompra en)
        {

        }

    }
}
