using TaskTwo.Domain.Models;
using TaskTwo.Domain.PetStore;

List<Dog> dogs = new List<Dog>
{
new Dog { Name = "Buddy", Type = "Golden Retriever", Age = 3, FavoriteFood = "Bacon" },
new Dog { Name = "Lassie", Type = "Collie", Age = 2, FavoriteFood = "Chicken" }
};

List<Cat> cats = new List<Cat>
    {
        new Cat { Name = "Garfield", Type = "Orange Tabby", Age = 5, Lazy = true, LivesLeft = 7 },
        new Cat { Name = "Salem", Type = "Black Cat", Age = 4, Lazy = false, LivesLeft = 9 }
    };

List<Fish> fish = new List<Fish>
    {
        new Fish { Name = "Nemo", Type = "Clownfish", Age = 1, Color = "Orange", Size = "Small" },
        new Fish { Name = "Dory", Type = "Regal Blue Tang", Age = 2, Color = "Blue", Size = "Medium" }
    };

PetStore<Dog> dogStore = new PetStore<Dog>(dogs);
PetStore<Cat> catStore = new PetStore<Cat>(cats);
PetStore<Fish> fishStore = new PetStore<Fish>(fish);


dogStore.BuyPet("Buddy");
catStore.BuyPet("Garfield");

// Call PrintPets() method on all stores
dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();