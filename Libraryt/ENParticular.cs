using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENParticular
    {
        private string nif;
        private string name;
        private string surnames;
        private string email;
        private string password;

        public string nifUser
        {
            get { return nif;   }
            set { nif = value;  }
        }
        public string nameUser
        {
            get { return name;  }
            set { name = value; }
        }
        public string surNamesUser 
        {
            get { return surnames;  }
            set { surnames = value; }
        }
        public string emailUser
        {
            get { return email;  }
            set { email = value; }
        }
        public string passwordUser
        {
            get { return password;   }
            set { password = value;  }
        }

        public ENParticular()
        {
            //Set all to null
        }
        //Copy constructor
        public ENParticular(string nif, string name, string surnames, string email, string password)
        {
            nifUser      = nif;
            nameUser     = name;
            surNamesUser = surnames;
            emailUser    = email;
            passwordUser = password;
        }
    }
}
