using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel; // ObservableCollection

namespace ListViewDemo
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<User> users;
        public MainPage()
        {
            InitializeComponent();

            users = new ObservableCollection<User>()
            {
                new User(){ Name = "Jan Kowalski", Email="kowalski@test.com"}
            };
           
            usersListView.ItemsSource = users;

        }

        private async void addUser_Clicked(object sender, EventArgs e)
        {
            var enteredName = await DisplayPromptAsync("Dodawanie nowego użytkownika", "Podaj imię i nazwisko:", "OK", "Anuluj");

            if (enteredName == null || enteredName.Trim().Length == 0)
            {
                await DisplayAlert("Błąd", "Wymagane imię i nazwisko!", "OK");
                return;
            }

            var enteredEmail = await DisplayPromptAsync("Dodawanie nowego użytkownika", "Podaj email:", "OK", "Anuluj");

            if (enteredEmail == null || enteredEmail.Trim().Length == 0)
            {
                await DisplayAlert("Błąd", "Wymagany email!", "OK");
                return;
            }

            users.Add(new User() { Name = enteredName, Email = enteredEmail });


        }
    }
}
