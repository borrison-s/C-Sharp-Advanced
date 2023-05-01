using TaskOne.Domain.Models;

namespace TaskOne.Domain.Database
{
    public class Database<T> where T : Shape
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void PrintAreas()
        {
            foreach (var item in _items)
            {
                Console.WriteLine($"Shape {item.Id}: area = {item.GetArea()}");
            }
        }

        public void PrintPerimeters()
        {
            foreach(var item in _items)
            {
                Console.WriteLine($"Shape {item.Id}: perimeter = {item.GetPerimeter()}");
            }
        }
    }
}
