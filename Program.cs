namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int firstPositiveNumber = 3;
            int secondPositiveNumber = 5;
            int sumOfNumbers = 0;
            int minNumber = 0;
            int maxNumber = 100;
            int randomNumber = random.Next(minNumber, maxNumber);

            Console.WriteLine("Случайное число равно: " + randomNumber);
            Console.ReadLine();
            
            for (int i = 0; i <= randomNumber; i++)
            {
                if (i % firstPositiveNumber == 0 || i % secondPositiveNumber == 0)
                {
                    sumOfNumbers += i;
                }
            }

            Console.WriteLine("Сумма всех положительных чисел меньше " + randomNumber + " и кратных числам " 
                + firstPositiveNumber + " и " + secondPositiveNumber + " равна: " + sumOfNumbers);
            Console.ReadLine();
        }
    }
}
