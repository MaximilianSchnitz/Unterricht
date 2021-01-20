using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiTest2013
{
    class Datum
    {
        int tag;
        int monat;
        int jahr;

        public int Tag { get => tag; set => tag = value; }
        public int Monat { get => monat; set => monat = value; }
        public int Jahr { get => jahr; set => jahr = value; }

        public Datum()
        { }

        public Datum(int tag, int monat, int jahr)
        {
            this.tag = tag;
            this.monat = monat;
            this.jahr = jahr;
        }

    }
}
