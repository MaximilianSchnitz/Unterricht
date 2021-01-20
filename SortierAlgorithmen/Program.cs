using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortierAlgorithmen
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] array = { 2, 6, 5, 3, 8, 7, 1, 0};
            array = Sort.MergeSort(array);

            foreach (int i in array)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}
