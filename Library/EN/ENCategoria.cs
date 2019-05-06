using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/// <summary>
/// ENCategoria
/// </summary>
public class ENCategoria
{
    /// <summary>
    /// Atributo privado ID.
    /// </summary>
    private int ID;

    /// <summary>
    /// Atributo privado desc.
    /// </summary>
    private string desc;

    /// <summary>
    /// Atributo privado sym.
    /// </summary>
    private string sym;

    /// <summary>
    /// Atributo privado vehi (Vehiculo)
    /// </summary>
    private ENVehiculo vehi;

    /// <summary>
    /// Propiedad pública id_categoria.
    /// </summary>
    public int id_categoria { get => ID; set => ID = value; }

    /// <summary>
    /// Propiedad pública descripcion.
    /// </summary>
    public string descripcion { get => desc; set => desc = value; }

    /// <summary>
    /// Propiedad pública symbol.
    /// </summary>
    public string symbol { get => sym; set => sym = value; }
    
    /// <summary>
    /// Constructor por defecto
    /// </summary>
    public ENCategoria()
	{
        id_categoria = 0;
        descripcion = null;
    }

    /// <summary>
    /// Constructor de copia
    /// </summary>
    /// <param name="id_"></param>
    /// <param name="desc_"></param>
    public ENCategoria(int id_, string desc_)
    {
        id_categoria = id_;
        descripcion = desc_;
    }

    /// <summary>
    /// Crea una categoria en la BBDD.
    /// </summary>
    /// <returns></returns>
    public bool createCategoria()
    {
        CADCategoria cadc = new CADCategoria();
        return cadc.createCategoria(this);
    }

    /// <summary>
    /// Lee una categoria de la BBDD.
    /// </summary>
    /// <returns></returns>
    public bool readCategoria()
    {
        CADCategoria cadc = new CADCategoria();
        return cadc.readCategoria(this);
    }

    /// <summary>
    /// Actualiza una categoria de la base de datos.
    /// </summary>
    /// <returns></returns>
    public bool updateCategoria()
    {
        CADCategoria cadc = new CADCategoria();
        return cadc.updateCategoria(this);
    }

    /// <summary>
    /// Elimina una categoria de la base de datos.
    /// </summary>
    /// <returns></returns>
    public bool deleteCategoria()
    {
        CADCategoria cadc = new CADCategoria();
        return cadc.deleteCategoria(this);
    }
}
