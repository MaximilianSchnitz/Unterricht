using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Geometry : IDraw, IComparable<Geometry>
    {
        public abstract double CalculateArea();

        public int CompareTo(Geometry other)
        {
            return CalculateArea().CompareTo(other.CalculateArea());
        }

        public void Draw()
        {
            Console.WriteLine("Type: " + GetType().Name);
            Console.WriteLine("Area: " + CalculateArea());
        }
    }

}
