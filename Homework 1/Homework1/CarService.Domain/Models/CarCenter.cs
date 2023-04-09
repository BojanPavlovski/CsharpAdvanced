using CarService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public class CarCenter : ICarWash, IPumpGas, IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking vehicle.");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Fixing vehicle.");
        }

        public void PumpGas()
        {
            Console.WriteLine("Pumping gas.");
        }

        public void WashCar()
        {
            Console.WriteLine("Washing  car.");
        }

        public void WashTrailer()
        {
            Console.WriteLine("Washing trailer.");
        }
    }
}
