namespace zadanie1oraz2
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę minimalną:");
            int.TryParse(Console.ReadLine(), out int min);
            Console.Write("Podaj liczbę maksymalną:");
            int.TryParse(Console.ReadLine(), out int max);
            Console.Write("Podaj ilość liczb do wygenerowania:");
            int.TryParse(Console.ReadLine(), out int ilosc);
            int[] tab = GenerujLiczbyLosowe(min, max, ilosc);
            Console.WriteLine();
            Console.Write("Wygenerowane liczby przed sortowaniem: ");
            foreach (int i in tab)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            SortujBabelkowo(tab);
            Console.Write("Wygenerowane liczby po sortowaniu: ");
            foreach (int i in tab)
            {
                Console.Write($"{i}, ");
            }
            ////////////////// zad 2
            Console.WriteLine();
            Console.WriteLine();
            int[] tab2 = {10, 3, 7, 21, 4, 8, 15, 2, 1};
            Console.WriteLine($"Najmniejsza liczba: {ZnajdzMin(tab2)}");
            Console.WriteLine($"Największa liczba: {ZnajdzMax(tab2)}");
        }
        static private int[] GenerujLiczbyLosowe(int min, int max, int ilosc)
        {
            int[] tab = new int[ilosc];
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next(min, max+1);
            }
            return tab;
        }
        static private void SortujBabelkowo(int[] tab)
        {
            for(int i = 0;i < tab.Length;i++)
            {
                for(int j = 0; j < tab.Length; j++)
                {
                    if (tab[i] < tab[j])
                    {
                        (tab[i], tab[j]) = (tab[j], tab[i]);
                    }
                }
            }
        }
        static private int ZnajdzMin(int[] tab)
        {
            int min = ZnajdzMax(tab);
            for (int i = 0; i < tab.Length; i ++)
            {
                if (tab[i] < min)
                    min = tab[i];
            }
            return min;
        }
        static private int ZnajdzMax(int[] tab)
        {
            int max = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                    max = tab[i];
            }
            return max;
        }
    }
}