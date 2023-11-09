namespace liczbaArmstronga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int.TryParse(Console.ReadLine(), out int num);
            int actualNum = num;
            int power = 0;
            while(num > 0)
            {
                power++;
                num = num / 10;
            }
            
            num = actualNum;
            double narcist = 0;
            while(num > 0)
            {
                int digit = num % 10;
                narcist += Math.Pow(digit, power);
                num = num / 10;
                Console.Write($"{digit}^{power} + ");
            }
            Console.Write("\b\b");
            Console.Write($"= {narcist}");
            Console.WriteLine();

            if (actualNum == narcist)
            {
                Console.WriteLine($"{actualNum} = {narcist}. Liczba ta jest liczbą Armstronga");
            }
            else
            {
                Console.WriteLine($"{actualNum} =/= {narcist}. Liczba ta nie jest liczbą Armstronga");
            }
        }
    }
}