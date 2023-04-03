using Homework1.Domain.Models;

Dog dog = new Dog("Rocky", 3, "Stafford", "Black");
dog.PrintAnimal();
dog.Bark();

Cat cat = new Cat("Macushka", 7, "Persian", "Silver");
cat.PrintAnimal();
cat.Eat("fish");