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
using System.Collections;

namespace Library
{
    
    public class CADOferta
    {

        private string constring;
        ArrayList lista = new ArrayList();

        public CADOferta()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }
        public bool ExistsOfertado(ENOferta en)
        {
            bool read = false;
            SqlConnection c = new SqlConnection(constring);
            try{
                c.Open();
                SqlCommand com = new SqlCommand("select * from Ofertado where matricula='" + en.Matricula + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    read = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (c != null) c.Close();
            }
            return read;
        }
        public bool ProrrogarOferta(ENOferta en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Update Ofertado set fecha_fin='" + en.Fin + "' where matricula='" + en.Matricula + "'", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Empresa operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public bool EliminarOferta(ENOferta en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Delete Ofertado where matricula='" + en.Matricula + "'", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Empresa operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }
        public bool CreateOferta(ENOferta en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Ofertado (codigo,matricula,fecha_inicio,fecha_fin) VALUES ('"
                    + en.Codigo + "','" + en.Matricula + "','" + en.Inicio + "','" + en.Fin + "')", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Empresa operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }
        public ArrayList ListarOfertas(ENOferta en)
        {
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Oferta", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["descripcion"].ToString());
            }
            dr.Close();
            c.Close();
            return lista;
        }


    }
}