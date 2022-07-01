namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyOfUser;
            int priceOfOneCristall = 1;
            string approvalOfDeal = "да";
            int countOfUserCrystalls;
            Console.WriteLine($"Приветствуем Вас в нашем магазине кристаллов, один кристалл стоит {priceOfOneCristall} серебренников, " +
                $"сколько у Вас золотых ? : ");
            moneyOfUser = Convert.ToInt32(Console.ReadLine());

            if (moneyOfUser >= 50)
            {
                Console.WriteLine($"Предлагаем Вам приобрести {moneyOfUser} кристаллов, Вы согласны? Напишите да или нет : ");
                approvalOfDeal = Console.ReadLine();

                if (approvalOfDeal == "да")
                {
                    moneyOfUser -= priceOfOneCristall * moneyOfUser;
                    Console.WriteLine($"Вы купили {moneyOfUser} кристаллов, у Вас осталось {moneyOfUser} серебренников");
                }

                else 
                {
                    Console.WriteLine("Какое Ваше предложение? Сколько кристаллов Вы хотите купить?: ");
                    countOfUserCrystalls = Convert.ToInt32(Console.ReadLine());
                    moneyOfUser -= priceOfOneCristall * countOfUserCrystalls;
                    Console.WriteLine($"Вы приобрели {countOfUserCrystalls} кристаллов, у Вас осталось {moneyOfUser} серебренников");
                }
            } 
            }
        }
    }
