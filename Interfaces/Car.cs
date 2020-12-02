using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Car : IDraw, IComparable<Car>
    {
        private string name;
        private int hp;

        public Car(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public int CompareTo(Car other)
        {
            return hp.CompareTo(other.hp);
        }

        public void Draw()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("HP: " + hp);
        }
    }
}
