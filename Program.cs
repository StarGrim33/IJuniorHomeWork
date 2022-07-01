namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNameOfUser = "Kuzmichev";
            string secondNameOfUser = "Vladislav";
            Console.WriteLine($"Ваше имя: {firstNameOfUser}. Фамилия: {secondNameOfUser}");
            Console.WriteLine("Упс, что то пошло не так, нажмите любую клавишу, чтобы все исправить!");
            (firstNameOfUser, secondNameOfUser) = (secondNameOfUser, firstNameOfUser);
            Console.WriteLine($"Ваше имя: {firstNameOfUser}. Фамилия: {secondNameOfUser}");
        }
    }
}
