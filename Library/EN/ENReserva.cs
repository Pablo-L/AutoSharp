using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Clase ENReserva
    /// </summary>
    public class ENReserva
    {
        /// <summary>
        /// Atributo privado nif
        /// </summary>
        private string nif; //It's supposed to be equal to nifENParticular

        /// <summary>
        /// Atributo privado cif
        /// </summary>
        private string cif;

        /// <summary>
        /// Atributo privado plate (Matricula)
        /// </summary>
        private string plate; //Matricula

        /// <summary>
        /// Atributo privado date
        /// </summary>
        private DateTime date;

        /// <summary>
        /// Atributo privado hour
        /// </summary>
        private int hour;

        /// <summary>
        /// Atributo privado duration
        /// </summary>
        private int duration;

        /// <summary>
        /// Propiedad pública nifReserva
        /// </summary>
        public string nifReserva
        {
            get { return nif;  }
            set { nif = value; }
        }

        /// <summary>
        /// Propiedad pública cifReserva
        /// </summary>
        public string cifReserva
        {
            get { return cif;  }
            set { cif = value; }
        }

        /// <summary>
        /// Propiedad pública plateReserva
        /// </summary>
        public string plateReserva
        {
            get { return plate;   }
            set { plate = value;  }
        }

        /// <summary>
        /// Propiedad pública dateReserva
        /// </summary>
        public DateTime dateReserva
        {
            get { return date;  }
            set { date = value; }
        }

        /// <summary>
        /// Propiedad pública hourReserva
        /// </summary>
        public int hourReserva
        {
            get { return hour;  }
            set { hour = value; }
        }

        /// <summary>
        /// Propiedad pública durationReserva
        /// </summary>
        public int durationReserva
        {
            get { return duration;  }
            set { duration = value; }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENReserva()
        {
            this.nifReserva = null;
            this.cifReserva = cif;
            this.plateReserva = plate;
            this.dateReserva = new DateTime();
            this.hourReserva = 0;
            this.durationReserva = 0;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="nif">Parámetro string nif</param>
        /// <param name="cif">Parámetro string cif</param>
        /// <param name="plate">Parámetro string plate</param>
        /// <param name="date">Parámetro dateTime date</param>
        /// <param name="hour">Parámetro entero hour</param>
        /// <param name="duration">Parámetro entero duration</param>
        public ENReserva(string nif, string cif, string plate, DateTime date, int hour, int duration)
        {
            this.nifReserva      = nif;
            this.cifReserva      = cif;
            this.plateReserva    = plate;
            this.dateReserva     = date;
            this.hourReserva     = hour;
            this.durationReserva = duration;
        }

        /// <summary>
        /// Crea una reserva en la base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createReserva()
        {
            CADReserva en = new CADReserva();
            return en.createReserva(this);
        }

        /// <summary>
        /// Modifica una reserva en la base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateReserva()
        {
            CADReserva en = new CADReserva();
            return en.updateReserva(this);
        }

        /// <summary>
        /// Borra una reserva de la BBDD.
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteReserva()
        {
            CADReserva en = new CADReserva();
            return en.deleteReserva(this);
        }

        /// <summary>
        /// Lee cualquier reserva introducida en la base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readReservation()
        {
            CADReserva en = new CADReserva();
            return en.readReservation(this);
        }

    }
}
