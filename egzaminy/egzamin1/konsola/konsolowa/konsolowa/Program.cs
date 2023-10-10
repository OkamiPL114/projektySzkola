namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notatka notatka1 = new Notatka("Zakupy", "Zeszyt, ołówki, długopisy,");
            Notatka notatka2 = new Notatka("Rachunki", "Zapłacić prąd i internet");
            
            notatka1.WyswietlNotatke();
            notatka1.WyswietlPola();
            
            notatka2.WyswietlNotatke();
            notatka2.WyswietlPola();
        }
    }
}