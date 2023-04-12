using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }


        public Car()
        {
            Countries = new List<string>();
        }
        

        public override void PrintVehicle()
        {
            Console.WriteLine($"Type: {Type}");
            foreach (var country in Countries)
            {
                Console.WriteLine("This vehicle is produced in:");
                Console.WriteLine(country);
            }
        }

        
    }
}
