using System;
using System.Collections;

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
        private string codigo;

        /// <summary>
        /// propiedad publica id_
        /// </summary>
        public string Codigo { get => codigo; set => codigo = value; }

        /// <summary>
        /// atributo privado inicioOFerta
        /// </summary>
        private string matricula;

        /// <summary>
        /// propiedad publica inicioOFerta_
        /// </summary>
        public string Matricula { get => matricula; set => matricula = value; }

        private string inicio;

        public string Inicio { get => inicio; set => inicio = value; }

        private string fin;
        public string Fin { get => fin; set => fin = value; }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public ENOferta()
        {

            this.codigo = null;
            this.matricula = null;
            this.inicio = null;
            this.fin = null;

        }

        /// <summary>
        /// constructor por valores
        /// </summary>
        /// <param name="id_"> parametro int id </param>
        /// <param name="inicioOferta_"> parametro fecha iniciooferta </param>
        /// <param name="finOFerta_"> parametro fecha finoferta </param>
        /// <param name="descuento_"> parametro int descuento </param>
        public ENOferta(string codigo, string matricula, string inicio, string fin)
        {
            this.codigo = codigo;
            this.matricula = matricula;
            this.inicio = inicio;
            this.fin = fin;
        }

        /// <summary>
        /// crea una oferta en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createOferta()
        {
            CADOferta en = new CADOferta();
            return en.CreateOferta(this);
        }

        public bool prorrogarOferta()
        {
            CADOferta en = new CADOferta();
            return en.ProrrogarOferta(this);

        }
        public bool eliminarOferta()
        {
            CADOferta en = new CADOferta();
            return en.EliminarOferta(this);

        }

        public bool existsOfertado()
        {
            CADOferta en = new CADOferta();
            return en.ExistsOfertado(this);

        }
        public ArrayList listarOfertas()
        {
            ArrayList a = new ArrayList();
            CADOferta en = new CADOferta();
            a = en.ListarOfertas(this);

            return a;
        }
    }
}