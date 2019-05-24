using System;

namespace Library
{
    /// <summary>
    /// ENOFerta
    /// </summary>
    public class ENOferta
    {
        /// <summary>
        /// atributo privado id
        /// </summary>
        private string id;

        /// <summary>
        /// propiedad publica id_
        /// </summary>
        public string id_ { get => id; set => id = value; }

        /// <summary>
        /// atributo privado inicioOFerta
        /// </summary>
        private string inicioOferta;

        /// <summary>
        /// propiedad publica inicioOFerta_
        /// </summary>
        public string inicioOferta_ { get => inicioOferta; set => inicioOferta = value; }

        /// <summary>
        /// atributo privado finOferta
        /// </summary>
        private string finOferta;

        /// <summary>
        /// propiedad publica finOferta_
        /// </summary>
        public string finOferta_ { get => finOferta; set => finOferta = value; }

        /// <summary>
        /// atributo privado descuento
        /// </summary>
        private int descuento;

        /// <summary>
        /// propiedad publica descuento_
        /// </summary>
        public int descuento_ { get => descuento; set => descuento = value; }

        /// <summary>
        /// propiedad publica matricula_
        /// </summary>
        //private int matricula_ { get => matricula; set => matricula = value; }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public ENOferta() {

            this.id_ = null;
            this.inicioOferta_ = null;
            this.finOferta_ = null;
            this.descuento_ = 0;

        }

        /// <summary>
        /// constructor por valores
        /// </summary>
        /// <param name="id_"> parametro int id </param>
        /// <param name="inicioOferta_"> parametro string iniciooferta </param>
        /// <param name="finOFerta_"> parametro string finoferta </param>
        /// <param name="descuento_"> parametro int descuento </param>
        public ENOferta(string id_, string inicioOferta_, string finOFerta_, int descuento_)
        {
            this.id_ = id_;
            this.inicioOferta_ = inicioOferta_;
            this.finOferta_ = finOferta_;
            this.descuento_ = descuento_;
        }

        /// <summary>
        /// crea una oferta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createOferta()
        {
            CADOferta en = new CADOferta();
            return en.createOferta(this);
        }

        /// <summary>
        /// lee una oferta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readOferta()
        {
            CADOferta en = new CADOferta();
            return en.readOferta(this);
        }

        /// <summary>
        /// actualizan una oferta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateOferta()
        {
            CADOferta en = new CADOferta();
            return en.updateOferta(this);
        }

        /// <summary>
        /// borra una oferta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteOferta()
        {
            CADOferta en = new CADOferta();
            return en.deleteOferta(this);
        }
    }
}