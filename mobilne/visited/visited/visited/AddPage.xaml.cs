using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace visited
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            string city = cityEntry.Text;
            string country = countryEntry.Text;
            float price = float.Parse(priceEntry.Text);
            int rating = (int)ratingSlider.Value;

            string ratingStr = "❤";
            for(int i = 0; i < rating; i++)
            {
                ratingStr += "❤";
            }
            LocationsDB.Locations.Add(new Location(){ City = city, Country = country, Price = price, Rating = ratingStr });
        }
    }
}