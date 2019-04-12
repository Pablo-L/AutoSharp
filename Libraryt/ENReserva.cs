using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENReserva
    {
        private string nif; //It's supposed to be equal to nifENParticular
        private string cif;
        private string plate; //Matricula
        private string date;
        private int hour;
        private int duration;

        public string nifReserva
        {
            get { return nif;  }
            set { nif = value; }
        }
        public string cifReserva
        {
            get { return cif;  }
            set { cif = value; }
        }
        public string plateReserva
        {
            get { return plate;   }
            set { plate = value;  }
        }
        public string dateReserva
        {
            get { return date;  }
            set { date = value; }
        }
        public int hourReserva
        {
            get { return hour;  }
            set { hour = value; }
        }
        public int durationReserva
        {
            get { return duration;  }
            set { duration = value; }
        }

        public ENReserva()
        {
            //Set all to null or 0
        }
        //Copy constructor
        public ENReserva(string nif, string cif, string plate, string date, int hour, int duration)
        {
            nifReserva      = nif;
            cifReserva      = cif;
            plateReserva    = plate;
            dateReserva     = date;
            hourReserva     = hour;
            durationReserva = duration;
        }

    }
}
