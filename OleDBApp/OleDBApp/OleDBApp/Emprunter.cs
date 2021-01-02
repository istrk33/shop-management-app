using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleDBApp
{
    class Emprunter
    {
        public int Code_Abonné { get; }
        public int Code_Album { get; }
        public DateTime Date_Emprunt { get; }
        public DateTime? Date_Retour { get; }

        public Emprunter(int Code_Abonné,int Code_Album, DateTime Date_Emprunt, DateTime? Date_Retour)
        {
            this.Code_Abonné = Code_Abonné;
            this.Code_Album = Code_Album;
            this.Date_Emprunt = Date_Emprunt;
            this.Date_Retour = Date_Retour;
        }
    }
}
