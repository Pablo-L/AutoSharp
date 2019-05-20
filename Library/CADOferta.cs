using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace Library
{
    
    public class CADOferta
    {

        private string constring;
        ENVehiculo aux_vehiculo = new ENVehiculo();

        public CADOferta()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }


        public bool createOferta(ENOferta en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open(); // Faltan las propiedades públicas en el en
                SqlCommand com = new SqlCommand("Insert Into Oferta (id, fecha_inicio, fecha_fin, descuento, matricula) VALUES ('"
                    + en.id_ + "','" + en.inicioOferta_ + "','" + en.finOferta_ + "','" + en.descuento_ + aux_vehiculo.matriculaVehiculo + "')", c);
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

        public bool readOferta(ENOferta en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Oferta where id = @id", c);
                com.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.NVarChar));
                com.Parameters["@id"].Value = en.id_;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.id_ = dr["id"].ToString();
                //en.inicioOferta_ = dr["fecha_inicio"].ToString();
                //en.finOferta_ = dr["fecha_fin"].ToString();
                //en.descuento_ = dr["descuento"].ToString();
                //en.matriculaOferta = dr["matricula"].ToString();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oferta operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public bool updateOferta(ENOferta enOferta)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Update Vehiculo Set fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, matricula = @matricula where id = @id", c);
                com.Parameters.Add(new SqlParameter("@fecha_inicio", System.Data.SqlDbType.NVarChar));
                com.Parameters["@fecha_inicio"].Value = enOferta.inicioOferta_;
                com.Parameters.Add(new SqlParameter("@fecha_fin", System.Data.SqlDbType.NVarChar));
                com.Parameters["@fecha_fin"].Value = enOferta.inicioOferta_;
                com.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.NVarChar));
                com.Parameters["@matricula"].Value = aux_vehiculo.matriculaVehiculo;
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oferta operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public bool deleteOferta(ENOferta enOferta)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Delete from Oferta where id = @id", c);
                com.Parameters.Add(new SqlParameter("@nif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@id"].Value = enOferta.id_;
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
    }
}