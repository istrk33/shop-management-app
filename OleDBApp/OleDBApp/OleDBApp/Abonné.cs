using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleDBApp
{
    public class Abonné
    {
        public int Code_Abonné { get; }
        public string Nom_Abonné { get; }
        public string Prénom_Abonné { get; }
        public string Login { get; }
        public string Password { get; }
        public int Code_Pays { get; }

        public Abonné(int Code_Abonné, string Nom_Abonné, string Prénom_Abonné, string Login, string Password, int Code_Pays)
        {
            this.Code_Abonné = Code_Abonné;
            this.Nom_Abonné = Nom_Abonné;
            this.Prénom_Abonné = Prénom_Abonné;
            this.Login = Login;
            this.Password = Password;
            this.Code_Pays = Code_Pays;
        }
        override
        public string ToString()
        {
            return Nom_Abonné.Trim() + " " + Prénom_Abonné.Trim();
        }
    }
}
