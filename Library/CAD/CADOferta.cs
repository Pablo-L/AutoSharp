using System;

namespace library
{
    public class CADOferta
    {

        private string constring;

        public CADOferta() {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }


        public bool createCADOferta(ENOferta en) {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open(); // Faltan las propiedades públicas en el en
                SqlCommand com = new SqlCommand("Insert Into Oferta (id, fecha_inicio, fecha_fin, descuento, matricula) VALUES ('"
                    + en.idOferta + "','" + en.inicioOferta + "','" + en.finOferta + "','" + en.descuentoOferta + en.matriculaOferta + "')", c);
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vehiculo operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        public bool readCADOferta(ENOferta en) {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Oferta where id = @id", c);
                com.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.NVarChar));
                com.Parameters["@id"].Value = en.idOferta;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                en.idOferta = int.Parse(dr["id"].ToString());
                en.inicioOferta = dr["fecha_inicio"].ToString();
                en.finOferta = dr["fecha_fin"].ToString();
                en.descuentoOferta = dr["descuento"].ToString();
                en.matriculaOferta = dr["matricula"].ToString();
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

        public bool updateCADOferta(ENOferta enOferta) {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Update Vehiculo Set fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, matricula = @matricula where id = @id", c);
                com.Parameters.Add(new SqlParameter("@fecha_inicio", System.Data.SqlDbType.NVarChar));
                com.Parameters["@fecha_inicio"].Value = en.inicioOferta;
                com.Parameters.Add(new SqlParameter("@fecha_fin", System.Data.SqlDbType.NVarChar));
                com.Parameters["@fecha_fin"].Value = en.inicioOferta;
                com.Parameters.Add(new SqlParameter("@matricula", System.Data.SqlDbType.NVarChar));
                com.Parameters["@matricula"].Value = en.matriculaOferta;
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

        public bool deleteCADOferta(ENOferta enOferta) {
            bool transaction = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("Delete from Oferta where id = @id", c);
                com.Parameters.Add(new SqlParameter("@nif", System.Data.SqlDbType.NVarChar));
                com.Parameters["@id"].Value = en.idOferta;
                com.ExecuteNonQuery();
                transaction = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oferta ration has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }
            return transaction;
        }

        //public void importNextCADOferta(ENCita enOferta) { }

        //public void importPrevCADOferta(ENCita enOferta) { }

    }
}