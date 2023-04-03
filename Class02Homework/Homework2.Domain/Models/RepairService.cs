using Homework2.Domain.Interfaces;

namespace Homework2.Domain.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle has been checked and is okay.");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle has been fixed.");
        }
    }
}
