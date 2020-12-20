using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravellerScripts
{
    class Program
    {

        

        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Task1);
            ThreadPool.QueueUserWorkItem(Task2);

            Console.WriteLine("Main");

            //Dialogue.CreateFromFile("C:/Users/felix/Desktop/New Text Document.xml", 0);
            Console.ReadKey();
        }

        private static void Task1(Object stateInfo)
        {
            Console.WriteLine("Thread 1");
        }

        private static void Task2(Object stateInfo)
        {
            Console.WriteLine("Thread 2");
        }

    }
}
