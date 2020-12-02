using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class Program
    {

        public delegate void MyDelegate(int i, string s);

        static void Main(string[] args)
        {
            CallMethod(DoSmth, 10, "Hello world");
            Console.ReadKey();
        }

        public static void DoSmth(int i, string s)
        {
            Console.WriteLine(s + i);
        }

        public static void CallMethod(MyDelegate myDelegate, int i, string s)
        {
            myDelegate(i, s);
        }

    }
}
