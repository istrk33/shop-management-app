using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleDBApp
{
    public class Album
    {
        public int Code_Album { get; }
        public string Titre_Album { get; }
        public int Année_Album { get; }

        public Album(int Code_Album, string Titre_Album, int Année_Album)
        {
            this.Code_Album = Code_Album;
            this.Titre_Album = Titre_Album;
            this.Année_Album = Année_Album;
        }

        override
        public string ToString()
        {
            return Titre_Album;
        }
    }
}
