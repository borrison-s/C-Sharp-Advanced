using Homework1.Domain.Interfaces;

namespace Homework1.Domain.Models
{
    public class Dog : Animal, IDog
    {

        public Dog(string name, int age, string breed, string color) : base(name, age, breed, color)
        {

        }

        public void Bark()
        {
            Console.WriteLine($"{Name} barks.");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"{Name} is a dog.");
        }
    }
}
