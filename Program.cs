namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int firstPositiveNumber = 3;
            int secondPositiveNumber = 5;
            int sumOfNumbers = 0;
            int randomNumber = rand.Next(0, 100);

            Console.WriteLine("Случайное число равно: " + randomNumber);
            Console.ReadLine();
            
            for (int i = 0; i <= randomNumber; i++)
            {
                if (i % firstPositiveNumber == 0 || i % secondPositiveNumber == 0)
                {
                    sumOfNumbers += i;
                }
            }

            Console.WriteLine("Сумма всех положительных чисел меньше " + randomNumber + " и кратных числам 3 и 5 равна: " 
                + sumOfNumbers);
            Console.ReadLine();
        }
    }
}
