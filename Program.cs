namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pateintInQueue;
            int timePerPacient = 10;
            int estimatedTimeHours;
            int estimatedTimeMinutes;
            int minutesPerHour = 60;
            Console.WriteLine("Введите количество старушек в очереди: ");
            pateintInQueue = Convert.ToInt32(Console.ReadLine());
            estimatedTimeHours = (timePerPacient * pateintInQueue) / minutesPerHour;
            estimatedTimeMinutes = (timePerPacient * pateintInQueue) % minutesPerHour;

            Console.WriteLine($"Время ожидания в очереди составляет {estimatedTimeHours} часа и {estimatedTimeMinutes} минут");
        }
    }
}
