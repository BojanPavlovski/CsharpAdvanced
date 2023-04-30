using Task_2.Enum;

namespace Task_2.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public PetEnum Type { get; set; }
        public int Age { get; set; }
        public abstract void PrintInfo();

    }
}
