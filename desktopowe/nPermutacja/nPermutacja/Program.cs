namespace nPermutacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 2, 2, 2, 2 };
            int n = arr.Length;
            int count = 0; // zmienna sprawdzająca ilość zmian
            int[] checkArr = new int[n]; // stwórz tablicę sprawdzającą i wypełnij ją
            for(int i = 0; i < n; i++)
            {
                checkArr[i] = i + 1;
            }

            for(int i = 0; i < n; i++) // przejdź po całej tablicy
            {
                if(arr[i] > n) arr[i] = n; // jeśli liczba wychodzi poza permutację, zmień ją
                if(arr[i] == checkArr[arr[i] - 1]) checkArr[arr[i] - 1] = 0; // jeśli liczba wystąpi pierwszy raz, to zmień na zero
                else // jeśli liczba się powtórzyła
                {
                    count++; // zwiększ licznik zmienionych liczb
                    for(int j = 0; j < n; j++) // przejdź po dostępnych liczbach
                    {
                        if(checkArr[j] != 0) // jeśli znajdzie wolną liczbę
                        {
                            arr[i] = checkArr[j]; // zamień powtórzoną liczbę na inną
                            checkArr[j] = 0; // zaznacz ją jako wykorzystaną
                            break; // i przejdź do następnej liczby
                        }
                    }
                }
            }
            if(count > 0) Console.WriteLine($"Zmieniono {count} elementów");
            else Console.WriteLine("Tablica jest już permutacją");
            
            Console.WriteLine("Finalna tablica:");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}