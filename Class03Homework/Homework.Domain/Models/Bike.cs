namespace Homework.Domain.Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }


        public Bike()
        {
            // Default constructor
        }


        public Bike(int id, string type, int yearOfProduction, long batchNumber, string color) : base(id, type, yearOfProduction, batchNumber)
        {
            Color = color;
        }



        public override void PrintVehicle()
        {
            Console.WriteLine($"Year of production: {YearOfProduction}, Color: {Color}");
        }
    }
}
