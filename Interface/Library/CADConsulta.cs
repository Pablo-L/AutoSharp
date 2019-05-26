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
    //CRUD
    public class CADConsulta
    {
        /// <summary>
        /// cadena para la conexion de la BBDD
        /// </summary>
        List<ENConsulta> lista = new List<ENConsulta>();
        ArrayList listaFechas = new ArrayList();
        private string constring;

        //public string Constring { get => constring; private set => constring = value; }
        /// <summary>
        ///   
        /// </summary>
        public CADConsulta()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();    
        }

        /// <summary>
        /// Crea una consulta en la BBDD.
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool createConsulta(ENConsulta en)
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

                com = new SqlCommand("Insert Into ConsultaOnline (cif,fecha,pregunta,nif) VALUES ('"
                    + en.Cif + "','" + en.Fecha + "','" + en.Pregunta + "','" + en.Nif + "')", c);
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
        public List<ENConsulta> ListarConsultas(ENConsulta en)
        {
            ENConsulta enc;
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
            SqlCommand com2 = new SqlCommand("Select * from ConsultaOnline where nif='" + en.Nif + "' and fecha like '" + en.Fecha + "' and cif like '" + corporationCif + "'", c);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                ene = new ENEmpresa();
                ene.Cif = dr2["cif"].ToString();
                ene.readEmpresa();
                enc = new ENConsulta();
                enc.Pregunta = dr2["pregunta"].ToString();
                enc.Respuesta = dr2["respuesta"].ToString();
                enc.Cif = ene.Nombre;
                enc.Fecha = dr2["fecha"].ToString();
                lista.Add(enc);
            }
            dr2.Close();
            c.Close();
            return lista;
        }

        public List<ENConsulta> ListarConsultasClientes(ENConsulta en)
        {
            ENParticular enP;
            ENConsulta enC;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com2 = new SqlCommand("Select * from ConsultaOnline where fecha like '" + en.Fecha + "' and cif like '" + en.Cif + "'", c);
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                enC = new ENConsulta();
                enP = new ENParticular();
                enP.nifUser = dr2["nif"].ToString();
                enP.readParticular();
                enC.Nif = enP.nameUser;
                enC.Pregunta = dr2["pregunta"].ToString();
                enC.Respuesta = dr2["respuesta"].ToString();
                enC.Fecha = dr2["fecha"].ToString();
                lista.Add(enC);
            }
            dr2.Close();
            c.Close();
            return lista;
        }

        public ArrayList ListarFechas(ENConsulta en)
        {
            string fecha = "";
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("Select distinct(fecha) from ConsultaOnline where nif='" + en.Nif + "'", c);
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

        public ArrayList ListarFechasPorCif(ENConsulta en)
        {
            string fecha = "";
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("Select distinct(fecha) from ConsultaOnline where cif='" + en.Cif + "'", c);
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

        public bool LeerPrimera(ENConsulta en)
        {
            bool read = false;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from ConsultaOnline where id = (select min(id) from ConsultaOnline where respuesta is null and cif='" + en.Cif + "')", c);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                en.Id = Int32.Parse(dr["id"].ToString());
                en.Pregunta = dr["pregunta"].ToString();
                en.Respuesta = dr["respuesta"].ToString();
                en.Fecha = dr["fecha"].ToString();
                ENParticular enP = new ENParticular();
                enP.nifUser = dr["nif"].ToString();
                enP.readParticular();
                en.Nif = enP.nameUser;
                read = true;
            }
            dr.Close();
            return read;
        }
        public bool LeerSiguiente(ENConsulta en)
        {
            bool read = false;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from ConsultaOnline where id > '" + en.Id + "' and respuesta is null and cif='" + en.Cif + "'", c);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                en.Id = Int32.Parse(dr["id"].ToString());
                en.Pregunta = dr["pregunta"].ToString();
                en.Respuesta = dr["respuesta"].ToString();
                en.Fecha = dr["fecha"].ToString();
                ENParticular enP = new ENParticular();
                enP.nifUser = dr["nif"].ToString();
                enP.readParticular();
                en.Nif = enP.nameUser;
                read = true;
            }
            dr.Close();
            c.Close();
            return read;
        }

        public bool LeerAnterior(ENConsulta en)
        {
            bool read = false;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from ConsultaOnline where id < '" + en.Id + "' and respuesta is null and cif='" + en.Cif + "'", c);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                en.Id = Int32.Parse(dr["id"].ToString());
                en.Pregunta = dr["pregunta"].ToString();
                en.Respuesta = dr["respuesta"].ToString();
                en.Fecha = dr["fecha"].ToString();
                ENParticular enP = new ENParticular();
                enP.nifUser = dr["nif"].ToString();
                enP.readParticular();
                en.Nif = enP.nameUser;
                read = true;
            }
            dr.Close();
            c.Close();
            return read;
        }
        public bool ActualizarRespuesta(ENConsulta en)
        {
  
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE ConsultaOnline SET respuesta='" + en.Respuesta + "' WHERE cif='" + en.Cif + "' and id='" + en.Id + "'",c);
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


        /// <summary>
        /// Lee una categoria seleccionada de la base de datos.
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        /*public bool readConsulta(ENConsulta en)
        {
            bool read = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from ConsultaOnline", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr["id"].ToString() == en.id_.ToString() && dr["cif"].ToString() == aux_empresa.Cif.ToString())
                {
                    read = true;
                    //en.fecha_ = dr["fecha"].ToString();//cast de object a string
                    en.pregunta_ = dr["pregunta"].ToString();
                    en.respuesta_ = dr["respuesta"].ToString();
                    aux_particular.nifUser = dr["nif"].ToString();
                    break;
                }
            }
            return read;
        }

        /// <summary>
        /// Actualiza una consulta de la base de datos.
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool updateConsulta(ENConsulta en)
        {
            bool check = false;
           ;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from ConsultaOnline where id = '" + en.id_+"and cif = '"+aux_empresa.Cif + "'", c);
                da.Fill(bdVirtual, "ConsultaOnline");
                if (bdVirtual.Tables[0].Rows.Count > 0)
                {
                    //manera propia:
                    string consulta = "update ConsultaOnline set id ='" + en.id_ 
                        + "', cif = '" + aux_empresa.Cif + "', fecha = '"+en.fecha_+ 
                        "' pregunta = '"+en.pregunta_+"'respuesta = '"+en.respuesta_
                        +"'nif ="+ aux_particular.nifUser + " where id = '" + en.id_ +"' and cif = '"+ aux_empresa.Cif + "'";//damos por hecho que el id y cif no cambian

                    SqlCommand cmd = new SqlCommand(consulta, c);
                    cmd.ExecuteNonQuery();
                    check = true;
                }
            }

            finally { c.Close(); }
            return check;
        }

        /// <summary>
        /// borra una consulta de la BBDD
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>devuelve un bool en fucncion de si se ha borrado o no la consulta</returns>
        public bool deleteConsulta(ENConsulta en)
        {
            bool check = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                string consulta = "delete from ConsultaOnline where id = '" + en.id_ + " and cif = '" + aux_empresa.Cif + "'";
                SqlCommand cmd = new SqlCommand(consulta, c);
                cmd.ExecuteNonQuery();
                check = true;

            }

            finally { c.Close(); }
            return check;
        
        }*/

    }
}