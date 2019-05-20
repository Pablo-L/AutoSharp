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
namespace library
{
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
        private string matricula;
        /// <summary>
        /// Atributo privado fecha
        /// </summary>
        private DateTime fecha;
        /// <summary>
        /// Propiedad pública comprador
        /// </summary>
        public string compradorCompra
        {
            get { return comprador; }
            set { comprador = value; }
        }
        /// <summary>
        /// Propiedad pública vendedor
        /// </summary>
        public string vendedorCompra
        {
            get { return vendedor; }
            set { vendedor = value; }
        }
        /// <summary>
        /// Propiedad pública vehiculo
        /// </summary>
        public string vehiculoCompra
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }
        /// <summary>
        /// Propiedad pública fecha
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
            comprador = null;
            vendedor = null;
            vehiculo = null;
            fecha = DateTime.Now;
        }
        /// <summary>
        /// Constructor por valor
        /// </summary>
        /// <param name="comprador"></param>
        /// <param name="vendedor"></param>
        /// <param name=""></param>
        public ENCompra(string comprador, string vendedor, string vehiculo, DateTime fecha)
        {
            this.comrpador = comprador;
            this.vendedor = vendedor;
            this.vehiculo = vehiculo;
            this.fecha = fecha;
        }
        /// <summary>
        /// Crea la compra indicada en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool createCompra()
        {
            CADCompra cadc = new CADCompra();
            return cadc.createCompra(this);
        }
        /// <summary>
        /// Lee la compra indicada dela base de datos
        /// </summary>
        /// <returns></returns>
        public bool readCompra()
        {
            CADCompra cadc = new CADCompra();
            return cadc.readCompra(this);
        }
        /// <summary>
        /// Borra la compra indicada de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool deleteCompra()
        {
            CADCompra cadc = new CADCompra();
            return cadc.deleteCompra(this);
        }
        /// <summary>
        /// Actualiza la compra indicada de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool updateCompra()
        {
            CADCompra cadc = new CADCompra();
            return cadc.updateCompra(this);
        }

    }
}
