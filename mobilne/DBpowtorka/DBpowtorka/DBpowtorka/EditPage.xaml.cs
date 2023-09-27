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
    public partial class EditPage : ContentPage
    {
        public Employee employee;
        public EditPage(Employee employeeToEdit)
        {
            InitializeComponent();
            employee = employeeToEdit;

            firstNameEntry.Text = employee.FirstName;
            lastNameEntry.Text = employee.LastName;
            salaryEntry.Text = employee.Salary.ToString();
        }

        private async void confirmButton_Clicked(object sender, EventArgs e)
        {
            if (firstNameEntry.Text.Length == 0 || lastNameEntry.Text.Length == 0 || salaryEntry.Text.Length == 0)
            {
                await DisplayAlert("Błąd", "Nieprawidłowe dane pracownika", "OK");
                return;
            }
            var firstName = firstNameEntry.Text.Trim().ToLower();
            var lastName = lastNameEntry.Text;
            float.TryParse(salaryEntry.Text, out float salary);

            if (!(firstName.Trim().Length > 0 && lastName.Trim().Length > 0 && salary > 0))
            {
                await DisplayAlert("Błąd", "Nieprawidłowe dane pracownika", "OK");
                return;
            }

            firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1);
            
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Salary = salary;
            
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(App.GetDBPath());
            await conn.CreateTableAsync<Employee>();
            await conn.UpdateAsync(employee);
            await conn.CloseAsync();

            await Navigation.PopModalAsync();
        }

        private async void cancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}