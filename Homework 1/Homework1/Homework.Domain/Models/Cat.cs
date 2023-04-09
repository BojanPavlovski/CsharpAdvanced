using Homework.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Domain.Models
{
    public class Cat : Animal, ICat
    {
        public string FavoriteFood { get; set; }
        public string Color { get; set; }

        public Cat(string name, string ownerName, string favoriteFood, string color) : base(name, ownerName)
        {
            if (string.IsNullOrEmpty(favoriteFood))
            {
                Console.WriteLine("Invalid input.");
            }
            else 
            {
                FavoriteFood = favoriteFood;
            }
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                Color = color;
            }
            
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"The cat is {Color}");
        }

        public void Eat(string favoriteFood)
        {
            Console.WriteLine($"The cat loves to eat {favoriteFood}");
        }
    }
}
