namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord;
            int age = 0;

            while (age < 100)
            {
                Console.WriteLine("Напишите стоп слово - quit");
                stopWord = Console.ReadLine();

                if (stopWord == "quit")
                {
                    age = 100;
                }

            }
            Console.WriteLine("Цикл остановлен!");
        }
    }
}
