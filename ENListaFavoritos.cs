using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


public class ENListaFavoritos
{
    private ENParticular usu;

    private ENVehiculo vehi;

    public ENParticular particular { get => usu; set => usu = value; }

    public ENVehiculo vehiculo { get => vehi; set => vehi = value; }


    public ENListaFavoritos()
    {
        particular = new ENParticular();
        vehiculo = new ENVehiculo();
    }

    public ENListaFavoritos(ENParticular p, ENVehiculo v)
    {
        particular = p;
        vehiculo = v;
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