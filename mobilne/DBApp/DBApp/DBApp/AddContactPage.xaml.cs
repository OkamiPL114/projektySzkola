using DBApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
        {
            InitializeComponent();
        }

        private async void addButton_Clicked(object sender, EventArgs e)
        {
            var email = emailEntry.Text;
            var name = nameEntry.Text;
            Contact newContact = new Contact() { Email = email, Name = name};

            //zapis do bazy
            var connection = new SQLiteAsyncConnection(App.GetDbPath());
            await connection.CreateTableAsync<Contact>();
            await connection.InsertAsync(newContact);
            await connection.CloseAsync();

            await Navigation.PopModalAsync();
        }
    }
}