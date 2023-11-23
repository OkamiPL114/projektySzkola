namespace szyfrSkokowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wyraz do zaszyfrowania: ");
            string word = Console.ReadLine();
            Console.Write("Podaj przesunięcie wyrazu: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int n = word.Length;
            int m = n / k;
            if(n % k != 0)
            {
                m += 1;
            }
            Console.Write("Zaszyfrowane słowo to: ");
            for(int i = 0; i < m; i++)
            {
                for(int j = i; j < n; j += m)
                {
                    Console.Write(word[j]);
                }
            }
        }
    }
}