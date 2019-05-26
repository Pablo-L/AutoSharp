using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Library
{
    public class CADVehiculo
    {
        List<ENVehiculo> lista = new List<ENVehiculo>();
        /// <summary>
        /// Cadena de conexión de la base de datos
        /// </summary>
        /// <returns></returns>
        private string constring;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public CADVehiculo()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }

        /// <summary>
        /// Crea el vehículo indicado en la bd
        /// </summary>
        /// <param name="en">atributos del vehículo a crear</param>
        /// <returns></returns>
        public bool createVehiculo(ENVehiculo en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Vehiculo (matricula, marca, modelo, color, anyo, combustible, potencia, km, precio, imagen, cif) VALUES ('"
                    + en.matriculaVehiculo + "','" + en.marcaVehiculo + "','" + en.modeloVehiculo + "','" + en.colorVehiculo + "','" + en.añoVehiculo + "','" + en.combustibleVehiculo + "','" + en.potenciaVehiculo + "','" + en.kilometrosVehiculo + "','" + en.precioVehiculo + "','" + en.imagenVehiculo + "','" + en.vendedorVehiculo + "')", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vehiculo operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }
        /// <summary>
        /// Lee el vehículo indicado de la base de datos
        /// </summary>
        /// <param name="en">vehículo a leer</param>
        /// <returns></returns>
        public bool readVehiculo(ENVehiculo en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Vehiculo where matricula = @matricula", c);
                com.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.NVarChar));
                com.Parameters["@matricula"].Value = en.matriculaVehiculo;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.matriculaVehiculo = dr["matricula"].ToString();
                en.marcaVehiculo = dr["marca"].ToString();
                en.modeloVehiculo = dr["modelo"].ToString();
                en.colorVehiculo = dr["color"].ToString();
                en.añoVehiculo = int.Parse(dr["anyo"].ToString());
                en.combustibleVehiculo = dr.GetString(5);
                en.potenciaVehiculo = int.Parse(dr["potencia"].ToString());
                en.kilometrosVehiculo = int.Parse(dr["km"].ToString());
                en.precioVehiculo = int.Parse(dr["combustible"].ToString());
                en.vendedorVehiculo = dr.GetString(10);
                en.compradorVehiculo = dr.GetString(11);
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vehiculo operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }
        /// <summary>
        /// Borra el vehículo indicado de la base de datos
        /// </summary>
        /// <param name="en">vehículo a borrar</param>
        /// <returns></returns>
        public bool deleteVehiculo(ENVehiculo en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Delete from Vehiculo where matricula='" + en.matriculaVehiculo + "' and cif='" + en.vendedorVehiculo + "'", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vehiculo operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }
        /// <summary>
        /// Actualiza el vehículo indicado en la base de datos
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool updateVehiculo(ENVehiculo en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Update Vehiculo Set marca='" + en.marcaVehiculo +
                    "', modelo='" + en.modeloVehiculo + "', anyo='" + en.añoVehiculo + "', color='" + en.colorVehiculo +
                    "', km='" + en.kilometrosVehiculo + "', combustible='" + en.combustibleVehiculo + "', potencia='" + en.potenciaVehiculo + "', precio='" + en.precioVehiculo +
                    "'WHERE cif='" + en.vendedorVehiculo + "' and matricula='" + en.matriculaVehiculo + "'", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vehiculo operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public List<ENVehiculo> ListarVehiculos(ENVehiculo en)
        {
            ENVehiculo enV;

            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com2 = new SqlCommand("Select marca,modelo,anyo from Vehiculo", c);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                enV = new ENVehiculo();
                enV.marcaVehiculo = dr2["marca"].ToString();
                enV.modeloVehiculo = dr2["modelo"].ToString();
                enV.añoVehiculo = Int32.Parse(dr2["anyo"].ToString());
                lista.Add(enV);
            }
            dr2.Close();
            c.Close();
            return lista;
        }
    }
}