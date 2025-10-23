namespace MinuProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See on minu uus projekt!");
            Random Random = new Random();
            int RandomNumber = Random.Next(1, 6);
            int Number = 15;
            Console.WriteLine(RandomNumber + Number);

        }
    }
}
