using SQLite;
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
            if(firstNameEntry.Text.Length == 0 || lastNameEntry.Text.Length == 0 || salaryEntry.Text.Length == 0)
            {
                await DisplayAlert("Błąd", "Nieprawidłowe dane pracownika", "OK");
                return;
            }
            var firstName = firstNameEntry.Text.Trim().ToLower();
            var lastName = lastNameEntry.Text;
            float.TryParse(salaryEntry.Text, out float salary);

            if(!(firstName.Length > 0 && lastName.Length > 0 && salary > 0))
            {
                await DisplayAlert("Błąd", "Nieprawidłowe dane pracownika", "OK");
                return;
            }

            firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1);
            Employee newEmployee = new Employee() 
            {
                FirstName = firstName,
                LastName = lastName,
                Salary = salary,
            };
            
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(App.GetDBPath());
            await conn.CreateTableAsync<Employee>();
            await conn.InsertAsync(newEmployee);
            await conn.CloseAsync();

            await Navigation.PopModalAsync();
        }

        private async void cancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}