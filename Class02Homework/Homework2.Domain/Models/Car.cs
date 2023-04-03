namespace Homework2.Domain.Models
{
    public class Car : Vehicle
    {

        public Car(string make, string model, int year, int weight) : base(make, model, year, weight)
        {

        }

        public override void Drive()
        {
            Console.WriteLine("Driving a car...");
        }
    }
}
