namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerNumber = 5;
            int highestNumber = 96;
            int step = 7;
            for (int i = lowerNumber; i <= highestNumber; i +=step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
