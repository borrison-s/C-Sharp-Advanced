namespace Homework.Domain.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog() { }

        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
    }
}
