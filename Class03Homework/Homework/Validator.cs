using Homework.Domain.Models;

namespace Homework
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            if (vehicle.Id == 0 || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction == 0)
            {
                Console.WriteLine("Invalid Vehicle data");
                return false;
            }
            return true;
        }
    }
}


