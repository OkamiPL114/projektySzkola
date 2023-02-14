using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace fuelCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void buyButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SummaryPage(literSlider.Value, priceStepper.Value));
        }
    }
}
