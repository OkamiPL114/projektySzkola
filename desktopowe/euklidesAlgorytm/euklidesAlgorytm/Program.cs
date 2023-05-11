namespace euklidesAlgorytm
{
    internal class Program
    {
        private static int euklidesAlgorythm(int a, int b) //fukcja algorytmu Euklidesa
        {
            while(a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }else
                {
                    b = b - a;
                }
            }
            return a;
        }
        static void Main()
        {
            int a;
            int b;
            while (true) //powtórz podanie liczby jeśli jest niepoprawna
            {
                Console.Write("Podaj a:");
                if(int.TryParse(Console.ReadLine(), out a))
                {
                    if(a < 1)
                    {
                        Console.WriteLine("Podana liczba jest równa zero bądź ujemna");
                    }else
                    {
                        break;
                    }
                }else
                {
                    Console.WriteLine("Źle wpisana liczba");
                }
            }
            while (true)
            {
                Console.Write("Podaj b:");
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    if (b < 1)
                    {
                        Console.WriteLine("Podana liczba jest równa zero bądź ujemna");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Źle wpisana liczba");
                }
            }
            Console.WriteLine($"Największy wspólny dzielnik {a} oraz {b} wynosi {euklidesAlgorythm(a, b)}");
        }

    }
}