using TaskTwo.Domain.Models;

namespace TaskTwo.Domain.PetStore
{
    public class PetStore<T> where T : Pet
    {
        private List<T> _pets;

        public PetStore(List<T> pets)
        {
            _pets = pets;
        }

        public void PrintPets()
        {
            foreach (T pet in _pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            var petToRemove = _pets.FirstOrDefault(p => p.Name == name);
            if (petToRemove != null)
            {
                _pets.Remove(petToRemove);
                Console.WriteLine($"You have successfully bought {name}!");
            }
            else
            {
                Console.WriteLine($"Sorry, we don't have a pet named {name}.");
            }
        }
    }
}
