using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// ENCita
    /// </summary>
    public class ENCita
    {
        private string nif;

        public string Nif { get => nif; set => nif = value; }

        private string cif;

        public string Cif { get => cif; set => cif = value; }
        /// <summary>
        /// Atributo privado ID
        /// </summary>
        private int id;

        /// <summary>
        /// propiedad publica id_
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Atributo privado fecha
        /// </summary>
        private string fecha;

        /// <summary>
        /// propiedad publica fecha_
        /// </summary>
        public string Fecha { get => fecha; set => fecha = value; }

        /// <summary>
        /// Atributo privado motivo
        /// </summary>
        private string motivo;

        /// <summary>
        /// propiedad publica motivo_
        /// </summary>
        public string Motivo { get => motivo; set => motivo = value; }

        /// <summary>
        /// propiedad publica cif
        /// </summary>
        //private int CIFEmpresa { get => cif; set => cif = value; }

        /// <summary>
        /// propiedad publica dni
        /// </summary>
        //private int DNIParticular { get => dni; set => dni = value; }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public ENCita()
        {
            this.Id = 0;
            this.Fecha = null;
            this.Motivo = null;
            this.Nif = null;
            this.Cif = null;
        }

        /// <summary>
        /// Constructor por valor
        /// </summary>
        /// <param name="id_"> Parámetro entero id </param>
        /// <param name="fecha_"> Parámetro datetime fecha </param>
        /// <param name="motivo_"> Parámetro string motivo </param>
        public ENCita(int id, string fecha, string motivo, string cif, string nif)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Motivo = motivo;
            this.Nif = nif;
            this.Cif = cif;
        }

        /// <summary>
        /// crear una cita en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createCita()
        {
            CADCita en = new CADCita();
            return en.createCita(this);
        }

        public ArrayList listarFechas()
        {
            ArrayList a = new ArrayList();
            CADCita c = new CADCita();
            a = c.ListarFechas(this);

            return a;
        }

        public ArrayList listarFechasPorCif()
        {
            ArrayList a = new ArrayList();
            CADCita c = new CADCita();
            a = c.ListarFechasPorCif(this);

            return a;
        }
        public List<ENCita> listarCitas()
        {
            List<ENCita> a = new List<ENCita>();
            CADCita c = new CADCita();
            a = c.ListarCitas(this);

            return a;
        }

        public List<ENCita> listarCitasClientes()
        {
            List<ENCita> a = new List<ENCita>();
            CADCita c = new CADCita();
            a = c.ListarCitasClientes(this);

            return a;
        }


        /// <summary>
        /// lee una cita en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        /*public bool readCita()
        {
            CADCita en = new CADCita();
            return en.readCita(this);
        }

        /// <summary>
        /// actualiza una cita en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateCita()
        {
            CADCita en = new CADCita();
            return en.updateCita(this);
        }

        /// <summary>
        /// borra una cita en la bbdd
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteCita()
        {
            CADCita en = new CADCita();
            return en.deleteCita(this);
        }*/
    }
}