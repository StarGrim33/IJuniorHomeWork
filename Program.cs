namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rub;
            float usd;
            float eur;
            string userInput;
            float currencyCount;

            int rubToUsd = 68;
            int rubToEur = 75;
            float usdToEur = 0.95f;

            Console.WriteLine("Приветствуем Вас в нашем обменнике валют, пожалуйста, введите количество рублей: ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите количество долларов: ");
            usd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите количество евро: ");
            eur = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите какая операция Вас интересует: ");
            Console.WriteLine("1 - обмен рублей на доллары");
            Console.WriteLine("2 - обмен рублей на евро");
            Console.WriteLine("3 - обмен долларов на евро");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.WriteLine("Сколько рублей Вы хотите обменять ? ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное количество рублей");
                    }
                    break;

                case "2":
                    Console.WriteLine("Обмен рублей на евро");
                    Console.WriteLine("Сколько рублей Вы хотите обменять ? ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        eur += currencyCount / rubToEur;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное количество рублей");
                    }
                    break;

                case "3":
                    Console.WriteLine("Обмен долларов на евро");
                    Console.WriteLine("Сколько долларов Вы хотите обменять ? ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        usd -= currencyCount / usdToEur;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное количество долларов");
                    }
                    break;
            }
                    Console.WriteLine("На Вашем балансе: " + rub + " рублей, " + usd + " долларов и " + eur + " евро.");
            }
        }
    }
