using Task_2;
using Task_2.Enum;
using Task_2.Models;

PetStore<Dog> dogStore = new PetStore<Dog>()
{
    listOfPets =
    {
        new Dog(){Name = "Sharko", Type = PetEnum.Dog, Age = 2, FavouriteFood = "bacon"},
        new Dog(){Name = "Marko", Type = PetEnum.Dog, Age = 5, FavouriteFood = "dog food"}
    }
};

PetStore<Cat> catStore = new PetStore<Cat>()
{
    listOfPets =
    {
        new Cat(){Name = "Lilly", Type = PetEnum.Cat, Age = 3, Lazy = true, LivesLeft = 7},
        new Cat(){Name = "Milly", Type = PetEnum.Cat, Age = 4, Lazy = false, LivesLeft = 5}
    }
};

PetStore<Fish> fishStore = new PetStore<Fish>()
{
    listOfPets =
    {
        new Fish(){Name = "Nemo", Type = PetEnum.Fish, Age = 5, Color = "orange", Size = FishEnum.small},
        new Fish(){Name = "Dory", Type = PetEnum.Fish, Age = 8, Color = "blue", Size = FishEnum.medium}
    }
};

//Buy a dog and a cat from the Dog and Cat store
dogStore.BuyPet("Sharko");
dogStore.BuyPet("test");
catStore.BuyPet("Milly");
catStore.BuyPet("test");



//Call PrintPets() method on all stores
dogStore.PrintsPets();
catStore.PrintsPets();
fishStore.PrintsPets();
