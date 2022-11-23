using System;

namespace CSharpRS3
{
    class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        public static int liczbaSamochodow = 0;
        public Samochod()
        {
            marka = "";
            model = "";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0;
            liczbaSamochodow++;
        }
        public Samochod(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie)
        {
            this.marka = marka;
            this.model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
            liczbaSamochodow++;
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednieSpalanie / 100) * dlugoscTrasy;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return (srednieSpalanie * dlugoscTrasy) * cenaPaliwa;
        }
        public void WypiszInfo()
        {
            Console.WriteLine($"Marka:{marka}, model: {model}, ilość drzwi: {iloscDrzwi}, pojemność silnika: {pojemnoscSilnika}, średnie spalanie:{srednieSpalanie}");
        }
        public static void WypiszIloscSamochodow()
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