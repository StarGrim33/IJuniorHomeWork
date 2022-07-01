namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInRow = 3;
            int picturesInAlbum = 52;
            Console.WriteLine($"Картинок в ряд: {picturesInRow}, всего картинок в альбоме: {picturesInAlbum}");
            Console.WriteLine("Полностью заполненных рядов: ");
            int filledRow = picturesInAlbum / picturesInRow;
            Console.WriteLine(filledRow);
            Console.WriteLine("Картинок сверх меры: ");
            int notEnoughFilledRow = picturesInAlbum % picturesInRow;
            Console.WriteLine(notEnoughFilledRow);
            Console.ReadLine();
        }
    }
}
