using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Database;
using Task_1.Models;

namespace Task_1.Extensions
{
    public static class ExtensionMethods
    {
        public static void InfoForCircles(this GenericDb<Circle> circle)
        {
           
            foreach(var item in circle.Items)
            {
                Console.WriteLine($"This circle has an id: {item.Id} and radius {item.Radius}");
            }
             
            
        }

        public static void InfoForRectangles(this GenericDb<Rectangle> rectangles)
        {
            foreach(var item in rectangles.Items)
            {
                Console.WriteLine($"This rectangle has  id {item.Id} and side A:{item.sideA} and side B:{item.sideB}");
            }
           
        }
    }
}
