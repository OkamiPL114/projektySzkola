using Filmy;

namespace filmy
{
    class Program
    {
        static void Main()
        {
            Film f1 = new Film();
            f1.ustawTytul("Harry Potter");
            Console.WriteLine($"Tytuł: {f1.pobierzTytul()}");

            Console.WriteLine($"{f1.pobierzLiczbeWypozyczen()}");
            f1.inkrementuj();
            Console.WriteLine($"{f1.pobierzLiczbeWypozyczen()}");
        }
    }
}