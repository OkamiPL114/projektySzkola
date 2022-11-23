using System;

namespace CSharpRS3
{
    class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int IloscDrzwi { get; set; }
        public int PojemnoscSilnika { get; set; }
        public double SrednieSpalanie { get; set; }
        public static int LiczbaSamochodow = 0;
        public Samochod()
        {
            Marka = "";
            Model = "";
            IloscDrzwi = 0;
            PojemnoscSilnika = 0;
            SrednieSpalanie = 0;
            LiczbaSamochodow++;
        }
        public Samochod(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie)
        {
            this.Marka = marka;
            this.Model = model;
            this.IloscDrzwi = iloscDrzwi;
            this.PojemnoscSilnika = pojemnoscSilnika;
            this.SrednieSpalanie = srednieSpalanie;
            LiczbaSamochodow++;
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (SrednieSpalanie / 100) * dlugoscTrasy;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return (SrednieSpalanie * dlugoscTrasy) * cenaPaliwa;
        }
        public void WypiszInfo()
        {
            Console.WriteLine($"Marka:{Marka}, model: {Model}, ilość drzwi: {IloscDrzwi}, pojemność silnika: {PojemnoscSilnika}, średnie spalanie:{SrednieSpalanie}.");
        }
        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine($"Jest {LiczbaSamochodow} samochodów.");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Samochod s1 = new Samochod();
            s1.WypiszInfo();

            s1.Marka = "Fiat";
            s1.Model = "126";
            s1.IloscDrzwi = 2;
            s1.PojemnoscSilnika = 650;
            s1.SrednieSpalanie = 6.0;
            
            s1.WypiszInfo();
        
            Samochod s2 = new Samochod();
        }
    }
}