namespace dopelnienieLiczby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int.TryParse(Console.ReadLine(), out var number);
            int place = 1;
            int complement = 0;
            while (number > 0)
            {
                int compNum = 9 - (number % 10);
                number = number / 10;
                complement += compNum * place;
                place *= 10;
            }
            Console.WriteLine($"Dopełnieniem liczby {number} jest {complement}");
        }
    }
}