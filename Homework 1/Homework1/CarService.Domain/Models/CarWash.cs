using CarService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public class CarWash : ICarWash
    {
        public void WashCar()
        {
            Console.WriteLine("Washing the car.");
        }

        public void WashTrailer()
        {
            Console.WriteLine("Washing the trailer.");
        }
    }
}
