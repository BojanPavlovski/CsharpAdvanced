using Task_2.Enum;

namespace Task_2.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public FishEnum Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"This fish's name is {Name},it is {Age} years old,it's {Color} and it's {Size}");
        }
    }
}
