using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Triangle(double height, double width) // uses a primary constructor to initialize its height and width
    {
        public double GetArea()
        {
            // Area formula: Area = (base * height) / 2
            return (width * height) / 2;
        }
        //Method to get perimeter from a triangle
        public double GetPerimeter(double sideA, double sideB)
        {
            return sideA + sideB + width;
        }
    }
}
