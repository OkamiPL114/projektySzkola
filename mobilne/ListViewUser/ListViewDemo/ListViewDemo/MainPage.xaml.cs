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
                new User(){ Name = "Jan Kowalski", Email="kowalski@test.com"},
                new User(){ Name = "Ewa Nowak", Email="nowak@test.com"},
                new User(){ Name = "Paweł Panowski", Email="panowski@test.com"},
                new User(){ Name = "Andrzej Barzyk", Email="barzyk@test.com"},
                new User(){ Name = "Mateusz Czajka", Email="matCzajka@test.com"},
                new User(){ Name = "Paweł Czajka", Email="pawCzajka@test.com"},
                new User(){ Name = "Mariusz Dybaś", Email="dybas@test.com"},
                new User(){ Name = "Dominik Czech", Email="czech@test.com"},
                new User(){ Name = "Wiktor Fornalczyk", Email="fornalczyk@test.com"},
                new User(){ Name = "Wiktor Gajda", Email="gajda@test.com"},
                new User(){ Name = "Michał Dziedzic", Email="dziedzic@test.com"},
                new User(){ Name = "Dominik Gajewski", Email="domGajewski@test.com"},
                new User(){ Name = "Radek Gajewski", Email="radGajewski@test.com"},
                new User(){ Name = "Szymon Gałuszka", Email="galuszka@test.com"},
                new User(){ Name = "Kacper Kołodziej", Email="kolodziej@test.com"}
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

        private async void moreMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var user = (User)menuItem.CommandParameter; // bieżący użytkownik
            var userDetails = $"Nazwa : {user.Name}\nEmail: {user.Email}";
            await DisplayAlert("informacje o użytkowniku", userDetails, "OK");
        }

        private async void deleteMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var user = (User)menuItem.CommandParameter;

            var delete = await DisplayAlert($"Usuwanie użytkownika: {user.Name}", "Czy na pewno usunąć użytkownika?", "Tak", "Nie");

            if (!delete) return;

            var isDeleted = users.Remove(user);

            string message = "";
            if (isDeleted)
                message = $"Pomyślnie usunięto użytkownika {user.Name}";
            else
                message = $"Wystąpił błąd podczas usuwania użytkownika {user.Name}";

            await DisplayAlert("Usuwanie użytkownika", message, "OK");
        }

        private void usersListView_Refreshing(object sender, EventArgs e)
        {
            // operacje związane z odświeżeniem listy
            usersListView.ItemsSource = users;
            usersListView.EndRefresh(); // zakończenie jawne odświeżania
        }

        private async void editMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var user = (User)menuItem.CommandParameter;

            var editedIndex = users.IndexOf(user);

            var name = await DisplayPromptAsync("Edycja użytkownika", $"Wpisz imię użytkownika {user.Name}", "Zatwierdź", "Anuluj", $"{user.Name}");
            if (name == null || name.Trim().Length == 0)
                return;
            user.Name = name;

            var email = await DisplayPromptAsync("Edycja użytkownika", "Wpisz email użytkownika", "Zatwierdź", "Anuluj", $"{user.Email}");
            if (email == null || email.Trim().Length == 0)
                return;
            user.Email = email;

            users[editedIndex] = user;
        }
    }
}
