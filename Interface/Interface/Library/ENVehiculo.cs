using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Library
{
	public class ENVehiculo
	{
        private string imagen;
        /// <summary>
        /// Atributo privado matricula
        /// </summary>
        private string matricula;
        /// <summary>
        /// Atributo privado marca
        /// </summary>
        private string marca;
        /// <summary>
        /// Atributo privado modelo
        /// </summary>
        private string modelo;
        /// <summary>
        /// Atributo privado color
        /// </summary>
        private string color;
        /// <summary>
        /// Atributo privado combustible
        /// </summary>
        private string combustible;
        /// <summary>
        /// Atributo privado año
        /// </summary>
        private int año;
        /// <summary>
        /// Atributo privado kilometros
        /// </summary>
        private float kilometros;
        /// <summary>
        /// Atributo privado precio
        /// </summary>
        private float precio;
        /// <summary>
        /// Atributo privado potencia
        /// </summary>
        private int potencia;
        /// <summary>
        /// Atributo privado comprador (cif)
        /// </summary>
        private string comprador;
        /// <summary>
        /// Atributo privador vendedor (nif)
        /// </summary>
        private string vendedor;
        private string descripcion;
        public string descripcionVehiculo
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string imagenVehiculo
        {
            get { return imagen; }
            set { imagen = value; }
        }
        /// <summary>
        /// Propiedad pública de matricula
        /// </summary>
        public string matriculaVehiculo
        {
            get { return matricula;  }
            set { matricula = value; }
        }
        /// <summary>
        /// Propiedad pública de marca
        /// </summary>
        public string marcaVehiculo
        {
            get { return marca; }
            set { marca = value; }
        }
        /// <summary>
        /// Propiedad pública de modelo
        /// </summary>
        public string modeloVehiculo
        {
            get { return modelo;  }
            set { modelo = value; }
        }
        /// <summary>
        /// Propiedad pública de color
        /// </summary>
        public string colorVehiculo
        {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// Propiedad pública de combustible
        /// </summary>
        public string combustibleVehiculo
        {
            get { return combustible; }
            set { combustible = value; }
        }
        /// <summary>
        /// Propiedad pública de año
        /// </summary>
        public int añoVehiculo
        {
            get { return año; }
            set { año = value; }
        }
        /// <summary>
        /// Propiedad pública de kilometros
        /// </summary>
        public float kilometrosVehiculo
        {
            get { return kilometros; }
            set { kilometros = value; }
        }
        /// <summary>
        /// Propiedad pública de precio
        /// </summary>
        public float precioVehiculo
        {
            get { return precio; }
            set { precio = value; }
        }
        /// <summary>
        /// Propiedad pública de potencia
        /// </summary>
        public int potenciaVehiculo
        {
            get { return potencia; }
            set { potencia = value; }
        }
        /// <summary>
        /// Propiedad pública de vendedor
        /// </summary>
        public string vendedorVehiculo
        {
            get { return vendedor; }
            set { vendedor = value; }
        }
        /// <summary>
        /// Propiedad pública de comprador
        /// </summary>
        public string compradorVehiculo
        {
            get { return comprador; }
            set { comprador = value; }
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENVehiculo()
        {
            matricula = null;
            marca = null;
            modelo = null;
            color = null;
            combustible = null;
            año = 0;
            kilometros = 0;
            precio = 0.0F;
            potencia = 0;
            comprador = null;
            vendedor = null;
            imagen = null;
            descripcion = null;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        public ENVehiculo(string matricula, string marca, string modelo, string color, string combustible, int año, float kilometros, float precio, int potencia, string comprador, string vendedor, string imagen, string descripcion)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.combustible = combustible;
            this.año = año;
            this.kilometros = kilometros;
            this.precio = precio;
            this.potencia = potencia;
            this.comprador = comprador;
            this.vendedor = vendedor;
            this.imagen = imagen;
            this.descripcion = descripcion;
        }
        /// <summary>
        /// Crea el véhículo indicado en la base de datos (alta vehículo)
        /// </summary>
        /// <returns></returns>
        public bool createVehiculo()
        {
            CADVehiculo cadv = new CADVehiculo();
            return cadv.createVehiculo(this);
        }
        /// <summary>
        /// Lee el vehículo indicado de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool readVehiculo()
        {
            CADVehiculo cadv = new CADVehiculo();
            return cadv.readVehiculo(this);
        }
        /// <summary>
        /// Borra el vehículo indicado de la base de datos(baja vehículo)
        /// </summary>
        /// <returns></returns>
        public bool deteleVehiculo()
        {
            CADVehiculo cadv = new CADVehiculo();
            return cadv.deleteVehiculo(this);
        }
        /// <summary>
        /// Actualiza el vehículo indicado de la base de datos
        /// </summary>
        public bool updateVehiculo()
        {
            CADVehiculo cadv = new CADVehiculo();
            return cadv.updateVehiculo(this);
        }
        public List<ENVehiculo> listarVehiculos()
        {
            List<ENVehiculo> a = new List<ENVehiculo>();
            CADVehiculo c = new CADVehiculo();
            a = c.ListarVehiculos(this);

            return a;
        }
        public ArrayList listarVehiculosPorEmpresa()
        {
            ArrayList a = new ArrayList();
            CADVehiculo c = new CADVehiculo();
            a = c.ListarVehiculosPorEmpresa(this);

            return a;
        }
    }
}
