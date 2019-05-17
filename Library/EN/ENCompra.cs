using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/// <summary>
/// ENCompra representa la compra de un vehículo. Esta clase, contendrá el cif de la empresa vendedora,
/// el dni del comprador particular, la matricula del vehículo vendo y la fecha de la transacción.
/// </summary>
namespace Library
{
    /// <summary>
    /// Clase ENCompra
    /// </summary>
    public class ENCompra
    {
        /// <summary>
        /// Atributo privado comprado (nif)
        /// </summary>
        private string comprador;

        /// <summary>
        /// Atributo privado vendedor (cif)
        /// </summary>
        private string vendedor;

        /// <summary>
        /// Atributo privado vehículo (matricula)
        /// </summary>
        private string vehiculo;

        /// <summary>
        /// Atributo privado fecha
        /// </summary>
        private DateTime fecha;

        /// <summary>
        /// Propiedad pública compradorCompra
        /// </summary>
        public string compradorCompra
        {
            get { return comprador; }
            set { comprador = value; }
        }

        /// <summary>
        /// Propiedad pública vendedorCompra
        /// </summary>
        public string vendedorCompra
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        /// <summary>
        /// Propiedad pública vehiculoCompra
        /// </summary>
        public string vehiculoCompra
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }

        /// <summary>
        /// Propiedad pública fechaCompra
        /// </summary>
        public DateTime fechaCompra
        {
            get { return fecha; }
            set { fecha = value; }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENCompra()
        {
            this.compradorCompra = null;
            this.vendedorCompra = null;
            this.vehiculoCompra = null;
            this.fechaCompra = DateTime.Now;
        }

        /// <summary>
        /// Constructor por valor
        /// </summary>
        /// <param name="comprador">Parámetro string comprador</param>
        /// <param name="vendedor">Parámetro string vendedor</param>
        /// <param name="vehiculo">Parámetro string vehiculo</param>
        /// <param name="fecha">Parámetro DateTime fecha</param>
        public ENCompra(string comprador, string vendedor, string vehiculo, DateTime fecha)
        {
            this.compradorCompra = comprador;
            this.vendedorCompra = vendedor;
            this.vehiculoCompra = vehiculo;
            this.fechaCompra = fecha;
        }

        /// <summary>
        /// Crea la compra indicada en la base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createCompra()
        {
            CADCompra cadc = new CADCompra();
            return cadc.createCompra(this);
        }

        /// <summary>
        /// Lee la compra indicada dela base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readCompra()
        {
            CADCompra cadc = new CADCompra();
            return cadc.readCompra(this);
        }

        /// <summary>
        /// Borra la compra indicada de la base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteCompra()
        {
            CADCompra cadc = new CADCompra();
            return cadc.deleteCompra(this);
        }

        /// <summary>
        /// Actualiza la compra indicada de la base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateCompra()
        {
            CADCompra cadc = new CADCompra();
            return cadc.updateCompra(this);
        }
    }
}