using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    internal class Restaurant
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public string KitchenType { get; set; }
        public List<Dish> menu = new List<Dish>();

        public Restaurant(string name, int seats, string kitchenType)
        {
            Name = name;
            Seats = seats;
            KitchenType = kitchenType;
        }
        /*
            WyswietlInformacje wyświetla podstawowe informacje o restauracji
         */
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwa: {Name}, ilość miejsc: {Seats}, rodzaj kuchni: {KitchenType}");
        }
        /*
            SortujMenu sortuje listę menu bąbelkowo po nazwach dań rosnąco
         */
        public void SortujMenu()
        {
            for(int i = 0; i < menu.Count; i++)
            {
                for(int j = 0; j < menu.Count; j++)
                {
                    if (String.Compare(menu[i].Name, menu[j].Name) < 0)
                    {
                        (menu[i], menu[j]) = (menu[j], menu[i]);
                    }
                }
            }
        }
        /*
            DodajDanie dodaje nowe danie do listy menu z wartościami podanymi w parametrach funkcji
         */
        public void DodajDanie(string dish, double price)
        {
            menu.Add(new Dish(dish, price));
            Console.WriteLine($"Dodano danie {dish}");
        }
        /*
            funkcja UsunDanie znajduje danie podane w parametrze funkcji i usuwa je z listy menu
         */
        public void UsunDanie(string dish)
        {
            for(int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Name == dish)
                {
                    menu.RemoveAt(i);
                }
            }
            Console.WriteLine($"Usunięto danie {dish}");
        }
        /*
            funkcja SredniaCena oblicza i zwraca średnią cenę z wszystkich dań w menu
         */
        public double SredniaCena()
        {
            double sum = 0;
            foreach (var item in menu)
            {
                sum += item.Price;
            }
            return Math.Round(sum / menu.Count, 2);
        }
    }
}
