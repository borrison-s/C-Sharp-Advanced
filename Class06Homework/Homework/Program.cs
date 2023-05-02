using Homework.Domain;
using Homework.Domain.Models;

// Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
List<string> namesStartingWithR = Database.People
                                      .Where(person => person.FirstName.StartsWith("R"))
                                      .OrderByDescending(person => person.Age)
                                      .Select(person => person.FirstName)
                                      .ToList();

foreach (string name in namesStartingWithR)
{
    Console.WriteLine(name);
}


// Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER

List<Dog> brownDogs = Database.Dogs
                          .Where(dog => dog.Color == "Brown" && dog.Age > 3)
                          .OrderBy(dog => dog.Age)
                          .ToList();

foreach (Dog brownDog in brownDogs)
{
    Console.WriteLine($"Name: {brownDog.Name}, Age: {brownDog.Age}");
}


// Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER

List<Person> personsWithMoreThan2Dogs = Database.People
                                            .Where(x => x.Dogs.Count > 2)
                                            .OrderByDescending(x => x.FirstName)
                                            .ToList();

foreach (Person person in personsWithMoreThan2Dogs)
{
    Console.WriteLine($"{person.FirstName} has {person.Dogs.Count} dogs.");
}


// Find and print all Freddy`s dogs names older than 1 year

List<string> freddyDogsNamesOlderThan1 = Database.People
                                             .Where(person => person.FirstName == "Freddy")
                                             .SelectMany(person => person.Dogs)
                                             .Where(dog => dog.Age > 1)
                                             .Select(dog => dog.Name)
                                             .ToList();

foreach (string name in freddyDogsNamesOlderThan1)
{
    Console.WriteLine(name);
}


// Find and print Nathen`s first dog

Dog firstDog = Database.People
                      .Where(person => person.FirstName == "Nathen")
                      .SelectMany(person => person.Dogs)
                      .FirstOrDefault();

// Print the name of the first dog
if (firstDog != null)
{
    Console.WriteLine("Nathen's first dog's name is: " + firstDog.Name);
}
else
{
    Console.WriteLine("Nathen has no dogs.");
}


// Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
List<string> whiteDogsNames = Database.People
    .Where(person => person.FirstName == "Cristofer" ||
                      person.FirstName == "Freddy" ||
                      person.FirstName == "Erin" ||
                      person.FirstName == "Amelia")
    .SelectMany(person => person.Dogs)
    .Where(dog => dog.Color == "White")
    .OrderBy(dog => dog.Name)
    .Select(dog => dog.Name)
    .ToList();

foreach (string dogName in whiteDogsNames)
{
    Console.WriteLine(dogName);
}