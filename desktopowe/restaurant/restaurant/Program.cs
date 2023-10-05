namespace restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("Pyszotka", 20, "polska kuchnia");
            
            restaurant.DodajDanie("Pomidorowa", 15);
            restaurant.DodajDanie("Żurek", 17.5);
            restaurant.DodajDanie("Ananas", 6);
            restaurant.DodajDanie("Jabłecznik", 19.99);
            restaurant.DodajDanie("Schabowy", 24.99);
            
            foreach (var item in restaurant.menu)
            {
                Console.WriteLine($"{item.Name}, {item.Price}zł");
            }
            restaurant.SortujMenu();

            Console.WriteLine();
            foreach (var item in restaurant.menu)
            {
                Console.WriteLine($"{item.Name}, {item.Price}zł");
            }
            
            restaurant.WyswietlInformacje();
            Console.WriteLine();
            restaurant.UsunDanie("Pomidorowa");
            
            foreach (var item in restaurant.menu)
            {
                Console.WriteLine($"{item.Name}, {item.Price}zł");
            }

            Console.WriteLine($"Średnia cena dań: {restaurant.SredniaCena()}zł");
        }
    }
}