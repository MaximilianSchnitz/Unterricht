using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiTest2013
{
    class Mitarbeiter
    {
        static int naechstePersNr = 1000;

        public static List<Mitarbeiter> mitarbeiter;

        int personalNr;
        string name;
        string vorname;

        List<Bestellung> bestellungen;
        
        public Mitarbeiter(string name, string vorname)
        {
            this.name = name;
            this.vorname = vorname;

            mitarbeiter.Add(this);

            personalNr = naechstePersNr++;
        }

        public int PersonalNr { get => personalNr; }
        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public List<Bestellung> Bestellungen { get => bestellungen; set => bestellungen = value; }

        public void EintragenMenue(Menue menue, Datum verzehrDatum)
        {
            var bestellung = new Bestellung(this, menue, verzehrDatum);
            bestellungen.Add(bestellung);
        }

    }
}
