namespace czynnikiPierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę do rozłożenia na czynniki pierwsze: ");
            int.TryParse(Console.ReadLine(), out var num);

            int prevNum = num;
            while (num > 1)
            {
                for(int i = 2; i < 10; i++)
                {
                    prevNum = num;
                    if(num % i == 0)
                    {
                        prevNum = num;
                        num = num / i;
                        Console.WriteLine($"{prevNum} / {i} = {num}");
                        break;
                    }
                }
                if(prevNum == num)
                {
                    num /= num;
                    Console.WriteLine($"{prevNum} / {prevNum} = {num}");
                }
            }
        }
    }
}