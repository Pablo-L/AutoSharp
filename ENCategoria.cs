using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


public class ENCategoria
{
    private int ID;

    private string desc;

    public int id_categoria { get => ID; set => ID = value; }

    public string descripcion { get => desc; set => desc = value; }

    public ENCategoria()
	{
        id_categoria = 0;
        descripcion = null;
    }

    public ENCategoria(int id_, string desc_)
    {
        id_categoria = id_;
        descripcion = desc_;
    }

}
