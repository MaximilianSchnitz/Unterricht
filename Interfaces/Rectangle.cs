using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Rectangle : Geometry
    {
        private double x;
        private double y;

        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override double CalculateArea()
        {
            return x * y;
        }
    }
}
