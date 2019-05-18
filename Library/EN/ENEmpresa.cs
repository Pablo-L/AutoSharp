using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Clase ENEmpresa
    /// </summary>
    public class ENEmpresa
    {
        /// <summary>
        /// Atributo privado cif
        /// </summary>
        private string cif;

        /// <summary>
        /// Atributo privado nombre
        /// </summary>
        private string nombre;

        /// <summary>
        /// Atributo privado telefono
        /// </summary>
        private int telefono;

        /// <summary>
        /// Atributo privado mail
        /// </summary>
        private string mail;

        /// <summary>
        /// Atributo privado direccion
        /// </summary>
        private string direccion;

        /// <summary>
        /// Atributo privado tamaño
        /// </summary>
        private string tamanyo;

        /// <summary>
        /// Atributo privado contraseña
        /// </summary>
        private string contrasenya;

        
        public string Cif { get => cif; set => cif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public ENEmpresa()
        {
            this.Cif = null;
            this.Nombre = null;
            this.Telefono = null;
            this.Mail = null;
            this.Direccion = null;
            this.Tamaño = null;
            this.Contraseña = null;
        }
        
        public ENEmpresa(string cif, string nombre, int telefono, string mail, string direccion, string tamaño, string contraseña)
        {
            this.Cif = cif;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Mail = mail;
            this.Direccion = Direccion;
            this.Tamaño = tamaño;
            this.Contraseña = contraseña;
        }

        public bool createEmpresa()
        {
            CADEmpresa cadc = new CADEmpresa();
            //return cadc.createEmpresa(this);
        }

        public bool readEmpresa()
        {
            CADEmpresa cadc = new CADEmpresa();
            //return cadc.readEmpresa(this);
        }

        public bool updateEmpresa()
        {
            CADEmpresa cadc = new CADEmpresa();
            //return cadc.updateEmpresa(this);
        }

        public bool deleteEmpresa()
        {
            CADEmpresa cadc = new CADEmpresa();
            //return cadc.deleteEmpresa(this);
        }

    }
}