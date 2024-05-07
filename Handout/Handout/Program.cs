namespace Handout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John",20);
            Console.WriteLine($"{john.Name} - {john.Age}");

            Person mary = new Person();
            mary.Name = "Mary";
            mary.Age = 18;
            Console.WriteLine($"{mary.Name} - {mary.Age}");

            Person nick = new Person("Nick",43);
            Console.WriteLine($"{nick.Name} - {nick.Age}");
        }
    }
}
