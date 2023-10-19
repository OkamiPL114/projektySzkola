using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmy
{
    class Film
    {
        private string tytul = "";
        private int liczbaWypozyczen = 0;
        public void ustawTytul(string tytul)
        {
            this.tytul = tytul;
        }
        public string pobierzTytul()
        {
            return this.tytul;
        }
        public int pobierzLiczbeWypozyczen()
        {
            return this.liczbaWypozyczen;
        }
        public void inkrementuj()
        {
            this.liczbaWypozyczen++;
        }
    }
}
