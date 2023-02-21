using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace visited
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void loginButton_ClickedAsync(object sender, EventArgs e)
        {
            var enteredPIN = pinEntry.Text;
            foreach (var pin in PINs.Codes)
            {
                if(enteredPIN == pin)
                {
                    await Navigation.PushAsync(new MainPage());
                    return;
                }
            }
            await DisplayAlert("Błędny PIN", "Spróbuj jeszcze raz", "OK");
        }
    }
}