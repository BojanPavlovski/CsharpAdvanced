using Homework_02.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Domain
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if(vehicle.Id == 0)
            {
                Console.WriteLine("Id is invalid");
            }
            
            if(string.IsNullOrEmpty(vehicle.Type))
            {
                Console.WriteLine("Type is invalid");
            }

            if(vehicle.YearOfProduction == 0)
            {
                Console.WriteLine("Invalid year of production");
            }
        }
    }
}
