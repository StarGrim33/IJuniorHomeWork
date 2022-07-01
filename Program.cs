namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyOfUser;
            int priceOfOneCristall = 10;
            string approvalOfDeal = "да";
            Console.WriteLine("Приветствуем Вас в нашем магазине кристаллов, сколько золота Вы готовы потратить на покупку ? : ");
            moneyOfUser = Convert.ToInt32(Console.ReadLine());
            if (moneyOfUser >= 10)
            {
                Console.WriteLine("Предлагаем Вам приобрести 10 кристаллов по акционной цене 10 серебренников, напишите да или нет : ");
                approvalOfDeal = Console.ReadLine();
                if (approvalOfDeal == "да")
                {
                    moneyOfUser -= priceOfOneCristall * 10;
                    Console.WriteLine($"Теперь у Вас 10 кристаллов и {moneyOfUser} серебренников");
                }
                
            } 
            }
        }
    }
