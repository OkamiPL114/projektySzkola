namespace szukanieLinioweOrazBinarne
{
    internal class Program
    {
        static private void bubbleSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for(int j = 0; j < tab.Length; j++)
                {
                    if (tab[j] > tab[i])
                    {
                        (tab[i], tab[j]) = (tab[j], tab[i]);
                    }
                }
            }
        }
        static private int[] linearFind(int[] tab, int searched)
        {
            int tries = 1;
            int[] resultTab = new int[2];
            for(int i = 0; i < tab.Length;i++)
            {
                if (tab[i] == searched)
                {
                    resultTab[0] = i;
                    resultTab[1] = tries;
                    return resultTab;
                }
                tries++;
            }
            resultTab[0] = -1;
            return resultTab;
        }
        private static int[] binearFind(int[] tab, int searched)
        {
            int tries = 1;
            int[] resultTab = new int[2];
            int left = 0, right = tab.Length - 1;
            while(left <= right)
            {
                int middle = left + (right - left) / 2;
                if (tab[middle] == searched)
                {
                    resultTab[0] = middle;
                    resultTab[1] = tries;
                    return resultTab;
                }
                if (tab[middle] > searched)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
                tries++;
            }
            resultTab[0] = -1;
            return resultTab;
        }
        static void Main(string[] args)
        {
            
            Console.Write("Podaj ilość liczb: ");
            int.TryParse(Console.ReadLine(), out int count);
            int[] tab = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Podaj {i} element tablicy: ");
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Tablica przed sortowaniem: ");
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }

            bubbleSort(tab);

            Console.WriteLine();
            Console.Write("Tablica po sortowaniu: ");
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine();
            Console.Write("Wpisz liczbę której szukasz: ");
            int.TryParse(Console.ReadLine(), out int searched);
            
            Console.WriteLine();
            int[] findResult = linearFind(tab, searched);
            if (findResult[0] > -1)
            {
                Console.WriteLine($"Liczba {searched} jest w tablicy pod indeksem {findResult[0]}. Liczba prób: {findResult[1]}");
            }
            else
            {
                Console.WriteLine($"Liczby {searched} nie ma w tablicy");
            }

            findResult = binearFind(tab, searched);
            if (binearFind(tab, searched)[0] > -1)
            {
                Console.WriteLine($"Liczba {searched} jest w tablicy pod indeksem {findResult[0]}. Liczba prób: {findResult[1]}");
            }
            else
            {
                Console.WriteLine($"Liczby {searched} nie ma w tablicy");
            }
        }
    }
}