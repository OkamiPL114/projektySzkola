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
        private ObservableCollection<Contact> contacts;
        public MainPage()
        {
            InitializeComponent();
            readDatabase();
            contactsListView.ItemsSource = contacts;
        }

        private async void addToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddContactPage());
            readDatabase();
        }
        private void readDatabase()
        {
            List<Contact> contactsList = new List<Contact>();
            using (var connection = new SQLiteConnection(App.GetDbPath()))
            {
                connection.CreateTable<Contact>();
                contactsList = connection.Table<Contact>().ToList();
            };
            contacts.Clear();
            foreach (var contact in contactsList)
            {
                contacts.Add(contact);
            }
        }
    }
}
