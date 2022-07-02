namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyOfUser;
            int crystalPrice = 5;
            string approvalOfDeal = "да";
            int countOfUserCrystalls;
            int crystallsBying = 15;
            Console.WriteLine($"Приветствуем Вас в нашем магазине кристаллов, один кристалл стоит {crystalPrice} серебренников, " +
                $"сколько у Вас золотых ? : ");
            moneyOfUser = Convert.ToInt32(Console.ReadLine());

            if (moneyOfUser >= crystalPrice)
            {
                Console.WriteLine($"Предлагаем Вам приобрести {crystallsBying} кристаллов, Вы согласны? Напишите да или нет : ");
                approvalOfDeal = Console.ReadLine();
                if (approvalOfDeal == "да")
                {
                    countOfUserCrystalls = crystallsBying;
                    moneyOfUser -= crystallsBying * crystalPrice;
                    Console.WriteLine($"Вы купили {crystallsBying} кристаллов, у Вас осталось {moneyOfUser} кристаллов");
                }
                if (approvalOfDeal == "нет")
                {
                    Console.WriteLine("Какое Ваше предложение? Сколько кристаллов Вы хотите купить?: ");
                    crystallsBying = Convert.ToInt32(Console.ReadLine());
                    if (crystallsBying <= moneyOfUser)
                    {
                        moneyOfUser -= crystalPrice * crystallsBying;
                        Console.WriteLine($"Вы приобрели {crystallsBying} кристаллов, у Вас осталось {moneyOfUser} серебренников");
                    }
                    else if (crystallsBying > moneyOfUser)
                    {
                        Console.WriteLine("У вас недостаточно денег для покупки");
                    }
                }
            }
        }
    }
}
