using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace listViewDemo
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<User> users;
        public MainPage()
        {
            InitializeComponent();
            users = new ObservableCollection<User>()
            {
                new User(){ Name = "Andrzej Barzyk", Email = "abarzyk@zstjaslo.pl"},
                new User(){ Name = "Kacper Kołodziej", Email = "kolodziej@zstjaslo.pl"},
                new User(){ Name = "Michał Dziedzic", Email = "dziedzic@zstjaslo.pl"}
            };

            usersListView.ItemsSource = users;            
        }

        private async void addUserButton_Clicked(object sender, EventArgs e)
        {
            var enteredName = await DisplayPromptAsync("Dodawanie nowego urzytkownika", "Podaj imię i nazwisko", "OK", "Anuluj");
            if(enteredName == null) return;

            var enteredEmail = await DisplayPromptAsync("Dodawanie nowego urzytkownika", "Podaj email", "OK", "Anuluj");
            if (enteredEmail == null) return;

            users.Add(new User() { Name = enteredName, Email = enteredEmail });
        }
    }
}
