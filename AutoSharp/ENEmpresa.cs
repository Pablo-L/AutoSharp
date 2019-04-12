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
        private string tamaño;
        private string contraseña;

        //read / update
        public string Cif { get => cif; set => cif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        //create
        ENEmpresa(string cif, string nombre, string telefono, string mail, string direccion, string tamaño, string contraseña)
        {
            Cif = cif;
            Nombre = nombre;
            Telefono = telefono;
            Mail = mail;
            Direccion = Direccion;
            Tamaño = tamaño;
            Contraseña = contraseña;

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