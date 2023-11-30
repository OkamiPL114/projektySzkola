namespace podzbiorySpojne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj długość ciągu: ");
            int length = int.Parse(Console.ReadLine());
            
            int[] arr = new int[length];
            for(int i = 0; i < length; i++)
            {
                Console.Write($"Podaj {i + 1} element ciągu: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();

            int sum = 0;
            int max = -100;
            int index = 0;

            for(int i = 0; i < length; i++) // TODO: można by to było teorytycznie sprawdzić na jednej pętli
            {
                sum += arr[i]; // zacznij od liczby
                for(int j = i + 1; j < length; j++)
                {
                    sum += arr[j]; // dodawaj kolejne liczby, jeśli są
                }
                if(sum > max)
                {
                    max = sum; // przypisz największą sumę z podciągu arr[i] do arr[length - 1]
                    index = i; // zapamiętaj start podciągu
                }
                sum = 0;
            }

            Console.WriteLine($"Maksymalna suma: {max}");
            Console.WriteLine($"Podciąg sumy {max}:");
            for(int i = index; i < length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}