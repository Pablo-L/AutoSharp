﻿using System;
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
    public class CADCategoria
    {
        
        private string constring;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
	    public CADCategoria()
	    {
            constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        }

        /// <summary>
        /// Crea una categoria.
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool createCategoria(ENCategoria en)
        {
            bool cambiado = false;
            DataSet bdVirutal = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Categoria", c);
                da.Fill(bdVirutal, "Categoria");
                DataTable t = new DataTable();
                t = bdVirutal.Tables["Categoria"];
                DataRow nuevaFila = t.NewRow();
                nuevaFila["id"] = en.id_categoria;
                nuevaFila["descripcion"] = en.descripcion;
                nuevaFila["simbolo"] = en.symbol;
                t.Rows.Add(nuevaFila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdVirutal, "Categoria");
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
        /// Lee una categoria seleccionada de la base de datos.
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readCategoria(ENCategoria en)
        {
            bool read = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("select * from Categoria", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr["id"].ToString() == en.id_categoria.ToString())
                {
                    read = true;
                    en.descripcion = dr["descripcion"].ToString();//cast de object a string
                    en.symbol = dr["simbolo"].ToString();
                    break;
                }
            }
            return read;
        }

        /// <summary>
        /// Actualiza una categoria de la base de datos.
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool updateCategoria(ENCategoria en)
        {
            bool check = false;
            DataSet bdVirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Categoria where id = '" + en.id_categoria + "'", c);
                da.Fill(bdVirtual, "Categoria");
                if (bdVirtual.Tables[0].Rows.Count > 0)
                {
                    //manera propia:
                    string consulta = "update Categoria set id ='" + en.id_categoria + "', descripcion = '" + en.descripcion + "', simbolo = " + en.symbol + " where id = '" + en.id_categoria + "'";//damos por hecho que el id

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
        /// Elimina una categoria de la base de datos.
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool deleteCategoria(ENCategoria en)
        {
                bool check = false;
                SqlConnection c = new SqlConnection(constring);
                try
                {
                    c.Open();
                    string consulta = "delete from Categoria where id = '" + en.id_categoria +"'";
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
