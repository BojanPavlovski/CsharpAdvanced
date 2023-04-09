

using CarService.Domain.Interfaces;

namespace CarService.Domain.Models
{
    public class Truck : Vehicle, ICarWash
    {
        public override void Drive()
        {
            Console.WriteLine("The truck is driving.");
        }

        

        public void WashCar()
        {
            throw new NotImplementedException();
        }

        public void WashTrailer()
        {
            Console.WriteLine("Washing the trailer.");
        }
    }
}
