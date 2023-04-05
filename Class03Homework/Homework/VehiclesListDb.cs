using Homework.Domain.Models;

namespace Homework
{
    public static class VehiclesListDb
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>()
        {
        new Car(1, "Sedan", 2022, 123456789, 50, new List<string>{"USA", "Japan"}),
        new Bike(2, "Sport", 2021, 987654321, "Red"),
        new Vehicle(3, "Truck", 2020, 456789123),
        new Car(4, "Hatchback", 2023, 135792468, 40, new List<string>{"Germany", "France"}),
        new Bike(5, "Mountain", 2022, 246813579, "Green"),
        new Vehicle(6, "Van", 2021, 987654321),
        new Car(7, "Coupe", 2022, 314159265, 60, new List<string>{"Italy", "Spain"}),
        new Bike(8, "City", 2023, 271828182, "Blue"),
        new Vehicle(9, "SUV", 2020, 123456789)
        };
    }
}
