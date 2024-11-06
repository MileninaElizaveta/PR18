using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle
    {
        public double r;
        public Circle() { }

        public Circle(double r)
        {
            double radius = r;
        }

        public double Area(double radius)
        {
            double v = Math.PI * Math.Pow(r,2);
            return v;
        }

        public double Cirle(double radius)
        {
            double P = 2 * Math.PI * r;
            return P;
        }
    }
}
