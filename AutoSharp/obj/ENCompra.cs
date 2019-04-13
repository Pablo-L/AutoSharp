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
        private string vehiculo;
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
    }
}
