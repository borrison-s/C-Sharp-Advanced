using Homework.Domain.Models;

namespace Homework.Domain
{
    public static class Database
    {
        public static List<Person> People = new List<Person>()
        {
            new Person("Cristofer", 28),
            new Person("Freddy", 30),
            new Person("Erin", 33),
            new Person("Amelia", 23),
            new Person("Robert", 43),
            new Person("Robin", 27),
            new Person("Nathen", 18)
        };
        public static List<Dog> Dogs = new List<Dog>()
        {
           new Dog("Max", 5, "Golden"),
           new Dog("Bella", 3, "White"),
           new Dog("Charlie", 7, "Black"),
           new Dog("Rocky", 4, "Brown"),
           new Dog("Daisy", 2, "White"),
           new Dog("Buddy", 6, "Brown"),
           new Dog("Luna", 1, "Gray"),
           new Dog("Zeus", 8, "Black"),
           new Dog("Maximus", 4, "Brindle"),
           new Dog("Lola", 9, "White"),
           new Dog("Blue", 2, "Black and White"),
           new Dog("Spot", 4, "Brown"),
           new Dog("Milo", 1, "White and Brown"),
           new Dog("Thor", 3, "Black"),
           new Dog("Jacky", 2, "Brown"),
           new Dog("Abba", 1, "Black")
        };  

        static Database()
        {
            People[0].Dogs = new List<Dog>() { Dogs[1], Dogs[3], Dogs[6] };
            People[1].Dogs = new List<Dog>() { Dogs[0], Dogs[2], Dogs[5] };
            People[2].Dogs = new List<Dog>() { Dogs[4], Dogs[7] };
            People[3].Dogs = new List<Dog>() { Dogs[8], Dogs[9] };
            People[4].Dogs = new List<Dog>() { Dogs[10], Dogs[12] };
            People[5].Dogs = new List<Dog>() { Dogs[11], Dogs[13] };
            People[6].Dogs = new List<Dog>() { Dogs[14], Dogs[15] };
        }
    }
}
