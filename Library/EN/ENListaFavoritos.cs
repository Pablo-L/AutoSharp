using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/// <summary>
/// ENListaFavoritos.
/// </summary>
public class ENListaFavoritos
{
    /// <summary>
    /// Atributo privado usu (usuario).
    /// </summary>
    private ENParticular usu;

    /// <summary>
    /// Atributo privado vehi (vehiculo).
    /// </summary>
    private ENVehiculo vehi;

    /// <summary>
    /// Propiedad pública particular.
    /// </summary>
    public ENParticular particular { get => usu; set => usu = value; }

    /// <summary>
    /// Propiedad pública vehiculo.
    /// </summary>
    public ENVehiculo vehiculo { get => vehi; set => vehi = value; }

    /// <summary>
    /// Constructor por defecto.
    /// </summary>
    public ENListaFavoritos()
    {
        particular = new ENParticular();
        vehiculo = new ENVehiculo();
    }

    /// <summary>
    /// Constructor de copia.
    /// </summary>
    /// <param name="p"></param>
    /// <param name="v"></param>
    public ENListaFavoritos(ENParticular p, ENVehiculo v)
    {
        particular = p;
        vehiculo = v;
    }

    /// <summary>
    /// Crea una lista de favoritos en la BBDD.
    /// </summary>
    /// <returns></returns>
    public bool createListaFavoritos()
    {
        CADListaFavoritos cadlf = new CADListaFavoritos();
        return cadlf.createListaFavoritos(this);
    }
    
    /// <summary>
    /// Lee una lista de favoritos de la base de datos.
    /// </summary>
    /// <returns></returns>
    public bool readListaFavoritos()
    {
        CADListaFavoritos cadlf = new CADListaFavoritos();
        return cadlf.readListaFavoritos(this);
    }

    /// <summary>
    /// Actualiza una lista de favoritos de la base de datos.
    /// </summary>
    /// <returns></returns>
    public bool updateListaFavoritos()
    {
        CADListaFavoritos cadlf = new CADListaFavoritos();
        return cadlf.updateListaFavoritos(this);
    }

    /// <summary>
    /// Elimina una lista de favoritos de la BBDD.
    /// </summary>
    /// <returns></returns>
    public bool deleteListaFavoritos()
    {
        CADListaFavoritos cadlf = new CADListaFavoritos();
        return cadlf.deleteListaFavoritos(this);
    }
}