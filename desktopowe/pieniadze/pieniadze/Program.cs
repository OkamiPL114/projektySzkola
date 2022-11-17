using System;

namespace pieniadze
{
    class Czlowiek
    {
        public string Imie { get; set; }
        public int Gotowka { get; set; }
        public void WypiszInfo()
        {
            Console.WriteLine($"{Imie} ma {Gotowka} zł");
        }
        public void PrzyjmijPieniadze(int kwota)
        {
            if(kwota == 0)
            {
                Console.WriteLine($"{Imie} mówi: nie przyjmę 0 zł");
            }
            else
            {
                Gotowka += kwota;
            }
        }
        public int PrzekazPieniadze(int kwota)
        {
            if(kwota > Gotowka)
            {
                Console.WriteLine($"{Imie} mówi: nie mam tylu środków żeby ci dać {kwota} zł");
                return 0;
            }else if(kwota < 0)
            {
                Console.WriteLine($"{Imie} mówi: nie mogę ci dać ujemnych pieniędzy");
                return 0;
            }
            Gotowka -= kwota;
            return kwota;
        }
        public int Bonus(int kwota)
        {
            if (kwota == 5)
                return 10;
            return kwota;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Czlowiek jacek = new Czlowiek() { Imie = "Jacek", Gotowka = 50 };
            Czlowiek bartek = new Czlowiek() { Imie = "Bartek", Gotowka = 100 };
            while (true)
            {
                jacek.WypiszInfo();
                bartek.WypiszInfo();
                Console.Write("Podaj kwotę: ");
                string temp = Console.ReadLine();
                if(temp == "")
                {
                    break;
                }else
                {
                    int kwota = int.Parse(temp);
                    Console.Write("Pieniądze ma przekazać: ");
                    string przekazujacy = Console.ReadLine();
                    if(przekazujacy == "Bartek")
                    {
                        kwota = bartek.Bonus(kwota);
                        kwota = bartek.PrzekazPieniadze(kwota);
                        jacek.PrzyjmijPieniadze(kwota);
                    }
                    else if(przekazujacy == "Jacek")
                    {
                        kwota = jacek.Bonus(kwota);
                        kwota = jacek.PrzekazPieniadze(kwota);
                        bartek.PrzyjmijPieniadze(kwota);
                    }else
                    {
                        Console.WriteLine("Podaj osobę przekazującą");
                    }
                }
            }
        }
    }
}
