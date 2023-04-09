

using CarService.Domain.Interfaces;

namespace CarService.Domain.Models
{
    public abstract class Vehicle : IPumpGas, IRepairService
    {
        //method that works for all vehicles
        public void CheckVehicle()
        {
            Console.WriteLine("Checking vehicle.");
        }

        public abstract void Drive();

        //method that works for all vehicles
        public void FixVehicle()
        {
            Console.WriteLine("Fixing vehicle.");
        }

        //method that works for all vehicles
        public void PumpGas()
        {
            Console.WriteLine("Pumping gass");
        }
    }
}
