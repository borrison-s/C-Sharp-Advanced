namespace Homework.Domain.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public long BatchNumber { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int id, string type, int yearOfProduction, long batchNumber)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id}, Type: {Type}, Year of production {YearOfProduction}");
        }
    }
}
