namespace TaskTwo.Domain.Models
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Age: {Age}, Favorite Food: {FavoriteFood}");
        }
    }
}
