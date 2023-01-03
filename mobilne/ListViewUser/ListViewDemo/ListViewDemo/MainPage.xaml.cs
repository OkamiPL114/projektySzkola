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

        private async void moreMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var user = (User) menuItem.CommandParameter; // bieżący użytkownik
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
            // operacje zwiąane z odświeżeniem listy
            usersListView.ItemsSource = users;
            usersListView.EndRefresh(); // zakończenie jawne odświeżania
        }

        private void editMenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
