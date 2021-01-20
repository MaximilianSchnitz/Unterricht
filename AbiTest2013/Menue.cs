using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiTest2013
{
    class Menue
    {
        string bezeichnung;

        double preis;

        public Menue(string bezeichnung, double preis)
        {
            this.bezeichnung = bezeichnung;
            this.preis = preis;
        }

        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public double Preis { get => preis; set => preis = value; }
    }
}
