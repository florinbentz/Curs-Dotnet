namespace HAndouRabbit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbitA = new Rabbit();
            rabbitA.Eyes = Eyes.black;
            rabbitA.Fur = Fur.white;
            rabbitA.Gender = Gender.m;

            Rabbit rabbitB = new Rabbit()
            {
                Eyes = Eyes.red,
                Fur = Fur.gray,
                Gender = Gender.f
            };

            Console.WriteLine()
        }
    }
}
