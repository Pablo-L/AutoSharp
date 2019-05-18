using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENConsulta;

namespace Library
{
    //CRUD
    public class CADEmpresa
    {
        private string constring;

        public CADEmpresa()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }

        public bool insert(ENEmpresa en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Empresa (cif,nombre,email,telefono,direccion,tamanyo,contrasenya) VALUES ('"
                    + en.Cif + "','" + en.Nombre + "','" + en.Mail + "','" + en.Telefono + "','" + en.Direccion + "','" + en.Tamaño + "')", c);
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

        public bool read(ENEmpresa en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Empresa where cif = @cif", c);
                com.Parameters.Add(new SqlParameter("@cif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@cif"].Value = en.Cif;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.Cif = dr["cif"].ToString();
                en.Nombre = dr["nombre"].ToString();
                en.Mail = dr["email"].ToString();
                en.Telefono = int.Parse(dr["telefono"].ToString());
                en.Direccion = dr["direccion"].ToString();
                en.Tamaño = dr["tamanyo"].ToString();
                en.Contraseña = dr["contrasenya"].ToString();
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

        public bool update(ENEmpresa en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Update Empresa Set nombre=@nombre, email = @email, telefono = @telefono, direccion = @direccion, tamaño = @tamaño, contraseña = @contraseña where cif = @cif", c);
                com.Parameters.Add(new SqlParameter("@cif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@cif"].Value = en.Cif;
                com.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.NVarChar));
                com.Parameters["email"].Value = en.Mail;
                com.Parameters.Add(new SqlParameter("@telefono", System.Data.SqlDbType.NVarChar));
                com.Parameters["@telefono"].Value = en.Telefono;
                com.Parameters.Add(new SqlParameter("@direccion", System.Data.SqlDbType.NVarChar));
                com.Parameters["@direccion"].Value = en.Direccion;
                com.Parameters.Add(new SqlParameter("@tamanyo", System.Data.SqlDbType.NVarChar));
                com.Parameters["@tamanyo"].Value = en.Tamaño;
                com.Parameters.Add(new SqlParameter("@contrasenya", System.Data.SqlDbType.NVarChar));
                com.Parameters["@contrasenya"].Value = en.Constraseña;
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oferta operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public bool delete(ENEmpresa en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Delete from Empresa where cif = @cif", c);
                com.Parameters.Add(new SqlParameter("@cif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@cif"].Value = en.Cif;
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Empresa ration has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

    }
}