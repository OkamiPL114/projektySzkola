namespace Konsola
{
    class Osoba
    {
        private int id;
        private string imie;
        public static int Ilosc = 0;
        public Osoba()
        {
            id = 0;
            imie = "";
            Ilosc++;
        }
        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            Ilosc++;
        }
        public Osoba(Osoba osoba) // konstruktor kopiujący
        {
            this.id = osoba.id;
            this.imie = osoba.imie;
            Ilosc++;
        }
        public void WyswietlImie(string imie2)
        {
            if(imie.Trim() == "")
            {
                Console.WriteLine("Brak danych");
            }
            else
            {
                Console.WriteLine($"Cześć {imie2}, mam na imię {this.imie}");
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.Ilosc}");
            Osoba os1 = new Osoba();

            Console.Write("Podaj id: ");
            int.TryParse(Console.ReadLine(), out int id);

            Console.WriteLine();
            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();
            
            Osoba os2 = new Osoba(id, imie);
            Osoba os3 = new Osoba(os2);

            os1.WyswietlImie("Jan");
            os2.WyswietlImie("Jan");
            os3.WyswietlImie("Jan");

            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.Ilosc}");
            Console.ReadKey();
        }
    }
}