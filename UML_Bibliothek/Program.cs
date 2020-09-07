using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Bibliothek
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Ausleiher("Günther", "Lukas", new DateTime(2000, 06, 20));

            var f = new Film("Faust: Endgame", new DateTime(2021, 04, 24), "Goethe 2", 420, 12);

            f.Ausleihen(p);
            f.Zurueckgeben(p);

            var infobuch = new Fachbuch("Info mitm Fausti", new DateTime(2018, 09, 07), "123f217", "Frederick Faust", 420, "Informatik", "Liegestütze");
            Console.WriteLine(infobuch.PruefeAktualitaet());

            Console.ReadKey();
        }
    }
}
