using DBApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace DBApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing() //uruchamia się podczas wyświetlania strony
        {
            base.OnAppearing();
            await readDatabase();
        }

        private async void addToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddContactPage());
        }
        private async Task readDatabase()
        {
            List<Contact> contactsList = new List<Contact>();
            var connection = new SQLiteAsyncConnection(App.GetDbPath());
            
            await connection.CreateTableAsync<Contact>();
            
            contactsList = await connection.Table<Contact>().ToListAsync();

            await connection.CloseAsync();

            contactsListView.ItemsSource = contactsList;
        }

        private async void deleteMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contactToDelete = menuItem.CommandParameter as Contact;
            var confirm = await DisplayAlert("Usuwanie", $"Czy na pewno chcesz usunąć kontakt: {contactToDelete.Email}?", "Tak", "Nie");
            if (!confirm)
            {
                return;
            }
            var connection = new SQLiteAsyncConnection(App.GetDbPath());

            await connection.CreateTableAsync<Contact>();

            await connection.DeleteAsync(contactToDelete);

            await connection.CloseAsync();

            await readDatabase();
        }

        protected void editMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contactToEdit = menuItem.CommandParameter as Contact;
            Navigation.PushModalAsync(new EditContactPage(contactToEdit));
        }
    }
}
