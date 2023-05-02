namespace Homework.Domain.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person() { }

        public Person(string firstName, int age)
        {
            FirstName = firstName;
            Age = age;
            Dogs = new List<Dog>();
        }
    }
}
