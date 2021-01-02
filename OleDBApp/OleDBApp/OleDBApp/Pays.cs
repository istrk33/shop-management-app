using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleDBApp
{
    class Pays
    {
        public int Code_Pays { get; }
        public string Nom_Pays { get; }

        public Pays(int Code_Pays, string Nom_Pays)
        {
            this.Code_Pays = Code_Pays;
            this.Nom_Pays = Nom_Pays;
        }

        override
        public string ToString()
        {
            return Nom_Pays;
        }
    }
}
