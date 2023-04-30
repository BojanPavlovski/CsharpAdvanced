using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Models;

namespace Task_1.Database
{
    public class GenericDb<T> where T : Shape
    {
        public List<T> Items;

        public GenericDb()
        {
            Items = new List<T>();
        }

        public void PrintArea()
        {
            foreach(T item in  Items)
            {
                item.GetArea();
            }
        }

        public void PrintPerimeter()
        {
            foreach(T item in Items)
            {
                item.GetPerimeter();
            }
        }
    }
}
