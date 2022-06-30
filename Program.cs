namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfUser;
            int ageOfUser;
            string zodiacSign;
            string workOfUser;
            Console.WriteLine("Здравствуйте! Как Вас зовут? : ");
            nameOfUser = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет? : ");
            ageOfUser = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у Вас знак зодиака? : ");
            zodiacSign = Console.ReadLine();
            Console.WriteLine("Кем вы работаете? : ");
            workOfUser = Console.ReadLine();
            Console.WriteLine($"Ваше имя {nameOfUser}, Вам {ageOfUser} лет, Ваш знак зодиака - {zodiacSign}, Вы работаете {workOfUser}");
        }
    }
}
