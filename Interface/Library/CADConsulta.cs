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
    //CRUD
    public class CADConsulta
    {
        /// <summary>
        /// cadena para la conexion de la BBDD
        /// </summary>
        ENParticular aux_particular = new ENParticular();
        ENEmpresa aux_empresa = new ENEmpresa();
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
            return false;
        }

        /// <summary>
        /// Lee una categoria seleccionada de la base de datos.
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readConsulta(ENConsulta en)
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
            catch (Exception ex)
            {
                /*tratar label*/
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
            catch (Exception ex)
            {
                /*tratar label*/
            }
            finally { c.Close(); }
            return check;
        
        }

    }
}