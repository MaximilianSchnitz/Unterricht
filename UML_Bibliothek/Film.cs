using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Bibliothek
{
    class Film : Medium
    {

        private string regisseur;
        private int laufzeit;
        private int altersfreigabe;

        public Film(string titel, DateTime erscheinungsjahr, string regisseur, int laufzeit, int altersfreigabe)
            : base(titel, erscheinungsjahr)
        {
            this.regisseur = regisseur;
            this.laufzeit = laufzeit;
            this.altersfreigabe = altersfreigabe;
        }

        public bool PruefeAltersfreigabe(Ausleiher ausleiher)
        {
            return (DateTime.Now - ausleiher.Geburtsdatum).TotalDays / 365 >= altersfreigabe;
        }

        public override void Ausleihen(Ausleiher ausleiher)
        {
            if (PruefeAltersfreigabe(ausleiher))
                base.Ausleihen(ausleiher);
            else
                Console.WriteLine($"{ausleiher.Vorname} {ausleiher.Name} ist zu jung für {Titel}");
        }

    }
}
