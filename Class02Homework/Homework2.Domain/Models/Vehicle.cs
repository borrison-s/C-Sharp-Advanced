namespace Homework2.Domain.Models
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Weight { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string make, string model, int year, int weight)
        {
            if (string.IsNullOrEmpty(make))
            {
                throw new ArgumentException("Make cannot be null or empty", nameof(make));
            }

            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentException("Model cannot be null or empty", nameof(model));
            }

            if (year < 1900 || year > DateTime.Now.Year + 1)
            {
                throw new ArgumentException("Invalid year", nameof(year));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("Weight must be greater than zero", nameof(weight));
            }

            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public abstract void Drive();
    }
}
