using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class Rectangle : Shape
    {
        public int sideA { get; set; }
        public int sideB { get; set; }

        public override void GetArea()
        {
            int result = sideA * sideB;
            Console.WriteLine($"The area for a rectangle is {result}");
        }

        public override void GetPerimeter()
        {
            int result = 2 * (sideA * sideB);
            Console.WriteLine($"The perimeter for a rectangle is {result}");
        }
    }
}
