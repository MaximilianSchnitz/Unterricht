using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Bibliothek
{
    class Freizeitbuch : Druckmedium
    {

        private string genre;

        public Freizeitbuch(string titel, DateTime erscheinungsjahr, string isbn, string author, int seitenzahl, string genre)
            : base(titel, erscheinungsjahr, isbn, author, seitenzahl)
        {
            this.genre = genre;
        }

    }
}
