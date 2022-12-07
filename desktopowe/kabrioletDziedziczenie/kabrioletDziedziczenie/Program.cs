namespace kabrioletDziedziczenie
{
    class Samochod
    {
        protected string marka;
        protected int poj_baku;
        protected int predkosc_max;
        protected int zuzycia_paliwa;

        public Samochod(string marka, int poj_baku, int predkosc_max, int zuzycia_paliwa)
        {
            this.marka = marka;
            this.poj_baku = poj_baku;
            this.predkosc_max = predkosc_max;
            this.zuzycia_paliwa = zuzycia_paliwa;
        }
        public void Jedz(float jakSzybko, float jakDaleko)
        {

        }
    }
    internal class Program
    {
        static void Main()
        {
            
        }
    }
}