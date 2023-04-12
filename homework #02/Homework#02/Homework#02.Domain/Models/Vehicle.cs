using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Domain.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle()
        {

        }

        

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"Id: {Id},Type: {Type}, Year of production: {YearOfProduction}");
        }
        
    }
}
