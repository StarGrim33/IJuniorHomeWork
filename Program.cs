namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moduleAlpha = 980;
            int moduleBetta = 1050;
            int moduleGamma = 450;

            int userChoice;
            string userInput;
            int sumOfServers = moduleAlpha + moduleBetta + moduleGamma;

            int passwordAlpha = 123456;
            int passwordBetta = 123456;
            int passwordGamma = 123456;

            Random random = new Random();
            int errorsInAlpha = random.Next(0, 300);
            int errorsInBetta = random.Next(0, 350);
            int errorsInGamma = random.Next(0, 150);

            Console.WriteLine("Программа для управления оборудованием в дата центре, нажмите любую кнопку для продолжения");
            Console.ReadKey();
            Console.Clear();

            Console.SetCursorPosition(25, 4);
            Console.WriteLine(" Меню : ");
            Console.WriteLine("1 - Посмотреть количество серверных машин в модулях");
            Console.WriteLine("2 - Изменить пароль на вход в модули");
            Console.WriteLine("3 - Посмотреть количество ошибок серверов в модулях");
            Console.WriteLine("4 - Изменить цвет фона программы");
            userInput = Convert.ToString(Console.ReadLine());

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Общее количество серверных машин во всех модулях - " + sumOfServers);
                    Console.WriteLine("Какой модуль Вас интересует ?");
                    Console.WriteLine("1 - Альфа\n2 - Betta\n3 - Gamma");
                    userChoice = Convert.ToInt32(Console.ReadLine());

                    if (userChoice == 1)
                    {
                        Console.WriteLine("Количество серверных машин в модуле Альфа - " + moduleAlpha);
                        Console.WriteLine("Чтобы вернуться назад нажмите - Esc");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Количество серверных машин в модуле Бетта - " + moduleBetta);
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Количество серверных машин в модуле Бетта - " + moduleGamma);
                    }
                    break;

                case "2":
                    Console.WriteLine(" Установка пароля на вход в модули ");
                    Console.WriteLine(" В каком модуле Вы хотите установить пароль на вход ? ");
                    Console.WriteLine("1 - Альфа\n2 - Betta\n3 - Gamma");
                    userChoice = Convert.ToInt32(Console.ReadLine());

                    if (userChoice == 1)
                    {
                        Console.WriteLine("Введите текущий пароль: ");
                        passwordAlpha = Convert.ToInt32(Console.ReadLine());
                        if (passwordAlpha == 123456)
                        {
                            Console.WriteLine("Введите новый пароль: ");
                            passwordAlpha = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Пароль изменен.");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Введите текущий пароль: ");
                        passwordBetta = Convert.ToInt32(Console.ReadLine());
                        if (passwordBetta == 123456)
                        {
                            Console.WriteLine("Введите новый пароль: ");
                            passwordBetta = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Пароль изменен.");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Введите текущий пароль: ");
                        passwordGamma = Convert.ToInt32(Console.ReadLine());
                        if (passwordGamma == 123456)
                        {
                            Console.WriteLine("Введите новый пароль: ");
                            passwordGamma = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Пароль изменен");
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное значение");
                    }
                    break;
                case "3":
                    Console.WriteLine("Посмотреть количество ошибок серверов в модулях");
                    Console.WriteLine("Какой модуль Вас интересует ?");
                    Console.WriteLine("1 - Альфа\n2 - Betta\n3 - Gamma");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Количество инцидентов в модуле Alpha - " + errorsInAlpha);
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Количество инцидентов в модуле Betta - " + errorsInBetta);
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Количество инцидентов в модуле Gamma - " + errorsInGamma);
                    }
                    break;
                case "4":
                    Console.WriteLine("Изменение цвета фона программы. Какой цвет Вы хотите выбрать: ? ");
                    Console.WriteLine("1-Красный\n2-Голубой\n3-Зеленый\n4-Желтый\n5-Белый");
                    userChoice= Convert.ToInt32(Console.ReadLine());
                    if (userChoice == 1)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Цвет консоли изменен");
                    }
                    if (userChoice == 2)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("Цвет консоли изменен");
                    }
                    if (userChoice == 3)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Цвет консоли изменен");
                    }
                    if (userChoice == 4)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.WriteLine("Цвет консоли изменен");
                    }
                    if (userChoice == 5)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Цвет консоли изменен");
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестное значение ввода, пожалуйста, введите необходимую цифру для навигации по меню");
                    break;
            }
            }
        }
    }