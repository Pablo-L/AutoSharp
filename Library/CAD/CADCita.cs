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

namespace library
{
	public class CADCita
	{
        /// <summary>
        /// Cadena de conexión a la BBDD
        /// </summary>
        private string constring;
        //public string Constring { get => constring; set => constring = value; }

        /// <summary>
        /// Inicilaiza la conexion a la BBDD
        /// </summary>
        public CADCita() 
        {
            //constring = ConfigurationManager.ConnectionStrings["conexion"].ToString();        
        }
        
        /// <summary>
        /// Crea una cita en la BBDD
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>retorna un bool en función de si se crea o no </returns>
        public bool createCADCita(ENCita en)
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
                nuevaFila["id"] = en.id;
                nuevaFila["cif"] = en.cif;
                nuevaFila["fecha"] = en.fecha;
                nuevaFila["motivo"] = en.motivo;
                nuevaFila["nif"] = en.nif;
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
        public bool readCADCita(ENCita en) 
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
                if (dr["id"].ToString() == en.id.ToString() && dr["cif"].ToString() == en.cif.ToString())
                {
                    read = true;
                    en.fecha = dr["fecha"].ToString();//cast de object a string
                    en.motivo = dr["motivo"].ToString();
                    en.nif = (int) dr["nif"];
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
        public bool updateCADCita(ENCita en) 
        {
            bool check = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Cita where id = '" + en.id + "'", c);
                da.Fill(bdVirtual, "Cita");
                if (bdVirtual.Tables[0].Rows.Count > 0)
                {
                    //manera propia:
                    string consulta = "update Cita set id ='" + en.id + "', cif = '" + en.cif + "', fecha = " + en.fecha + " where id = '" + en.id + "and cif ='"+ en.cif +"'";//damos por hecho que id y cif no se cambia

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
        public bool delete(ENCita en) 
        {
            bool check = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                string consulta = "delete from Cita where id = '" + en.id+" and cif = '"+en.cif+"'";
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

        //public void importNextCADCita(ENCita enCita) { }

        //public void importPrevCADCita(ENCita enCita) { }

    }
}