using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Data.Common;


namespace Library
{
    /// <summary>
    /// CADParticular
    /// </summary>
    public class CADParticular
    {

        private string constring;
        public CADParticular()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
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
                nuevaFila["nif"] = en.nifUser;
                nuevaFila["nombre"] = en.nameUser;
                nuevaFila["apellidos"] = en.surNamesUser;
                nuevaFila["email"] = en.emailUser;
                nuevaFila["telefono"] = en.telfUser;
                nuevaFila["direccion"] = en.dirUser;
                nuevaFila["iban"] = en.ibanUser;
                nuevaFila["contraseña"] = en.passwordUser;
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
        public bool readParticular(ENParticular en)
        {
            bool read = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from Particular", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr["nif"].ToString() == en.nifUser.ToString())
                {
                    read = true;
                    en.nameUser = dr["nombre"].ToString();//cast de object a string
                    en.surNamesUser = dr["apellidos"].ToString();
                    en.emailUser = dr["email"].ToString();
                    en.telfUser = (int) dr["telefono"];//cast a int
                    en.dirUser = dr["direccion"].ToString();
                    en.ibanUser = dr["iban"].ToString();
                    en.passwordUser = dr["contraseña"].ToString();
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
                SqlDataAdapter da = new SqlDataAdapter("select * from Particular where nif = '" + en.nifUser + "'", c);
                da.Fill(bdVirtual, "Particular");
                if (bdVirtual.Tables[0].Rows.Count > 0)
                {
                    //manera propia:(no es la de los apuntes)
                    string consulta = "update Particulr set nif ='" + en.nifUser
                        + "', nombre = '" + en.nameUser
                        + "', apellidos = '" + en.surNamesUser
                        + "', email = '" + en.emailUser
                        + "', telefono = '" + en.telfUser
                        + "', direccion = '" + en.dirUser
                        + "', iban = '" + en.ibanUser
                        + "', contraseña = '" + en.passwordUser
                        + " where id = '" + en.nifUser + "'";//damos por hecho que el nif no cambia

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
                string consulta = "delete from Particular where nif = '" + en.nifUser +"'";
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
