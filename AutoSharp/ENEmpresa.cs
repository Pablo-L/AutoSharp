using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSharp
{
    public class ENEmpresa
    {
        //CreateReadUpdateDelete

        private string cif;
        private string nombre;
        private string telefono;
        private string mail;
        private string direccion;
        private string tama�o;
        private string contrase�a;

        //read / update
        public string Cif { get => cif; set => cif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tama�o { get => tama�o; set => tama�o = value; }
        public string Contrase�a { get => contrase�a; set => contrase�a = value; }

        //create
        ENEmpresa(string cif, string nombre, string telefono, string mail, string direccion, string tama�o, string contrase�a)
        {
            Cif = cif;
            Nombre = nombre;
            Telefono = telefono;
            Mail = mail;
            Direccion = Direccion;
            Tama�o = tama�o;
            Contrase�a = contrase�a;

            CADEmpresa c = new CADEmpresa();
            c.insert(this);
        }

        ENEmpresa(ENEmpresa e)
        {

        }

        //delete
        ~ENConsulta()
        {

        }
    }
}