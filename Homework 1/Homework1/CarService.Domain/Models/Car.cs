

using CarService.Domain.Interfaces;

namespace CarService.Domain.Models
{
    public class Car : Vehicle, ICarWash
    {
        public override void Drive()
        {
            Console.WriteLine("The car is driving.");
        }

        
        public void WashCar()
        {
            Console.WriteLine("Washing the car");
        }

        public void WashTrailer()
        {
             throw new NotImplementedException();
        }
    }
}
