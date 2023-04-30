namespace Task_2.Models
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"This dogs name is {Name},it is {Age} years old and it's favourite food is {FavouriteFood}");
        }
    }
}
