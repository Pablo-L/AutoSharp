using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CADReserva
    {
        private string constring;

        public CADReserva()
        {
            constring =
                ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public void createReserva(ENReserva en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Reserva (nif,cif,matricula) VALUES ('" 
                    + en.nifReserva + "','" + en.cifReserva + "','" + en.matriculaReserva + "')", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Reserva operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public void updateReserva(ENReserva en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Update Reserva Set matricula = @matricula where cif = @cif and nif = @nif", c);
                com.Parameters.Add(new SqlParameter("@nif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@nif"].Value = en.nifReserva;
                com.Parameters.Add(new SqlParameter("@cif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@cif"].Value = en.cifReserva;
                com.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.Int));
                com.Parameters["@matricula"].Value = en.matriculaReserva;
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Reserva operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public void deleteReserva(ENReserva en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Delete from Reserva where cif = @cif and nif = @nif", c);
                com.Parameters.Add(new SqlParameter("@nif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@nif"].Value = en.nifReserva;
                com.Parameters.Add(new SqlParameter("@cif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@cif"].Value = en.nifReserva;
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Reserva ration has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public bool readReservation(ENReserva en)
        {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select cif,nif,matricula from Reserva where nif = @nif", c);
                com.Parameters.Add(new SqlParameter("@nif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@nif"].Value = en.nifReserva;
                com.Parameters.Add(new SqlParameter("@cif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@cif"].Value = en.cifReserva;
                com.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.NVarChar));
                com.Parameters["@matricula"].Value = en.matriculaReserva;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.nifReserva = dr["nif"].ToString();
                en.cifReserva = dr["cif"].ToString();
                en.matriculaReserva = dr["matricula"].ToString();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }
    }
}
