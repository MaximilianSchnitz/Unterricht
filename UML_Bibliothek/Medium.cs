using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Bibliothek
{
    abstract class Medium
    {
        private static int autoId = 1;
        public int MedienID { get; }
        public string Titel { get; }
        public DateTime Erscheinungsjahr { get; }
        private DateTime ausleihdatum;
        private string ausleihstatus;

        public Medium(string titel, DateTime erscheinungsjahr)
        {
            MedienID = autoId++;
            Titel = titel;
            Erscheinungsjahr = erscheinungsjahr;
        }

        public virtual void Ausleihen(Ausleiher ausleiher)
        {
            ausleiher.AusgelieheneMedien.Add(this);
            ausleihstatus = "ausgeliehen";
            ausleihdatum = DateTime.Now;
        }

        public void Zurueckgeben(Ausleiher ausleiher)
        {
            if(ausleiher.AusgelieheneMedien.Contains(this))
            {
                if (DateTime.Now.CompareTo(BerechneAusleihende()) > 0)
                    Console.WriteLine("Zu spät zurückgegeben");
                else
                    Console.WriteLine("Rechtzeitig zurückgegeben");

                ausleiher.AusgelieheneMedien.Remove(this);
                ausleihstatus = "verfügbar";
                ausleihdatum = new DateTime();
            }
            else
            {
                Console.WriteLine($"{ausleiher.Vorname} {ausleiher.Name} besitzt {Titel} nicht");
            }
        }

        public DateTime BerechneAusleihende()
        {
            return ausleihdatum.AddDays(3 * 7);
        }

        public string PruefeVerfuegbarkeit()
        {
            return ausleihstatus;
        }

    }
}
