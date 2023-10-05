using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    internal class Dish
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Dish(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
