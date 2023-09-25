using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBpowtorka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployeePage : ContentPage
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private async void addButton_Clicked(object sender, EventArgs e)
        {
            var firstName = firstNameEntry.Text.Trim().ToLower();
            var lastName = lastNameEntry.Text;
            float.TryParse(salaryEntry.Text, out float salary);

            if(firstName.Length > 0 && lastName.Length > 0 && salary > 0)
            {
                await DisplayAlert("Błąd", "Nieprawidłowe dane pracownika", "OK");
                return;
            }

            firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1);
        }

        private async void cancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}