using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace powtorka
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void equationButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EquationPage());
        }

        private async void aboutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}
