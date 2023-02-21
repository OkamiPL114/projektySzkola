using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace visited
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationsPage : ContentPage
    {
        public LocationsPage()
        {
            InitializeComponent();
            LocationsDB.Locations.Add(new Location()
            {
                City = "Jasło",
                Country = "Polska",
                Price = 150F,
                Rating = "❤❤❤❤"
            });
            locationsListView.ItemsSource = LocationsDB.Locations;
        }

        private void deleteMenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}