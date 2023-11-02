namespace dodawanieMacierzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dodawanie macierzy";

            Console.Write("Podaj ilość wierszy pierwszej macierzy: ");
            int.TryParse(Console.ReadLine(), out var rowsOne);

            Console.Write("Podaj ilość kolumn pierwszej macierzy: ");
            int.TryParse(Console.ReadLine(), out var columnsOne);
            
            Console.Write("Podaj ilość wierszy drugiej macierzy: ");
            int.TryParse(Console.ReadLine(), out var rowsTwo);
            
            Console.Write("Podaj ilość kolumn drugiej macierzy: ");
            int.TryParse(Console.ReadLine(), out var columnsTwo);
            
            if(rowsOne != rowsTwo || columnsOne != columnsTwo)
            {
                Console.WriteLine("Wymiary macierzy nie są takie same");
                return;
            }
            int[,] arr1 = new int[rowsOne, columnsOne];
            int[,] arr2 = new int[rowsTwo, columnsTwo];

            Console.WriteLine("Podaj elementy pierwszej macierzy: ");
            for(int i = 0; i < rowsOne; i++)
            {
                for(int j = 0; j < columnsOne; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("Podaj elementy drugiej macierzy: ");
            for (int i = 0; i < rowsTwo; i++)
            {
                for (int j = 0; j < columnsTwo; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Wyniki dodawania macierzy: ");
            int sum = 0;
            for(int i = 0; i < rowsOne; i++)
            {
                sum = 0;
                for(int j = 0; j < columnsOne; j++)
                {
                    sum = arr1[i, j] + arr2[i, j];
                    Console.Write($"{sum} ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}