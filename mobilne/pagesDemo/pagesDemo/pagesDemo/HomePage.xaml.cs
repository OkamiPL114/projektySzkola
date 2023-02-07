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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            float.TryParse(number1Entry.Text, out float number1);
            float.TryParse(number2Entry.Text, out float number2);

            Navigation.PushAsync(new SumPage(number1, number2));
        }
    }
}