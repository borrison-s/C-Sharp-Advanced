namespace TaskOne.Domain.Models
{
    public static class ShapeExtensions
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine($"Circle with radius {circle.Radius}: area = {circle.GetArea()}, perimeter = {circle.GetPerimeter()}");
        }

        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle with sides {rectangle.SideA} and {rectangle.SideB}: area = {rectangle.GetArea()}, perimeter = {rectangle.GetPerimeter()}");
        }
    }
}
