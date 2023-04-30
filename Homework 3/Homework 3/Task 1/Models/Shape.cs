using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public abstract void GetArea();
        public abstract void GetPerimeter();
    }
}
