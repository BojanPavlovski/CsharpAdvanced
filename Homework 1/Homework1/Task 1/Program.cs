using Homework.Domain.Models;

Dog dog = new Dog("Lucky", "Petko", "ball");
dog.PrintAnimal();
dog.Bark();

Dog secondDog = new Dog("Blacky", "Ivan", "chew toy");
secondDog.PrintAnimal();
secondDog.Bark();

Cat cat = new Cat("Bella", "Maja", "tuna", "brown");
cat.Eat("tuna");
cat.PrintAnimal();

Cat secondCat = new Cat("Luther", "Aleksandar", "cat food", "white");
secondCat.Eat("cat food");
secondCat.PrintAnimal();