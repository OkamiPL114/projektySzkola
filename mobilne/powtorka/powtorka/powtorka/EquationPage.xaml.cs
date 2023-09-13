using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace powtorka
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EquationPage : ContentPage
	{
		public EquationPage ()
		{
			InitializeComponent ();
		}

        private void calcButton_Clicked(object sender, EventArgs e)
        {
			if(!float.TryParse(aEntry.Text, out float a) || a == 0)
			{
				DisplayAlert("Błąd", "Parametr A nie może być 0", "OK");
                return;
			}
            if (!float.TryParse(bEntry.Text, out float b))
            {
                DisplayAlert("Błąd", "Parametr B musi być liczbą", "OK");
                return;
            }
            if (!float.TryParse(cEntry.Text, out float c))
            {
                DisplayAlert("Błąd", "Parametr C musi być liczbą", "OK");
                return;
            }
            float result = (float)Math.Pow(b, 2) - 4 * a * c;
            resultEntry.Text = $"b² - 4 * a * c = {result}; ";
            if(result > 0)
            {
                resultEntry.Text += $"√Δ = {Math.Sqrt(result)}";
            }
        }
    }
}