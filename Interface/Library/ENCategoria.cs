using System;

namespace Library
{
    /// <summary>
    /// ENCategoria
    /// </summary>
    public class ENCategoria
    {
        /// <summary>
        /// Atributo privado ID.
        /// </summary>
        private int ID;

        /// <summary>
        /// Atributo privado desc.
        /// </summary>
        private string desc;

        /// <summary>
        /// Atributo privado sym.
        /// </summary>
        private string sym;

        /// <summary>
        /// Atributo privado vehi (Vehiculo)
        /// </summary>
        private ENVehiculo vehi;

        /// <summary>
        /// Propiedad pública id_categoria.
        /// </summary>
        public int id_categoria { get => ID; set => ID = value; }

        /// <summary>
        /// Propiedad pública descripcion.
        /// </summary>
        public string descripcion { get => desc; set => desc = value; }

        /// <summary>
        /// Propiedad pública symbol.
        /// </summary>
        public string symbol { get => sym; set => sym = value; }

        /// <summary>
        /// Propiedad pública vehiculo.
        /// </summary>
        public ENVehiculo vehiculo { get => vehi; set => vehi = value; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENCategoria()
        {
            id_categoria = 0;
            descripcion = null;
            symbol = null;
            vehiculo = new ENVehiculo();
        }

        /// <summary>
        /// Constructor por valor
        /// </summary>
        /// <param name="id_"> Parámetro entero id_ </param>
        /// <param name="desc_"> Parámetro string desc_ </param>
        /// <param name="symbol_"> Parámetro string symbol_ </param>
        /// <param name="vehi_"> Parámetro ENVehiculo vehi_ </param>
        public ENCategoria(int id_, string desc_, string symbol_, ENVehiculo vehi_)
        {
            id_categoria = id_;
            descripcion = desc_;
            symbol = symbol_;
            vehiculo = vehi_;
        }

        /// <summary>
        /// Crea una categoria en la BBDD.
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createCategoria()
        {
            CADCategoria cadc = new CADCategoria();
            return cadc.createCategoria(this);
        }

        /// <summary>
        /// Lee una categoria de la BBDD.
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readCategoria()
        {
            CADCategoria cadc = new CADCategoria();
            return cadc.readCategoria(this);
        }

        /// <summary>
        /// Actualiza una categoria de la base de datos.
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateCategoria()
        {
            CADCategoria cadc = new CADCategoria();
            return cadc.updateCategoria(this);
        }

        /// <summary>
        /// Elimina una categoria de la base de datos.
        /// </summary>
        /// <returns> Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteCategoria()
        {
            CADCategoria cadc = new CADCategoria();
            return cadc.deleteCategoria(this);
        }
    }
}