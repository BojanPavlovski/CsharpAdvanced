namespace Task_2.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"This cats name is {Name} ,it is {Age} years old ,it's {Lazy} and has {LivesLeft} lives left.");
        }
    }
}
