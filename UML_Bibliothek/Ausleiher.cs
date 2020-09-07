using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Bibliothek
{
    class Ausleiher
    {

        public string Name { get; }
        public string Vorname { get; }
        public DateTime Geburtsdatum { get; }
        public List<Medium> AusgelieheneMedien { get; set; } = new List<Medium>();

        public Ausleiher(string name, string vorname, DateTime geburtsdatum)
        {
            Name = name;
            Vorname = vorname;
            Geburtsdatum = geburtsdatum;
        }

    }
}
