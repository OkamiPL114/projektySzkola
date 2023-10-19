namespace pierwszaOrazEratostenesa
{
    internal class Program
    {
        static bool[] eratos;
        static void Main()
        {
            Console.Write("Podaj liczbę: ");
            int.TryParse(Console.ReadLine(), out var n);
            
            eratos = sito_eratostenesa(n);
            for(int i = 0; i <= n; i++)
            {
                if(eratos[i])
                {
                    Console.Write($"{i}, ");
                }
            }
            
            Console.WriteLine(); 
            Console.WriteLine();
            
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

        private static bool[] sito_eratostenesa(int n)
        {
            eratos = new bool[n + 1];
            for (int i = 0; i < eratos.Length; i++)
            {
                eratos[i] = true;
            }
            eratos[0] = false;
            eratos[1] = false;

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (eratos[i])
                {
                    for(int j = i * 2; j < n; j += i)
                    {
                        eratos[j] = false;
                    }
                }
            }
            return eratos;
        }

        private static bool czy_liczba_pierwsza(int x)
        {
            if(x == 2) return true;
            if(x == 3) return true;
            for(int i = 2; i < 10; i++)
            {
                if(x % i == 0) return false;
            }
            return true;
        }
    }
}