using CarService.Domain.Models;

Car car = new Car();
car.Drive();
car.WashCar();
//car.WashTrailer();
car.PumpGas();
car.CheckVehicle();
car.FixVehicle();

Truck truck = new Truck();
truck.Drive();
truck.WashTrailer();
//truck.WashCar();
truck.PumpGas();
truck.CheckVehicle();
truck.FixVehicle();

try
{
    car.WashTrailer();
}
catch(Exception e)
{
    Console.WriteLine("This method belongs to the Truck class.");
}

try
{
    truck.WashCar();
    
}
catch (Exception e)
{
    Console.WriteLine("This method belongs to the Car class.");
}

// class CarCenter
CarCenter carCenter = new CarCenter();
carCenter.PumpGas();
carCenter.CheckVehicle();
carCenter.FixVehicle();
carCenter.WashCar();
carCenter.WashTrailer();

//class RepairService
RepairService repairService = new RepairService();
repairService.CheckVehicle();
repairService.FixVehicle();


//class GasPump
GasPump gasPump = new GasPump();
gasPump.PumpGas();

//class CarWash
CarWash carWash = new CarWash();
carWash.WashTrailer();
carWash.WashCar();
