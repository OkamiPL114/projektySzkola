namespace sitoEratostenesa
{
    internal class Program
    {
        const int N = 100;
        static public void Sieve(bool[] arr)
        {
            for(int i = 2; i < Math.Sqrt(N); i++)
            {
                if(arr[i])
                {
                    for(int j = 2 * i; j < N; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            bool[] arr = new bool[N+1];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            arr[0] = false;
            arr[1] = false;
            
            Sieve(arr);
            
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}