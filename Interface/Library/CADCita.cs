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


namespace Library
{
	public class CADCita
	{
        /// <summary>
        /// Cadena de conexión a la BBDD
        /// </summary>
        ENParticular aux_particular = new ENParticular();
        ENEmpresa aux_empresa = new ENEmpresa();
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
            bool cambiado = false;
            DataSet bdVirutal = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from Cita", c);
                da.Fill(bdVirutal, "Cita");
                DataTable t = new DataTable();
                t = bdVirutal.Tables["Cita"];
                DataRow nuevaFila = t.NewRow();
                nuevaFila["id"] = en.id_;
                nuevaFila["cif"] = aux_empresa.Cif;
                nuevaFila["fecha"] = en.fecha_;
                nuevaFila["motivo"] = en.motivo_;
                nuevaFila["nif"] = aux_particular.nifUser;
                t.Rows.Add(nuevaFila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdVirutal, "Cita");
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
        /// Lee una cita de la base de datos
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>devuelve un bool en funcion de si se borra con exito o no</returns>
        public bool readCita(ENCita en) 
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
            catch (Exception ex)
            { 
                /*tratar label*/
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
            catch (Exception ex) 
            { 
                /*tratar label*/
            }
            finally { c.Close(); }
            return check;
        }        
        

        //public void importNextCADCita(ENCita enCita) { }

        //public void importPrevCADCita(ENCita enCita) { }

    }
}