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
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }
        /// <summary>
        /// Crea la compra indicada en la bd
        /// </summary>
        /// <param name="en">atributos de la compra a crear</param>
        /// <returns></returns>
        public bool createCompra(ENCompra en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Compra(cif,nif,matricula,fecha) VALUES ('"
                    + en.vendedorCompra + "','" + en.compradorCompra + "','" + en.matriculaCompra + "','" + en.fechaCompra + "')", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Compra operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }
        /// <summary>
        /// Lee la compra de la base de datos
        /// </summary>
        /// <param name="en">compra a leer</param>
        /// <returns></returns>
        public bool readCompra(ENCompra en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Compra where cif = @cif and nif = @nif", c);
                com.Parameters.Add(new SqlParameter("@cif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@cif"].Value = en.vendedorCompra;
                com.Parameters.Add(new SqlParameter("@nif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@nif"].Value = en.compradorCompra;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.vendedorCompra = dr["cif"].ToString();
                en.compradorCompra = dr["nif"].ToString();
                en.matriculaCompra = dr["matricula"].ToString();
                en.fechaCompra = dr["fecha"].ToString();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Compra operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }
        /// <summary>
        /// Borra la compra indicada de la base de datos
        /// </summary>
        /// <param name="en">compra a borrar</param>
        /// <returns></returns>
        public bool deleteCompra(ENCompra en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Delete from Compra where cif = @cif and nif = @nif", c);
                com.Parameters.Add(new SqlParameter("@cif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@cif"].Value = en.vendedorCompra;
                com.Parameters.Add(new SqlParameter("@nif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@nif"].Value = en.compradorCompra;
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oferta ration has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
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
