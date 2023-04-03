using Homework2.Domain.Interfaces;

namespace Homework2.Domain.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Checking vehicle...");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Fixing vehicle...");
        }

        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine("Pumping gas...");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine("Washing a car...");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("Washing a trailer...");
        }
    }
}
