using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Clase ENParticular
    /// </summary>
    public class ENParticular
    {
        /// <summary>
        /// Atributo privado nif
        /// </summary>
        private string nif;

        /// <summary>
        /// Atributo privado name
        /// </summary>
        private string name;

        /// <summary>
        /// Atributo privado surnames
        /// </summary>
        private string surnames;

        /// <summary>
        /// Atributo privado email
        /// </summary>
        private string email;

        /// <summary>
        /// Atributo privado password
        /// </summary>
        private string password;

        /// <summary>
        /// Atributo privado ListaFav
        /// </summary>
        private List<ENVehiculo> Listafav;

        /// <summary>
        /// Propiedad pública nifUser
        /// </summary>
        public string nifUser
        {
            get { return nif;   }
            set { nif = value;  }
        }

        /// <summary>
        /// Propiedad pública nameUser
        /// </summary>
        public string nameUser
        {
            get { return name;  }
            set { name = value; }
        }

        /// <summary>
        /// Propiedad pública surNamesUser
        /// </summary>
        public string surNamesUser 
        {
            get { return surnames;  }
            set { surnames = value; }
        }

        /// <summary>
        /// Propiedad pública emailUser
        /// </summary>
        public string emailUser
        {
            get { return email;  }
            set { email = value; }
        }

        /// <summary>
        /// Propiedad pública passwordUser
        /// </summary>
        public string passwordUser
        {
            get { return password;   }
            set { password = value;  }
        }

        /// <summary>
        /// Propiedad pública ListaFavoritos
        /// </summary>
        public List<ENVehiculo> ListaFavoritos
        {
            get { return Listafav; }
            set { Listafav = value; }
        }

        /// <summary>
        /// Contructor por defecto
        /// </summary>
        public ENParticular()
        {
            this.nifUser = null;
            this.nameUser = null;
            this.surNamesUser = null;
            this.emailUser = null;
            this.passwordUser = null;
            this.ListaFavoritos = List<ENVehiculo>;
        }
        
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="name"></param>
        /// <param name="surnames"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public ENParticular(string nif, string name, string surnames, string email, string password)
        {
            this.nifUser      = nif;
            this.nameUser     = name;
            this.surNamesUser = surnames;
            this.emailUser    = email;
            this.passwordUser = password;
        }

        /// <summary>
        /// Crea a un nuevo particular en la base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool createParticular()
        {
            CADParticular en = new CADParticular();
            return en.createParticular(this);

        }

        /// <summary>
        /// Modifica un particular de la BBDD
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool updateParticular()
        {
            CADParticular en = new CADParticular();
            return en.updateParticular(this);
        }

        /// <summary>
        /// Borra a un particular de la BBDD
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool deleteParticular()
        {
            CADParticular en = new CADParticular();
            return en.deleteParticular(this);
        }

        /// <summary>
        /// Lee a un particular de la base de datos
        /// </summary>
        /// <returns>Devuelve true si la operación se realiza correctamente</returns>
        public bool readParticular()
        {
            CADParticular en = new CADParticular();
            return en.readParticular(this);
        }
    }
}
