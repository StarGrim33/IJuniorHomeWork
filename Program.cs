namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord;

            while (true)
            {
                Console.WriteLine("Напишите стоп слово - quit");
                stopWord = Console.ReadLine();

                if (stopWord == "quit")
                {
                    break;
                }
            }
            Console.WriteLine("Цикл остановлен!");
        }
    }
}
