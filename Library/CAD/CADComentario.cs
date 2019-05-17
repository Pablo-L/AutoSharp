using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class CADComentario
    {
        /// <summary>
        /// almacena la cadena de conexion con la BBDD
        /// </summary>
        private string constring;
        /// <summary>
        /// Inicializa la cadena de conexion a la BBDD
        /// </summary>
        public CADComentario()
        {
            //constring = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        }
        /// <summary>
        /// Crea un nuevo comentario en BBDD
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool createUsuario(ENComentario en)
        {
            bool cambiado = false;
            DataSet bdVirutal = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Comentario", c);
                da.Fill(bdVirutal, "Comentario");
                DataTable t = new DataTable();
                t = bdVirutal.Tables["Comentario"];
                DataRow nuevaFila = t.NewRow();
                nuevaFila["id"] = en.id;
                nuevaFila["cif"] = en.cif;
                nuevaFila["fecha"] = en.fecha;
                nuevaFila["valoracion"] = en.motivo;
                nuevaFila["nif"] = en.nif;
                t.Rows.Add(nuevaFila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdVirutal, "Comentario");
                cambiado = true;
            }
            catch (Exception ex)
            {
                /*tratamiento de un label?*/
            }
            finally { c.Close(); }
            return cambiado;
        }
        /// <summary>
        /// Lee un Comentario de la BBDD
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readComentario(ENComentario en)
        {
            bool read = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from Comentario", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                //para identificar una cita necesitamos conocer de que cita y empresa trata
                if (dr["id"].ToString() == en.id.ToString() && dr["cif"].ToString() == en.cif.ToString())
                {
                    read = true;
                    en.fecha = dr["fecha"].ToString();//cast de object a string
                    en.motivo = dr["valoracion"].ToString();
                    en.nif = (int)dr["nif"];
                    break;
                }
            }
            return read;
        }
        /// <summary>
        /// Modifica un comentario de la base de datos
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool updateComentario(ENComentario en)
        {
            bool check = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Comentario where id = '" + en.id + "'", c);
                da.Fill(bdVirtual, "Cita");
                if (bdVirtual.Tables[0].Rows.Count > 0)
                {
                    //manera propia:
                    //damos por hecho que id y cif no se cambia
                    string consulta = "update Comentario set id ='" + en.id + "', cif = '" + en.cif + "', fecha = " + en.fecha + ", en.valoracion = '" + en.valoracion +"' where id = '" + en.id + "and cif ='" + en.cif + "'";
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
        /// Borra un comentario de la base de datos
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool deleteComentario(ENComentario en)
        {
            bool check = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                string consulta = "delete from Comentario where id = '" + en.id + " and cif = '" + en.cif + "'";
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
