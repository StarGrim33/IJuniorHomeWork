namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "exit";
            string userInput = "";

            while (stopWord != userInput)
            {
                Console.WriteLine($"Напишите стоп слово {stopWord}");
                userInput = (Console.ReadLine());
            }

        }
    }
}
