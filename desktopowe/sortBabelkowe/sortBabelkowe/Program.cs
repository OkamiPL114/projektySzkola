namespace sortBabelkowe
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 101);
            }
            sortujBabelkowo(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
        }
        private static void sortujBabelkowo(int[] arr)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                for(int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}