using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ListViewApp
{
    public partial class MainPage : ContentPage
    {
        const string MALE_IMG = "male.png";
        const string FEMALE_IMG = "female.png";
        private ObservableCollection<Person> people;
        public MainPage()
        {
            InitializeComponent();
            people = new ObservableCollection<Person>()
            {
                new Person(){ FirstName = "Jan", LastName = "Kowalski", Location="Jasło", Country="Polska", Gender=Gender.Male, Image=MALE_IMG}
            };
            peopleListView.ItemsSource = people;
        }
    }
}
