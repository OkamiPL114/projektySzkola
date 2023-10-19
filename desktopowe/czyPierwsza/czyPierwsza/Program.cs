namespace czyPierwsza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int.TryParse(Console.ReadLine(), out var x);
            if (czy_liczba_pierwsza(x))
            {
                Console.WriteLine($"Liczba {x} jest liczbą pierwszą");
            }
            else
            {
                Console.WriteLine($"Liczba {x} nie jest liczbą pierwszą");
            }
        }

        private static bool czy_liczba_pierwsza(int x)
        {
            if(x == 2) return true;
            if(x == 3) return true;
            for (int i = 2; i < 10; i++)
            {
                if(x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}