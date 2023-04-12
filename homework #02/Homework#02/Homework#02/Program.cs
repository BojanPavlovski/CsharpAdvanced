using Homework_02.Domain;
using Homework_02.Domain.Models;

static void Main()
{
    
}

foreach (Vehicle vehicle in DB.Vehicle)
{
    vehicle.PrintVehicle();
}

//calling the validate function
Console.WriteLine("============Validate=======");
Console.WriteLine("Vehicle1");
Vehicle vehicle1 = new Vehicle() { Id = 4, Type = "bus", YearOfProduction = 1997, BatchNumber = 45664};
Validator.Validate(vehicle1);

Console.WriteLine("Vehicle2");
Vehicle vehicle2 = new Vehicle() { Id = 0, Type = "", YearOfProduction = 0, BatchNumber = 45664};
Validator.Validate(vehicle2);

Console.WriteLine("Car1");
Car car1 = new Car() { Id = 6, Type = "car", YearOfProduction = 0, BatchNumber = 45664, FuelTank = 10, Countries = new List<string>() { "Greece", "Macedonia" } };
Validator.Validate(car1);

Console.WriteLine("Bike1");
Bike bike1 = new Bike() { Id = 0, Type = "bike", YearOfProduction = 2015, BatchNumber = 456, Color = "green" };
Validator.Validate(bike1);