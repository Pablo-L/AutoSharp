using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Library
{
	public class CADVehiculo
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
        /// Crea el vehículo indicado en la bd
        /// </summary>
        /// <param name="en">atributos del vehículo a crear</param>
        /// <returns></returns>
        public bool createVehiculo(ENVehiculo en)
        {

        }
        /// <summary>
        /// Lee el vehículo indicado de la base de datos
        /// </summary>
        /// <param name="en">vehículo a leer</param>
        /// <returns></returns>
        public bool readVehiculo(ENVehiculo en)
        {

        }
        /// <summary>
        /// Borra el vehículo indicado de la base de datos
        /// </summary>
        /// <param name="en">vehículo a borrar</param>
        /// <returns></returns>
        public bool deleteVehiculo(ENVehiculo en)
        {

        }
        /// <summary>
        /// Actualiza el vehículo indicado en la base de datos
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool updateVehiculo(ENVehiculo en)
        {

        }
        
	}
}
