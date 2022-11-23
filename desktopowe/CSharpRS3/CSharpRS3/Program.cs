using System;

namespace CSharpRS3
{
    class Samochod
    {
        public static int ilosc = 0;
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private int liczbSamochodow = 0;
        public Samochod()
        {
            marka = "";
            model = "";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0;
            liczbSamochodow++;
        }
        public Samochod(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie)
        {
            this.marka = marka;
            this.model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
            liczbSamochodow++;
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double srednieSpalanie = 0;
            return 0;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return 0;
        }
        public void WypiszInfo()
        {

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