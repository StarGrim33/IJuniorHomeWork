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

            float rubToUsd = 68.50f;
            float rubToEur = 75.90f;
            float usdToEur = 0.95f;

            float usdToRub = 59.58f;
            float eurToRub = 66.70f;
            float eurToUsd = 1.04f;

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
            Console.WriteLine("4 - обмен долларов на рубли");
            Console.WriteLine("5 - обмен евро на рубли");
            Console.WriteLine("6 - обмен евро на доллары");

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
                        eur += currencyCount / usdToEur;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное количество долларов");
                    }
                    break;

                case "4":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.WriteLine("Сколько долларов Вы хотите обменять?");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное количество долларов");

                    }
                    break;
                case "5":
                    Console.WriteLine("Обмен евро на рубли");
                    Console.WriteLine("Сколько евро Вы хотите обменять?");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (eur >= currencyCount)
                    {
                        eur -= currencyCount;
                        rub += currencyCount * eurToRub;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное количество евро");
                    }
                    break;
                case "6":
                    Console.WriteLine("Обмен евро на доллары");
                    Console.WriteLine("Сколько евро Вы хотите обменять");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (eur >= currencyCount)
                    {
                        eur -= currencyCount;
                        usd += currencyCount / eurToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное количество евро");
                    }
                    break;
            }
                    Console.WriteLine("На Вашем балансе: " + rub + " рублей, " + usd + " долларов и " + eur + " евро.");
            }
        }
    }
