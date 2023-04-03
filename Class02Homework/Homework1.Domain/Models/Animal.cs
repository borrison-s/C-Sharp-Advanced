using Homework1.Domain.Interfaces;

namespace Homework1.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }


        public Animal()
        {

        }

        public Animal(string name, int age, string breed, string color)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            if (string.IsNullOrEmpty(breed))
            {
                throw new ArgumentException("Breed cannot be null or empty.", nameof(breed));
            }

            if (string.IsNullOrEmpty(color))
            {
                throw new ArgumentException("Color cannot be null or empty.", nameof(color));
            }

            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative.", nameof(age));
            }

            Name = name;
            Age = age;
            Breed = breed;
            Color = color;

        }

        public abstract void PrintAnimal();
    }
}
