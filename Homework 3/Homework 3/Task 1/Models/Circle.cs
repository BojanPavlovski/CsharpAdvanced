using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override void GetArea()
        {
            double pi = Math.PI;
            double result = Radius * pi;
            Console.WriteLine($"The area of the circle is: {result}");
        }

        public override void GetPerimeter()
        {
            double pi = Math.PI;
            double result = 2 * pi * Radius;
            Console.WriteLine($"The perimeter is {result}");
        }
    }
}
