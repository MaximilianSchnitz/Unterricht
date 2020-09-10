using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Bibliothek
{
    class Fachbuch : Druckmedium
    {

        private string fachbereich;
        private string themenfeld;

        public Fachbuch(string titel, DateTime erscheinungsjahr, string isbn, string author, int seitenzahl, string fachbereich, string themenfeld)
            : base(titel, erscheinungsjahr, isbn, author, seitenzahl)
        {
            this.fachbereich = fachbereich;
            this.themenfeld = themenfeld;
        }

        public string PruefeAktualitaet()
        {
            int diff = DateTime.Now.Year - Erscheinungsjahr.Year;
            if (diff > 10)
                return "nicht aktuell";
            else if (diff >= 2)
                return "aktuell";
            else if (diff >= 0)
                return "sehr aktuell";
            else
                return "Es ist kaputt gegangen";
        }

    }
}
