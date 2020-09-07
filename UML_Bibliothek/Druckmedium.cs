using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Bibliothek
{
    abstract class Druckmedium : Medium
    {

        private string isbn;
        private string author;
        private int seitenzahl;
         

        public Druckmedium(string titel, DateTime erscheinungsjahr, string isbn, string author, int seitenzahl)
            : base(titel, erscheinungsjahr)
        {
            this.isbn = isbn;
            this.author = author;
            this.seitenzahl = seitenzahl;
        }

    }
}
