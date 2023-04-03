using Homework2.Domain.Interfaces;

namespace Homework2.Domain.Models
{
    public class CarWash : ICarWash
    {
     

        public void WashCar(Car car)
        {
            Console.WriteLine("Washing a car");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("Washing a trailer...");
        }
    }
}
