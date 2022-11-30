namespace STS__
{
    class Player
    {
        public int money { get; set; } = 100;
    }
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            Player gracz = new Player();
            Console.WriteLine("Witamy w STS___. Prawdopodobieństwo przegranej: 0,75");
            while(gracz.money > 0)
            {
                Console.WriteLine($"Gracz ma {gracz.money} zł.");
                Console.Write("Stawiana kwota: ");
                int bet = int.Parse(Console.ReadLine());
                if(bet > 0 && bet <= gracz.money)
                {
                    if (random.NextDouble() > 0.75)
                    {
                        Console.WriteLine($"Wygrałeś {2*bet} zł.");
                        gracz.money += bet;
                    }
                    else
                    {
                        Console.WriteLine($"Niestety, przegrałeś.");
                        gracz.money -= bet;
                    }
                }
                else if(bet <= 0)
                {
                    Console.WriteLine("Należy wpisać dodatnią liczbę.");
                }
                else if(bet > gracz.money)
                {
                    Console.WriteLine($"Nie masz wystarczająco pieniędzy aby postawić {bet} zł");
                }
            }
            Console.WriteLine("STS___ zawsze wygrywa.");
        }
    }
}