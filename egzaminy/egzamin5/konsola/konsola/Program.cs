namespace konsola
{
    class Osoba
    {
        Random random = new Random();
        public int Id { get; }
        private string imie;
        private string nazwisko;
        public string Imie { get { return imie; } set { imie = value; } }
        public string Nazwisko { get { return nazwisko; } set { nazwisko = value; } }
        public Osoba(string imie, string nazwisko)
        {
            this.Id = random.Next(0, 1001);
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }
    }
    class Uczen : Osoba
    {
        public string klasa;
        public Uczen(string imie, string nazwisko, string klasa) : base(imie, nazwisko)
        {
            this.klasa = klasa;
        }
        public void przedstawSie()
        {
            Console.WriteLine($"Jestem {this.Imie} {this.Nazwisko}, uczęszczam do klasy {this.klasa} a mój identyfikator to {this.Id}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Uczen Andrzej = new Uczen("Andrzej", "Barzyk", "5PTb");
            Uczen Joanna = new Uczen("Joanna", "Gałuszka", "5PTb");
            Andrzej.przedstawSie();
            Joanna.przedstawSie();
        }
    }
}