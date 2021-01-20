using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiTest2013
{
    class Bestellung
    {
        Datum bestellDatum;
        Datum verzehrDatum;

        public Bestellung(Mitarbeiter kunde, Menue menue, Datum verzehrDatum)
        {
            this.verzehrDatum = verzehrDatum;
        }

        public double ErmittlePreis()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
