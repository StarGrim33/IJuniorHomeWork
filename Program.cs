namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Напишите стоп слово - quit");
                stopWord = Console.ReadLine();

                if (stopWord == "quit")
                {
                    i = 100;
                }
            }
            Console.WriteLine("Цикл остановлен!");
        }
    }
}
