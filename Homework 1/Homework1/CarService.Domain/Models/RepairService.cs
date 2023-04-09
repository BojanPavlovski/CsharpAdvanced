using CarService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking the vehicle.");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Fixing the vehicle.");
        }
    }
}
