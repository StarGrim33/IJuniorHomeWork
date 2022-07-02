namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyOfUser;
            int crystalPrice = 5;
            int countOfUserCrystalls;
            int crystallsBying;
            Console.WriteLine($"Приветствуем Вас в нашем магазине кристаллов, один кристалл стоит {crystalPrice} серебренников, " +
                $"сколько у Вас золотых ? : ");
            moneyOfUser = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько кристаллов Вы хотите приобрести?");
            crystallsBying = Convert.ToInt32(Console.ReadLine());
            moneyOfUser -= crystalPrice * crystallsBying;
            countOfUserCrystalls = crystallsBying;
            Console.WriteLine($"Теперь у Вас {countOfUserCrystalls} кристаллов и {moneyOfUser} серебренников");
        }
    }
}
