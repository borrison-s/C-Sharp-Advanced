namespace Homework.Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }

        public Car()
        {
            // Default constructor
        }


        public Car(int id, string type, int yearOfProduction, long batchNumber, int fuelTank, List<string> countries) : base(id, type, yearOfProduction, batchNumber) 
        { 
            FuelTank = fuelTank;
            Countries = countries;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Type: {Type}, Countries: {string.Join(", ", Countries)}");
        }
    }
}
