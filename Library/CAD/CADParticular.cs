using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Library
{
    /// <summary>
    /// CADParticular
    /// </summary>
    public class CADParticular
    {
        /// <summary>
        /// Cadena de conexión de la base de datos.
        /// </summary>
        private string constring;
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public CADParticular()
        {
            //constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }
        
        /// <summary>
        /// Crea una categoria y la introduce en la base de datos
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>devuelve un bool en funcion de si se crea el particular o no</returns>
        public bool createParticular(ENParticular en)
        {
            bool cambiado = false;
            DataSet bdVirutal = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Particular", c);
                da.Fill(bdVirutal, "Partircular");
                DataTable t = new DataTable();
                t = bdVirutal.Tables["Particular"];
                DataRow nuevaFila = t.NewRow();
                nuevaFila["nif"] = en.nif;
                nuevaFila["nombre"] = en.nombre;
                nuevaFila["apellidos"] = en.apellidos;
                nuevaFila["email"] = en.email;
                nuevaFila["telefono"] = en.telefono;
                nuevaFila["direccion"] = en.direccion;
                nuevaFila["iban"] = en.iban;
                nuevaFila["contraseña"] = en.contraseña;
                t.Rows.Add(nuevaFila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdVirutal, "Particular");
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
        /// Lee un particular de la BBDD
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>devuelve un bool en funcion de si se lee o no</returns>
        public bool readCategoria(ENParticular en)
        {
            bool read = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from Particular", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr["nif"].ToString() == en.nif.ToString())
                {
                    read = true;
                    en.nombre = dr["nombre"].ToString();//cast de object a string
                    en.apellidos = dr["apellidos"].ToString();
                    en.email = dr["email"].ToString();
                    en.telefono = (int) dr["telefono"];//cast a int
                    en.direccion = dr["direccion"].ToString();
                    en.iban = dr["iban"].ToString();
                    en.contraseña = dr["contraseña"].ToString();
                    break;
                }
            }
            return read;
        }

        /// <summary>
        /// modifica un particular en la BBDD
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
        /// <returns>devuelve un bool en funcion de si se a modificado o no</returns>
        public bool updateParticular(ENParticular en)
        {
            bool check = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Particular where nif = '" + en.nif + "'", c);
                da.Fill(bdVirtual, "Particular");
                if (bdVirtual.Tables[0].Rows.Count > 0)
                {
                    //manera propia:(no es la de los apuntes)
                    string consulta = "update Particulr set nif ='" + en.nif 
                        + "', nombre = '" + en.nombre 
                        + "', apellidos = '" + en.apellidos
                        + "', email = '" + en.email
                        + "', telefono = '" + en.telefono
                        + "', direccion = '" + en.direccion
                        + "', iban = '" + en.iban
                        + "', contraseña = '" + en.contraseña
                        + " where id = '" + en.id + "'";//damos por hecho que el nif no cambia

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
        /// borra un particular de la base de datos
        /// </summary>
        /// <param name="en">parametro que recibe de EN</param>
         /// <returns>devuelve un bool en funcion de si se a borrado o no</returns>
        public bool deleteParticular(ENParticular en)
        {
            bool check = false;
                SqlConnection c = new SqlConnection(constring);
                try
                {
                    c.Open();
                    string consulta = "delete from Particular where nif = '" + en.nif +"'";
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

    }
}
