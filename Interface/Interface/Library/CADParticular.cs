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
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Particular (nif,nombre,apellidos,email,telefono,direccion,iban,clave) VALUES ('"
                    + en.nifUser + "','" + en.nameUser + "','" + en.surNamesUser + "','" + en.emailUser + "','" + en.telfUser + "','" + en.dirUser + "','" + en.ibanUser + "','" + en.passwordUser + "')", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
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
                    en.passwordUser = dr["clave"].ToString();
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
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("UPDATE Particular SET nombre='" + en.nameUser + "', apellidos='" + en.surNamesUser + "', email='" + en.emailUser + "', telefono='"
                    + en.telfUser + "', direccion='" + en.dirUser + "', iban='" + en.ibanUser + "', clave='" + en.passwordUser + "' where nif='" + en.nifUser + "'", c);

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
