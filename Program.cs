namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyOfUser;
            int priceOfOneCrystall = 5;
            string approvalOfDeal = "да";
            int countOfUserCrystalls;
            Console.WriteLine($"Приветствуем Вас в нашем магазине кристаллов, один кристалл стоит {priceOfOneCrystall} серебренников, " +
                $"сколько у Вас золотых ? : ");
            moneyOfUser = Convert.ToInt32(Console.ReadLine());

            if (moneyOfUser >= priceOfOneCrystall)
            {
                Console.WriteLine($"Предлагаем Вам приобрести {moneyOfUser} кристаллов, Вы согласны? Напишите да или нет : ");
                approvalOfDeal = Console.ReadLine();

                if (approvalOfDeal == "да")
                {
                    countOfUserCrystalls = moneyOfUser;
                    Console.WriteLine($"Вы купили {moneyOfUser} кристаллов");
                }

                else
                {
                    Console.WriteLine("Какое Ваше предложение? Сколько кристаллов Вы хотите купить?: ");
                    countOfUserCrystalls = Convert.ToInt32(Console.ReadLine());
                    if (countOfUserCrystalls <= moneyOfUser)
                    {
                        moneyOfUser -= priceOfOneCrystall * countOfUserCrystalls;
                        Console.WriteLine($"Вы приобрели {countOfUserCrystalls} кристаллов, у Вас осталось {moneyOfUser} серебренников");
                    }
                    else if (countOfUserCrystalls > moneyOfUser)
                    {

                        Console.WriteLine("У вас недостаточно денег для покупки");
                    }
                    }
                }
            }
        }
    }
