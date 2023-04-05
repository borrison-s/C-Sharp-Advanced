using Homework;
using Homework.Domain.Models;

foreach (var vehicle in VehiclesListDb.Vehicles)
{
    vehicle.PrintVehicle();
    Validator.Validate(vehicle);
}


Vehicle invalidVehicle = new Car(0, "SUV", 2021, 123456789, 70, new List<string> { "USA", "Canada" });
Validator.Validate(invalidVehicle);

