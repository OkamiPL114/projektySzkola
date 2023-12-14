namespace nPermutacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 1 };
            int n = arr.Length;
            int sum = 0;
            int arrSum = 0;
            for(int i = 0; i < n; i++) // sprawdź czy ciąg nie jest już permutacją
            {
                sum += i + 1;
                arrSum += arr[i];
            }
            if(arrSum == sum)
            {
                Console.WriteLine($"Ciąg jest już permutacją liczby {n}");
                return;
            }
            int[] goodArr = new int[n];
            for(int i = 0; i < n; i++)
            {
                goodArr[i] = i + 1;
            }
            for(int i = 0; i < n; i++)
            {
                if(arr[i] == goodArr[i]) goodArr[i] = 0;
                else
                {

                }
            }
        }
    }
}