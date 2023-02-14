using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fuelCalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SummaryPage : ContentPage
    {
        public SummaryPage(double liters, double price)
        {
            InitializeComponent();
            liters = Math.Round(liters);
            litersLabel.Text = $"Ilość: {liters}l";
            priceLabel.Text = $"Cena: {price}zł/l";
            summaryLabel.Text = $"Do zapłaty {price * liters}zł";
        }

        private void returnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}