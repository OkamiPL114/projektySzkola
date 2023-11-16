using System.Runtime.CompilerServices;

namespace algorytmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Algorytmy";
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1.Sortowanie Bąbelkowe");
                Console.WriteLine("2.Liczba dziesiętna na binarną");
                Console.WriteLine("3.Wyszukiwanie binarne");
                Console.WriteLine("4.Sito Eratostenesa");
                Console.WriteLine("5.Wyszukiwanie lidera");
                Console.WriteLine("6.Min oraz Max w tablicy");
                Console.WriteLine("7.Obliczanie silnii");
                Console.WriteLine("8.Transpozycja macierzy");
                Console.WriteLine("9.Wyjdź z programu");
                Console.Write("Wybierz jedną z opcji: ");
                switch (Console.ReadLine())
                {
                    case "1": babelkowe();break;
                    case "2": DziesNaBin();break;
                    case "3": szukanieBinarne();break;
                    case "4": sitoEratostenesa();break;
                    case "5": lider();break;
                    case "6": minOrazMax();break;
                    case "7": silnia();break;
                    case "8": transpozycjaMacierzy();break;
                    case "9": return;
                }
            }
        }

        private static void transpozycjaMacierzy()
        {
            Console.Write($"Podaj liczbę wierszy macierzy: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write($"Podaj liczbę kolumn macierzy: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] arr = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"Podaj [{i + 1},{j + 1}] element macierzy: ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Macierz przed transpozycją: ");
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            int[,] arr2 = new int[cols, rows];
            for(int i = 0; i < cols; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    arr2[j, i] = arr[i, j];
                }
            }

            Console.WriteLine("Macierz po transpozycji: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void silnia()
        {
            Console.Write("Podaj liczbę do obliczenia silnii: ");
            int factorialNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"Silnia liczby {factorialNum} iteracyjnie: ");
            int factorial = 1;
            for(int i = 1; i <= factorialNum; i++ )
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

            Console.WriteLine($"Silnia liczby {factorialNum} rekurencyjnie: {silniaRek(factorialNum)}");

        }
        private static int silniaRek(int n)
        {
            if (n == 1) return 1;
            return n * silniaRek(n - 1);
        }

        private static void minOrazMax()
        {
            int[] arr = { 2, 8, 4, 1, 7 };
            Console.WriteLine("Przeszukiwana tablica:");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int min = arr[0];
            int max = arr[1];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine($"Minimum tablicy to {min}, a maksimum to {max}");
        }

        private static void lider()
        {
            int[] arr = { 3, 3, 7, 3, 9, 3, 5 };
            Console.WriteLine("Przeszukiwana tablica:");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int candidate = arr[0];
            int leaderCount = 1;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == candidate)
                {
                    leaderCount++;
                }
                else
                {
                    leaderCount--;
                }
                if(leaderCount == 0)
                {
                    candidate = arr[i];
                    leaderCount = 1;
                }
            }
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == candidate)
                {
                    count++;
                }
            }
            if(count > arr.Length / 2)
            {
                Console.WriteLine($"Kandydatem jest {candidate} z ilością wystąpień {count}");
            }
            else
            {
                Console.WriteLine("Nie ma lidera w tej tablicy");
            }
        }

        private static void sitoEratostenesa()
        {
            Console.WriteLine();
            Console.Write("Podaj limit sita Eratostenesa: ");
            int limit = int.Parse(Console.ReadLine());
            bool[] arr = new bool[limit + 1];
            for(int i = 0; i < limit; i++)
            {
                arr[i] = true;
            }
            arr[0] = false;
            arr[1] = false;

            for(int i = 0; i < limit; i++)
            {
                if (arr[i])
                {
                    for(int j = i + i; j < limit; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }
            Console.WriteLine("Wygenerowane liczby:");
            for(int i = 0; i < limit; i++)
            {
                if (arr[i])
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        private static void szukanieBinarne()
        {
            Console.WriteLine();
            int[] arr = { 1, 2, 4, 5, 7, 9 };
            Console.WriteLine("Przeszukiwana tablica:");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int searched = 5;
            Console.WriteLine($"Szukana liczba to {searched}");
            int left = 0;
            int right = arr.Length - 1;
            while(left < right)
            {
                int middle = (left + right) / 2;
                if (arr[middle] == searched)
                {
                    Console.WriteLine($"Znaleziono liczbę {searched} w indexie {middle}");
                    return;
                }
                if (arr[middle] > searched)
                {
                    right = middle;
                }
                if (arr[middle] < searched)
                {
                    left = middle;
                }
            }
            Console.WriteLine($"Nie ma liczby {searched} w tablicy");
        }

        private static void DziesNaBin()
        {
            Console.WriteLine();
            Console.Write("Podaj liczbę dziesiętną: ");
            int dec = int.Parse(Console.ReadLine());
            int actualDec = dec;
            string bin = "";
            while (dec > 0)
            {
                bin += $"{dec % 2}";
                dec /= 2;
            }
            char[] binChar = bin.ToCharArray();
            Array.Reverse(binChar);
            bin = new string(binChar);
            Console.WriteLine($"Liczba {actualDec} w systemie binarnym: {bin}");
        }

        private static void babelkowe()
        {
            Console.WriteLine();
            int[] arr = { 4, 2, 7, 1, 9, 5 };
            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
            }

            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}