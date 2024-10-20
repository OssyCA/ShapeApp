using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Circle(int radius)  // uses a primary constructor to initialize its radius
    {
        public double GetArea() // return circles area 
        {
            return Math.PI * Math.Pow(radius, 2); // Formel: A = π ⋅ r^2
        }
        public double GetPerimeter() // Returns Perimeter of a cicrle
        {
            double diameter = radius * 2;

            return Math.PI * diameter;
        }
        public double GetVolym(bool isSphere)   // Method to calculate and return the volume if treated as a sphere
        {
            if (isSphere)
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3); // Volume formula for a sphere: V = (4/3) * π * r^3
            }
            else
            {
                Console.WriteLine("Not a sphere");
                return 0;
            }
        }
    }
}
