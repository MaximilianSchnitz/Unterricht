using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiTest2013
{
    class Terminal
    {
        Drucker drucker;

        public Terminal()
        {
            this.drucker = new Drucker(5);
        }

        public void DruckeBestellung(string bestellung)
        {
            if(drucker.Open())
            {
                for (int i = 0; i < bestellung.Length; i++)
                    drucker.DruckeZeichen(bestellung[i]);
                drucker.Close();
            }
        }
    }
}
