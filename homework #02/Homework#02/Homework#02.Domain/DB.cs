using Homework_02.Domain.Models;
using System.Drawing;

namespace Homework_02.Domain
{
    public static class DB
    {
        public static List<Vehicle> Vehicle = new List<Vehicle>()
        {
             new Vehicle() { Id = 1, Type = "truck", YearOfProduction = 2023, BatchNumber = 79879 },
        new Vehicle() { Id = 2, Type = "motorbike", YearOfProduction = 2022, BatchNumber = 1213 },
        new Car() { Id = 3, Type = "car", YearOfProduction = 2022, BatchNumber = 1213, FuelTank = 10, Countries = new List<string> { "Macedonia", "Greece" } },
        new Car() { Id = 4, Type = "car", YearOfProduction = 2007, BatchNumber = 2323, FuelTank = 8, Countries = new List<string> { "Croatia", "Montenegro" } },
        new Bike() { Id = 5, Type = "bike", YearOfProduction = 2003, BatchNumber = 189564, Color = "red" },
        new Bike() { Id = 6, Type = "bike", YearOfProduction = 2018, BatchNumber = 164852, Color = "blue" }
        };

        static DB()
        {

        }
    }
}
