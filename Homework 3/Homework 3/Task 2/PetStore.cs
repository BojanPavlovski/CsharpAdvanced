using Task_2.Models;

namespace Task_2
{
    public class PetStore<T> where T : Pet
    {
        public List<T> listOfPets { get; set; }
        public PetStore() 
        {
            listOfPets = new List<T>();
        }

        public void PrintsPets()
        {
            foreach(T item in listOfPets)
            {
                item.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            T pet = listOfPets.FirstOrDefault(x => x.Name == name);
            if(pet != null)
            {
                listOfPets.Remove(pet);
                Console.WriteLine("Such a pet exists.");
            }
            else
            {
                Console.WriteLine("Such a pet could not be found.");
            }
            
        }


    }
}
