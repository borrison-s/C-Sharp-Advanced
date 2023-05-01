using TaskOne.Domain.Database;
using TaskOne.Domain.Models;

Circle circle = new Circle { Id = 1, Radius = 5 };
Rectangle rectangle = new Rectangle { Id = 2, SideA = 3, SideB = 4 };

Database<Shape> database = new Database<Shape>();

database.Add(circle);
database.Add(rectangle);

database.PrintAreas();
database.PrintPerimeters();

circle.PrintInfo();
rectangle.PrintInfo();