namespace TaskOne.Domain.Models
{
    public class Shape
    {
        public int Id { get; set; }
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
        public virtual double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
