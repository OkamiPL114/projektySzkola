using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pagesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void aboutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        private async void showBirthYearButton_Clicked(object sender, EventArgs e)
        {
            int age = int.Parse(ageEntry.Text);
            await Navigation.PushModalAsync(new AgePage(age));
        }
    }
}
