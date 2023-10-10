using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolowa
{
    /*
    ************************************************
    klasa: Notatka
    opis: klasa rezprezentuje notatkę składającą się z tytułu i treści
    pola: iloscNotatek - statyczne pole przechowujące ilość zapisanych notatek
          id - unikalny identyfikator danej notatki
          tytul - tytuł notatki
          tresc - treść notatki
    autor: gała
    *************************************************
    */
    internal class Notatka
    {
        private static int iloscNotatek;
        private int id;
        protected string tytul;
        protected string tresc;
        public Notatka(string tytul, string tresc)
        {
            iloscNotatek++;
            this.id = iloscNotatek;
            this.tytul = tytul;
            this.tresc = tresc;
        }
        public void WyswietlNotatke()
        {
            Console.WriteLine($"Tytuł: {this.tytul}");
            Console.WriteLine($"Treść: {this.tresc}");
        }
        public void WyswietlPola()
        {
            Console.WriteLine($"Pola klasy: {iloscNotatek}; {this.id}; {this.tytul}; {this.tresc}");
        }
    }
}
