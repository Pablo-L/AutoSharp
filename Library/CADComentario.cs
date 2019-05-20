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
    class CADComentario
    {

        ENParticular aux_particular = new ENParticular();
        ENEmpresa aux_empresa = new ENEmpresa();
        private string constring;
        public CADComentario()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }
        /// <summary>
        /// Crea un nuevo comentario en BBDD
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool createComentario(ENComentario en)
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
                nuevaFila["cif"] = aux_empresa.Cif;
                nuevaFila["fecha"] = en.fecha_hora;
                nuevaFila["valoracion"] = en.valoracion;
                nuevaFila["nif"] = aux_particular.nifUser;
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
                if (dr["id"].ToString() == en.id.ToString() && dr["cif"].ToString() == aux_empresa.Cif.ToString())
                {
                    read = true;
                    //en.fecha_hora = dr["fecha"].ToString();//cast de object a string
                    en.valoracion = (int)dr["valoracion"];
                    aux_particular.nifUser = dr["nif"].ToString();
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
                    string consulta = "update Comentario set id ='" + en.id + "', cif = '" + aux_empresa.Cif + "', fecha = " + en.fecha_hora + ", en.valoracion = '" + en.valoracion +"' where id = '" + en.id + "and cif ='" + aux_empresa.Cif + "'";
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
                string consulta = "delete from Comentario where id = '" + en.id + " and cif = '" + aux_empresa.Cif + "'";
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
