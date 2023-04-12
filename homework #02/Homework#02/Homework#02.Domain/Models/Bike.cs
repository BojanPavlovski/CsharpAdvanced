using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Domain.Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike()
        {

        }
        

        public override void PrintVehicle()
        {
            Console.WriteLine($"Year of production: {YearOfProduction} of color {Color}");
        }

        
    }
}
