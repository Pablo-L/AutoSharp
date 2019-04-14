using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// CADCategoria
/// </summary>
public class CADCategoria
{
    /// <summary>
    /// Cadena de conexión de la base de datos.
    /// </summary>
    private string constring;

    /// <summary>
    /// Constructor por defecto.
    /// </summary>
	public CADCategoria()
	{
        //constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
    }

    /// <summary>
    /// Crea una categoria.
    /// </summary>
    /// <param name="en"></param>
    /// <returns></returns>
    public bool createCategoria(ENCategoria en)
    {

    }

    /// <summary>
    /// Lee una categoria seleccionada de la base de datos.
    /// </summary>
    /// <param name="en"></param>
    /// <returns></returns>
    public bool readCategoria(ENCategoria en)
    {

    }

    /// <summary>
    /// Actualiza una categoria de la base de datos.
    /// </summary>
    /// <param name="en"></param>
    /// <returns></returns>
    public bool updateCategoria(ENCategoria en)
    {

    }

    /// <summary>
    /// Elimina una categoria de la base de datos.
    /// </summary>
    /// <param name="en"></param>
    /// <returns></returns>
    public bool deleteCategoria(ENCategoria en)
    {

    }
}
