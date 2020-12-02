using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LListR<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine(list.Count);
            Console.WriteLine(list.IndexOf(3));
            list.ChangeAtPos(10, 0);
            Console.WriteLine(list.IndexOf(10));

            Console.ReadKey();
        }
    }
}
