using Homework.Domain.Interfaces;

namespace Homework.Domain.Models
{
    public class Dog : Animal, IDog
    {
        public string FavouriteToy { get; set; }

        public Dog(string name, string ownerName, string favouriteToy) : base(name, ownerName)
        {
            if (string.IsNullOrEmpty(favouriteToy))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                FavouriteToy = favouriteToy;
            }
            
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"{Name}'s favorite toy is {FavouriteToy} and his owner is {OwnerName}");
        }

        public void Bark()
        {
            Console.WriteLine("The dog goes af af af.");
        }
    }
}
