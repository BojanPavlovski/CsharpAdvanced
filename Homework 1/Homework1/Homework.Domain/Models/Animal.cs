using Homework.Domain.Interfaces;

namespace Homework.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }

        public Animal()
        {

        }

        public Animal(string name, string ownerName)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name input.");
            }
            else
            {
                Name = name;
            }
            
            if (string.IsNullOrEmpty(ownerName))
            {
                Console.WriteLine("Invalid owner name input.");
            }
            else
            {
                OwnerName = ownerName;
            }
            
        }

        public abstract void PrintAnimal();
    }
}
