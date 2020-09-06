using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var ss = new SecuritySystem();
            ss.CheckDoors();

            Console.ReadKey();
        }
    }
}
