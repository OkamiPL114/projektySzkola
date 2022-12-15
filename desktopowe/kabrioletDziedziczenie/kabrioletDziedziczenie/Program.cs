namespace kabrioletDziedziczenie
{
    class Program
    {
        static void Main()
        {
            Samochod mercedes = new Samochod("Mercedes", 10, 240, 10);
            Kabriolet audi = new Kabriolet("Audi", 10, 210, 10, false);
            
            mercedes.Jedz(250, 300);
            mercedes.Jedz(10, 50);
            
            audi.Jedz(100, 100);
            audi.otworz_dach();
            audi.Jedz(100, 100);
        }
    }
}