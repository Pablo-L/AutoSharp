using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


public class ENListaFavoritos
{
    private int ID;

    private string desc;

    public int id_categoria { get => ID; set => ID = value; }

    public string descripcion { get => desc; set => desc = value; }

    public ENListaFavoritos()
    {
        id_categoria = 0;
        descripcion = null;
    }

    public ENListaFavoritos(int id_, string desc_)
    {
        id_categoria = id_;
        descripcion = desc_;
    }

    public bool createListaFavoritos()
    {
        CADListaFavoritos cadlf = new CADListaFavoritos();
        return cadlf.createListaFavoritos(this);
    }
    
    public bool readListaFavoritos()
    {
        CADListaFavoritos cadlf = new CADListaFavoritos();
        return cadlf.readListaFavoritos(this);
    }

    public bool updateListaFavoritos()
    {
        CADListaFavoritos cadlf = new CADListaFavoritos();
        return cadlf.updateListaFavoritos(this);
    }

    public bool deleteListaFavoritos()
    {
        CADListaFavoritos cadlf = new CADListaFavoritos();
        return cadlf.deleteListaFavoritos(this);
    }


}