using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace DBpowtorka
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            employeesListView.ItemsSource = new List<Employee>()
            {
                new Employee() {FirstName="Ewa", LastName="Nowak", Salary=4200.05f},
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            refreshDb();
        }
        private async void refreshDb()
        {
            var conn = new SQLiteAsyncConnection(App.GetDBPath());
            await conn.CreateTableAsync<Employee>();
            employeesListView.ItemsSource = await conn.Table<Employee>().ToListAsync();
            await conn.CloseAsync();
        }
        private async void addEmployeeToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddEmployeePage());
        }

        private async void deleteMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var employeeToDelete = menuItem.CommandParameter as Employee;
            var conn = new SQLiteAsyncConnection(App.GetDBPath());
            await conn.CreateTableAsync<Employee>();
            
            await conn.DeleteAsync(employeeToDelete);
            
            await conn.CloseAsync();
            refreshDb();
        }

        private void editMenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
