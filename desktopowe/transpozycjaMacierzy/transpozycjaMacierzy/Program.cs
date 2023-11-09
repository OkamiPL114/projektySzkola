namespace transpozycjaMacierzy
{
    internal class Program
    {
        static void displayArray(int[,] array, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj ilość wierszy macierzy: ");
            int.TryParse(Console.ReadLine(), out int rows);
            Console.Write("Podaj ilość kolumn macierzy: ");
            int.TryParse(Console.ReadLine(), out int cols);

            int[,] arr = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"Podaj [{i + 1},{j + 1}] element macierzy: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Macierz prezd transpozycją: ");
            displayArray(arr, rows, cols);

            int[,] newArr = new int[cols, rows];
            for(int i = 0; i < cols; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    newArr[i, j] = arr[j, i];
                }
            }

            Console.WriteLine("Macierz po transpozycji: ");
            displayArray(newArr, cols, rows);
        }
    }
}