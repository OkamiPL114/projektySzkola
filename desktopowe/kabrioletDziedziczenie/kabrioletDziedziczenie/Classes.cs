using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (jakSzybko > predkosc_max)
            {
                Console.WriteLine($"{marka} nie pojedzie szybciej niż {predkosc_max}");
            }
            else
            {
                Console.WriteLine($"{marka} pojedzie z prędkością {jakSzybko}, oraz będzie musiało tankować {(int)(jakDaleko / (poj_baku * 100)) / zuzycia_paliwa} razy");
            }
        }
    }
    class Kabriolet : Samochod
    {
        protected bool dach_otwarty;
        public Kabriolet(string marka, int poj_baku, int predkosc_max, int zuzycia_paliwa, bool dach_otwarty) : base(marka, poj_baku, predkosc_max, zuzycia_paliwa)
        {
            this.marka = marka;
            this.poj_baku = poj_baku;
            this.predkosc_max = predkosc_max;
            this.zuzycia_paliwa = zuzycia_paliwa;
            this.dach_otwarty = dach_otwarty;
        }
        public void otworz_dach()
        {
            dach_otwarty = true;
        }
        public void zamknij_dach()
        {
            dach_otwarty = false;
        }
        public new void Jedz(float jakSzybko, float jakDaleko)
        {
            if (jakSzybko > predkosc_max)
            {
                Console.WriteLine($"{marka} nie pojedzie szybciej niż {predkosc_max}");
            }
            else
            {
                if (dach_otwarty)
                {
                    Console.WriteLine($"{marka} pojedzie z prędkością {jakSzybko}, oraz będzie musiało tankować {(int)(jakDaleko / (poj_baku * 100)) / (zuzycia_paliwa*1.15)} razy");
                }
                else
                {
                    Console.WriteLine($"Auto pojedzie z prędkością {jakSzybko}, oraz będzie musiało tankować {(int)(jakDaleko / (poj_baku * 100)) / zuzycia_paliwa} razy");
                }
            }
        }
    }
}
