using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pagesDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SumPage : ContentPage
    {
        public SumPage()
        {
            InitializeComponent();
        }
        public SumPage(float number1, float number2)
        {
            InitializeComponent();

            var result = $"{number1} + {number2} = {number1 + number2}";
            sumLabel.Text = result;
        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}