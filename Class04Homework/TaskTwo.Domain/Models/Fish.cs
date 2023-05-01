using System.Drawing;

namespace TaskTwo.Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Age: {Age}, Color: {Color}, Size: {Size}");
        }
    }
}
