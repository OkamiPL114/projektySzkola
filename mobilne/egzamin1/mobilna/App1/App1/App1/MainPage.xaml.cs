using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> notatki;
        public MainPage()
        {
            InitializeComponent();
            notatki = new ObservableCollection<string>()
            {
                "Zakupy: chleb, masło, ser",
                "Do zrobienia: obiad, umyć podłogi",
                "weekend: kino, spacer z psem"
            };
            notatkiListView.ItemsSource = notatki;
        }

        private void dodajButton_Clicked(object sender, EventArgs e)
        {
            string nowaNotatka = nowaNotatkaEntry.Text;
            notatki.Add(nowaNotatka);
        }
    }
}
