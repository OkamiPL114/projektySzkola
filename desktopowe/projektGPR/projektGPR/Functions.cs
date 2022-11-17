using System;
using System.Collections.Generic;

namespace projektGPR
{
    class Functions
    {
        static Random random = new Random();
        private static int N = 20;
        private static int n = 3;
        private static int[] unsortedArray = new int[N];
        private static int[] sortedArray = new int[N];

        public static void InitiateProgram()
        {
            Console.Title = "Algorytmy Klasyczne Aplikacja Zaliczeniowa";
            Console.WriteLine("Inicjalizacja, proszę czekać....\n\n");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] = random.Next(0, 101);
            }
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        (sortedArray[j + 1], sortedArray[j]) = (sortedArray[j], sortedArray[j + 1]);
                    }
                }
            }

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = random.Next(0, 101);
            }
            Console.Clear();
        }
        public static void BinarySearch()
        {
            Console.Write("\nWpisz, jakiej liczby szukasz: ");
            int searched = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTablica zawiera liczby:\n");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write($"{sortedArray[i]} ");
            }

            int min = 0;
            int max = sortedArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searched == sortedArray[mid])
                {
                    Console.WriteLine($"\n\nSzukana liczba {searched} ma indeks {mid} w tablicy. Wcisnij ENTER aby kontynuować");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                else if (searched < sortedArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine($"\n\nLiczba {searched} nie znajduje się w tablicy. Wcisnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void NaturalNumberFactorial()
        {
            int number;
            do
            {
                Console.Write("\nPodaj liczbę naturalną: ");
                number = int.Parse(Console.ReadLine());
                int factorial = 1;
                if (number == 0) //na wypadek jakby ktoś nie zrozumiał
                {
                    Console.WriteLine("\nSilnia z zera jest równa zero\n");
                }
                else if (number < 0) //bo zawsze zakłada się że użytkownik to 10-letnie dziecko które pierwszy raz widzi komputer :)
                {
                    Console.WriteLine("\nLiczby ujemne nie należą do liczb naturalnych\n");
                }
                else
                {
                    for (int i = 1; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"\nSilnia liczby {number} to {factorial}");
                }
            } while (number <= 0);
            Console.WriteLine("\nWciśnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void BubbleSort()
        {
            Console.WriteLine("\nTablica przed sortowaniem:\n");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write($"{unsortedArray[i]} ");
            }
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        (unsortedArray[j + 1], unsortedArray[j]) = (unsortedArray[j], unsortedArray[j + 1]);
                    }
                }
            }
            Console.WriteLine("\n\nTablica po sortowaniu:\n");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write($"{unsortedArray[i]} ");
            }
            Console.WriteLine("\n\nWciśnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void IsPalindrome()
        {
            Console.Write("\nPodaj wyraz:");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    Console.WriteLine("\nWyraz nie jest palindromem. Wciśnij ENTER aby kontynuować");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }
            Console.WriteLine("\nWyraz jest palindromem. Wciśnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void CaesarCypher() //napisane bez pomocy internetu
        {
            Console.Write("\nPodaj wyraz do zaszyfrowania: ");
            string inserted = Console.ReadLine();
            char[] word = new char[inserted.Length];
            for (int i = 0; i < inserted.Length; i++)
            {
                word[i] = inserted[i];
            }

            Console.Write("\nO ile chcesz przesunąć wyraz: ");
            int change = int.Parse(Console.ReadLine());
            string alphabet = "aąbcćdeęfghijklmnńoóprsśtuwxyzźż"; //32 znaki

            for (int i = 0; i < word.Length; i++) //przejdź po każdej literze
            {
                for (int j = 0; j < alphabet.Length; j++) //przejdź po każdej literze z alfabetu
                {
                    if (word[i] == alphabet[j]) //znajdź literę w alfabecie
                    {
                        if (j + change > alphabet.Length - 1) //sprawdź czy zmiana przekroczy długość alfabetu
                        {
                            int overflow = j + change - alphabet.Length; //znajdź literę po przekroczeniu długości
                            word[i] = alphabet[overflow]; //przesuń literę o przekroczenie
                        }
                        else
                        {
                            word[i] = alphabet[j + change]; //przesuń literę
                        }
                        break; //jeśli znajdzie literę w alfabecie to cofa się, bo zrobi z wyrazu źźźźź
                    }
                }
            }
            Console.Write("\nZaszyfrowany wyraz: \n\n");
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine("\n\nWciśnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void NotationONP()
        {
            Console.Write("\nPodaj działanie odwrotnej notacji polskiej: ");
            string input = Console.ReadLine();
            Stack<int> stck = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    stck.Push(int.Parse(input[i].ToString())); //tu musi być parse, bo potem char na inta psuje operację (znalezienie tego błędu zajęło mi jakieś 1.5 godziny, jak nie więcej)
                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    char operation = input[i];
                    int num1 = stck.Pop();
                    int num2 = stck.Pop();
                    switch (operation)
                    {
                        case '+': stck.Push(num2 + num1); break;
                        case '-': stck.Push(num2 - num1); break;
                        case '*': stck.Push(num2 * num1); break;
                        case '/': stck.Push(num2 / num1); break;
                    }
                }
            }
            Console.Write($"\nWynik podanego działania to {stck.Pop()}. Wciśnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void FindMinimumAndMaximum()
        {
            int[] array = new int[N];
            Console.WriteLine("\nWylosowano tablicę:\n");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write($"{array[i]} ");
            }
            int max = 0;
            int min = 100;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
                if (min > array[i])
                    min = array[i];
            }
            Console.WriteLine($"\n\nMinimalna wartość tablicy to {min}, a maksymalna to {max}. Wciśnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MatrixMultiplication()
        {
            int[,] arr1 = new int[n, n];
            int[,] arr2 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = random.Next(1, 10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[j, i] = random.Next(1, 10);
                }
            }

            Console.WriteLine("\nWartości w tablicach:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr1[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nWyniki mnożenia:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int mult = arr1[i, j] * arr2[j, i]; //kolumna definiuje który element z wiersza wybierze (bo zrobiłem na odwrót)
                    Console.Write($"{mult} ");
                }
            }
            Console.WriteLine("\n\nWciśnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MatrixReposition3x3()
        {
            int[,] arr1 = new int[n, n];
            int[,] arr2 = new int[n, n];
            Console.WriteLine("\nTablica przed zamianą:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = random.Next(1, 10);
                    Console.Write($"{arr1[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[i, j] = arr1[j, i]; //chciałem to zrobić na jednej tablicy, ale z jakiegoś powodu nie działa zamiana, mimo tego że w inicjacji zamiana działa >:(
                }
            }

            Console.WriteLine("\nTablica po zamianie:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nWciśnij ENTER aby kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MomentToRelax()
        {
            int searched = random.Next(0, 101);
            Console.WriteLine("\nWylosowano liczbę od 0 do 100.");
            while (true)
            {
                Console.WriteLine();
                Console.Write($"Zgadnij liczbę: ");
                int entered = int.Parse(Console.ReadLine());
                if (entered == searched)
                {
                    Console.WriteLine($"\nOdgadłeś! To była liczba {searched}. Wciśnij ENTER aby kontynuować");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                else if (entered > searched)
                {
                    Console.WriteLine($"\nSzukana liczba jest niższa od {entered}");
                }
                else if (entered < searched)
                {
                    Console.WriteLine($"\nSzukana liczba jest wyższa od {entered}");
                }
            }
        }
    }
}