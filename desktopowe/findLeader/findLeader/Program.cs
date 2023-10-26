namespace findLeader
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 2, 3, 2, 2, 1, 5, 2, 2, 6};
            try
            {
                Console.WriteLine($"Liderem w tej tablicy jest {FindLeader(arr)}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
        }
        static int FindLeader(int[] arr)
        {
            if(arr.Length == 0) throw new Exception("Tablica jest pusta");
            int candidate = arr[0];
            int count = 1;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if(count == 0)
                {
                    candidate = arr[i];
                    count = 1;
                }
            }
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(candidate == arr[i])
                {
                    counter++;
                }
            }

            if(counter > arr.Length / 2)
            {
                return candidate;
            }
            throw new Exception("Nie ma lidera w tej tablicy");
        }
    }
}