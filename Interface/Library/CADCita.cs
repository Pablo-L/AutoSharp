using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;

namespace Library
{
	public class CADCita
	{

        List<ENCita> lista = new List<ENCita>();
        ArrayList listaFechas = new ArrayList();
        private string constring;

        /// <summary>
        /// Inicilaiza la conexion a la BBDD
        /// </summary>
        public CADCita() 
        {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }
  
        /// <summary>
        /// Crea una cita en la BBDD
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>retorna un bool en función de si se crea o no </returns>
        public bool createCita(ENCita en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("select * from Empresa where nombre='" + en.Cif + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.Cif = dr["cif"].ToString();
                dr.Close();

                com = new SqlCommand("Insert Into Cita (cif,fecha,motivo,nif) VALUES ('"
                    + en.Cif + "','" + en.Fecha + "','" + en.Motivo + "','" + en.Nif + "')", c);
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
        public ArrayList ListarFechas(ENCita en)
        {
            string fecha = "";
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("Select distinct(fecha) from Cita where nif='" + en.Nif + "'", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                fecha = dr["fecha"].ToString();
                listaFechas.Add(fecha);
            }
            dr.Close();
            c.Close();
            return listaFechas;
        }

        public ArrayList ListarFechasPorCif(ENCita en)
        {
            string fecha = "";
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("Select distinct(fecha) from Cita where cif='" + en.Cif + "'", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                fecha = dr["fecha"].ToString();
                listaFechas.Add(fecha);
            }
            dr.Close();
            c.Close();
            return listaFechas;
        }
        public List<ENCita> ListarCitas(ENCita en)
        {
            ENCita enc;
            ENEmpresa ene;
            string corporationCif = en.Cif;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            if (corporationCif != "%")
            {
                SqlCommand com = new SqlCommand("Select * from Empresa where nombre='" + corporationCif + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                corporationCif = dr["cif"].ToString();
                dr.Close();
            }
            SqlCommand com2 = new SqlCommand("Select * from Cita where nif='" + en.Nif + "' and fecha like '" + en.Fecha + "' and cif like '" + corporationCif + "'", c);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                ene = new ENEmpresa();
                ene.Cif = dr2["cif"].ToString();
                ene.readEmpresa();
                enc = new ENCita();
                enc.Motivo = dr2["motivo"].ToString();
                enc.Cif = ene.Nombre;
                enc.Fecha = dr2["fecha"].ToString();
                lista.Add(enc);
            }
            dr2.Close();
            c.Close();
            return lista;
        }

        public List<ENCita> ListarCitasClientes(ENCita en)
        {
            ENParticular enP;

            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com2 = new SqlCommand("Select * from Cita where fecha like '" + en.Fecha + "' and cif like '" + en.Cif + "'", c);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                enP = new ENParticular();
                enP.nifUser = dr2["nif"].ToString();
                enP.readParticular();
                en.Nif = enP.nameUser;
                en.Motivo = dr2["motivo"].ToString();
                en.Fecha = dr2["fecha"].ToString();
                lista.Add(en);
            }
            dr2.Close();
            c.Close();
            return lista;
        }
        /// <summary>
        /// Lee una cita de la base de datos
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>devuelve un bool en funcion de si se borra con exito o no</returns>
        /*public bool readCita(ENCita en) 
        {
            bool read = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from Cita", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                //para identificar una cita necesitamos conocer de que cita y empresa trata
                if (dr["id"].ToString() == en.id_.ToString() && dr["cif"].ToString() == aux_empresa.Cif.ToString())
                {
                    read = true;
                    //en.fecha_ = dr["fecha"].ToString("yyyyMMdd"); //cast de object a string
                    en.motivo_ = dr["motivo"].ToString();
                    aux_particular.nifUser = dr["nif"].ToString();
                    break;
                }
            }
            return read;
        }

        /// <summary>
        /// Actualiza una cita de la BBDD
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>devuelce un bool en funcion de si se actualiza con exito</returns>
        public bool updateCita(ENCita en) 
        {
            bool check = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Cita where id = '" + en.id_ + "'", c);
                da.Fill(bdVirtual, "Cita");
                if (bdVirtual.Tables[0].Rows.Count > 0)
                {
                    //manera propia:
                    //damos por hecho que id y cif no se cambia
                    string consulta = "update Cita set id ='" + en.id_ + "', cif = '" + aux_empresa.Cif + "', fecha = " + en.fecha_ +", en.motivo = '"+en.motivo_+ "' where id = '" + en.id_ + "and cif ='"+ aux_empresa.Cif +"'";
                    SqlCommand cmd = new SqlCommand(consulta, c);
                    cmd.ExecuteNonQuery();
                    check = true;
                }
            }
            finally { c.Close(); }
            return check;
        }

        /// <summary>
        /// Se borra una cita de la BBDD
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>devuelve un bool en funcion de si se borra con exito o no</returns>
        public bool deleteCita(ENCita en) 
        {
            bool check = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                string consulta = "delete from Cita where id = '" + en.id_+" and cif = '"+aux_empresa.Cif+"'";
                SqlCommand cmd = new SqlCommand(consulta, c);
                cmd.ExecuteNonQuery();
                check = true;
                
            }

            finally { c.Close(); }
            return check;
        }      */


        //public void importNextCADCita(ENCita enCita) { }

        //public void importPrevCADCita(ENCita enCita) { }

    }
}