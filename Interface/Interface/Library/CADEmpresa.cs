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
using System.Collections;

namespace Library
{
    //CRUD
    public class CADEmpresa
    {
        private string constring;
        ArrayList lista = new ArrayList();

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
                    + en.Cif + "','" + en.Nombre + "','" + en.Mail + "','" + en.Telefono + "','" + en.Direccion + "','" + en.Tamanyo + "','" + en.Contrasenya + "')", c);
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
                SqlCommand com = new SqlCommand("Select * from Empresa where cif='" + en.Cif + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.Cif = dr["cif"].ToString();
                en.Nombre = dr["nombre"].ToString();
                en.Mail = dr["email"].ToString();
                en.Telefono = int.Parse(dr["telefono"].ToString());
                en.Direccion = dr["direccion"].ToString();
                en.Tamanyo = dr["tamanyo"].ToString();
                en.Contrasenya = dr["contrasenya"].ToString();
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
                SqlCommand com = new SqlCommand("Update Empresa Set nombre='" + en.Nombre + "', email='" + en.Mail + "', telefono='" + en.Telefono
                    + "', direccion='" + en.Direccion + "', tamanyo='" + en.Tamanyo + "', contrasenya='" + en.Contrasenya + "' where cif='" + en.Cif + "'", c);
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

        public ArrayList ListarEmpresas(ENEmpresa en)
        {
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Empresa", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["nombre"].ToString());
            }
            dr.Close();
            c.Close();
            return lista;
        }

    }
}