using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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

        private async void addEmployeeToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddEmployeePage());
        }
    }
}
