using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eJournal
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
            await Navigation.PushAsync(new MainPage());
        }

        private async void creatteAccButton_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewAccount());
        }
    }
}