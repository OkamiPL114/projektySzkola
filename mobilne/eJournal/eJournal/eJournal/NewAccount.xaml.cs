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
    public partial class NewAccount : ContentPage
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void createButton_Clicked(object sender, EventArgs e)
        {
            var email = emailEntry.Text;
            var password = passwordEntry.Text;
            var reEnter = reEnterEntry.Text;
            
            if(password != reEnter)
            {
                await DisplayAlert("Błąd", "Hasła nie są takie same", "OK");
                return;
            }

            var allAccounts = Users.accounts.Select(x => x.Email).ToList();

            if (allAccounts.Contains(email))
            {
                await DisplayAlert("Błąd", "Istnieje już użytkownik o takim email-u", "OK");
                return;
            }

            Users.accounts.Add(new User() { Email = email, Password = password});
            await DisplayAlert("Sukces!", "Pomyślnie utworzono nowe konto", "OK");
            await Navigation.PopAsync();
        }
    }
}