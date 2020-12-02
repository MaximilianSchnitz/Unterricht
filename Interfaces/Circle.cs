using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Circle : Geometry
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
