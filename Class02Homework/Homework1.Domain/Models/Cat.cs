using Homework1.Domain.Interfaces;

namespace Homework1.Domain.Models
{
    public class Cat : Animal, ICat
    {

        public Cat(string name, int age, string breed, string color) : base(name, age, breed, color)
        {

        }
        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}.");

        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"{Name} is a cat.");
        }
    }
}
