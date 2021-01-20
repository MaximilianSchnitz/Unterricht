using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiTest2013
{
    class Monatsabrechnung
    {
        Mitarbeiter kunde;

        int monat;
        int jahr;

        double betrag;

        public Monatsabrechnung(Mitarbeiter kunde, int monat, int jahr, double betrag)
        {
            this.monat = monat;
            this.jahr = jahr;
            this.betrag = betrag;
        }

        public Mitarbeiter Kunde { get => kunde; }
        public int Monat { get => monat; set => monat = value; }
        public int Jahr { get => jahr; set => jahr = value; }
        public double Betrag { get => betrag; set => betrag = value; }
    }
}
