using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// CADListaFavoritos
/// </summary>
public class CADListaFavoritos
{
    /// <summary>
    /// Cadena de conexión a la BBDD.
    /// </summary>
    private string constring;

    /// <summary>
    /// Constructor por defecto
    /// </summary>
	public CADListaFavoritos()
    {
        //constring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
    }

    /// <summary>
    /// Crea una lista de favoritos
    /// </summary>
    /// <param name="en"></param>
    /// <returns></returns>
    public bool createListaFavoritos(ENListaFavoritos en)
    {

    }

    public bool readListaFavoritos(ENListaFavoritos en)
    {

    }

    public bool updateListaFavoritos(ENListaFavoritos en)
    {

    }

    public bool deleteListaFavoritos(ENListaFavoritos en)
    {

    }
}
