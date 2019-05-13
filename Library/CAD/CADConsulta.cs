using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENConsulta;

namespace AutoSharp
{ 
    //CRUD
    public class CADConsulta
    {
        /// <summary>
        /// cadena para la conexion de la BBDD
        /// </summary>
        private string constring;

        //public string Constring { get => constring; private set => constring = value; }
        /// <summary>
        ///   
        /// </summary>
        public CADConsulta()
        {
            //constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();    
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
                if (dr["id"].ToString() == en.id.ToString() && dr["cif"].ToString() == en.cif.ToString())
                {
                    read = true;
                    en.fecha = dr["fecha"].ToString();//cast de object a string
                    en.pregunta = dr["pregunta"].ToString();
                    en.respuesta = dr["respuesta"].ToString();
                    en.nif = dr["nif"].ToString();
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
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from ConsultaOnline where id = '" + en.id+"and cif = '"+en.cif + "'", c);
                da.Fill(bdVirtual, "ConsultaOnline");
                if (bdVirtual.Tables[0].Rows.Count > 0)
                {
                    //manera propia:
                    string consulta = "update ConsultaOnline set id ='" + en.id 
                        + "', cif = '" + en.cif + "', fecha = '"+en.fecha+ 
                        "' pregunta = '"+en.pregunta+"'respuesta = '"+en.respuesta
                        +"'nif ="+en.nif+ " where id = '" + en.id +"' and cif = '"+en.cif+ "'";//damos por hecho que el id y cif no cambian

                    SqlCommand cmd = new SqlCommand(ConsultaOnline, c);
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
                string consulta = "delete from ConsultaOnline where id = '" + en.id + " and cif = '" + en.cif + "'";
                SqlCommand cmd = new SqlCommand(ConsultaOnline, c);
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
}