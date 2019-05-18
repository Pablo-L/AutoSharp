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
        /// Atributo privado tama�o
        /// </summary>
        private string tamanyo;

        /// <summary>
        /// Atributo privado contrase�a
        /// </summary>
        private string contrasenya;

        /// <summary>
        /// Propiedad p�blica Cif
        /// </summary>
        public string Cif { get => cif; set => cif = value; }

        /// <summary>
        /// Propiedad p�blica Nombre
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Propiedad p�blica Telefono
        /// </summary>
        public int Telefono { get => telefono; set => telefono = value; }

        /// <summary>
        /// Propiedad p�blica Mail
        /// </summary>
        public string Mail { get => mail; set => mail = value; }

        /// <summary>
        /// Propiedad p�blica Direccion
        /// </summary>
        public string Direccion { get => direccion; set => direccion = value; }

        /// <summary>
        /// Propiedad p�blica Tamanyo
        /// </summary>
        public string Tamanyo { get => tamanyo; set => tamanyo = value; }

        /// <summary>
        /// Propiedad p�blica Contrasenya
        /// </summary>
        public string Contrasenya { get => contrasenya; set => contrasenya = value; }

        public ENEmpresa()
        {
            this.Cif = null;
            this.Nombre = null;
            this.Telefono = null;
            this.Mail = null;
            this.Direccion = null;
            this.Tamanyo = null;
            this.Contrase�a = null;
        }
        
        public ENEmpresa(string cif, string nombre, int telefono, string mail, string direccion, string tamanyo, string contrasenya)
        {
            this.Cif = cif;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Mail = mail;
            this.Direccion = Direccion;
            this.Tamanyo = tamanyo;
            this.Contrasenya = contrasenya;
        }

        public bool createEmpresa()
        {
            CADEmpresa cadc = new CADEmpresa();
            return cadc.insert(this);
        }

        public bool readEmpresa()
        {
            CADEmpresa cadc = new CADEmpresa();
            return cadc.read(this);
        }

        public bool updateEmpresa()
        {
            CADEmpresa cadc = new CADEmpresa();
            return cadc.update(this);
        }

        public bool deleteEmpresa()
        {
            CADEmpresa cadc = new CADEmpresa();
            return cadc.delete(this);
        }

    }
}