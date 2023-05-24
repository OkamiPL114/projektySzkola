using DBApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditContactPage : ContentPage
    {
        public EditContactPage(Contact contactToEdit)
        {
            InitializeComponent();
            emailEntry.Text = contactToEdit.Email;
            nameEntry.Text = contactToEdit.Name;
        }

        private async void editButton_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string name = nameEntry.Text;
            // tu trza dać contactToEdit
            Contact updateContact = new Contact() { Email = email, Name = name };

            //zapis do bazy
            var connection = new SQLiteAsyncConnection(App.GetDbPath());
            await connection.CreateTableAsync<Contact>();
            await connection.UpdateAsync(updateContact);
            await connection.CloseAsync();

            await Navigation.PopModalAsync();
        }
    }
}