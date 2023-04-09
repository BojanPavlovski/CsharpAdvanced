using CarService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public class GasPump : IPumpGas
    {
        public void PumpGas()
        {
            Console.WriteLine("Pumping gas.");
        }
    }
}
