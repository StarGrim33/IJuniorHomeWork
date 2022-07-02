namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOutput;
            string userOutput;
            Console.WriteLine("Какое сообщение Вы хотите вывести?: ");
            userOutput = Console.ReadLine();
            Console.WriteLine("Сколько раз нужно его вывести?: ");
            countOfOutput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countOfOutput; i++)
            {
                Console.WriteLine(userOutput);
            }
        }
    }
}
