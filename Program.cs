namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "quit";
            while (stopWord != "exit")
            {
                Console.WriteLine("Напишите стоп слово - exit");
                stopWord = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
