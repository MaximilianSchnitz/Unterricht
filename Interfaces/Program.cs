using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Porsche", 15);
            var rect = new Rectangle(9, 11);
            var cir = new Circle(42);

            var array = new IDraw[] { rect, cir};

            foreach(IDraw item in array)
            {
                item.Draw();
            }

            Array.Sort(array);

            foreach (IDraw item in array)
            {
                item.Draw();
            }

            Console.ReadKey();
        }
    }
}
