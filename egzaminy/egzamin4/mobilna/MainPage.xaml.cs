using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            string login = loginEntry.Text;
            string password = passwordEntry.Text;
            bool isAdmin = adminRadioButton.IsChecked;
            bool isUser = userRadioButton.IsChecked;

            if (login.Trim().Length == 0 || password.Trim().Length == 0 || !isAdmin && !isUser)
            {
                await DisplayAlert("Błąd", "Wypełnij wszystkie pola", "Ok");
                return;
            }
            
            if(isAdmin)
            {
                if(loginEntry.Text.Trim() == "admin" && passwordEntry.Text.Trim() == "ZST")
                {
                    await Navigation.PushAsync(new AdminPage());
                }
                else
                {
                    await DisplayAlert("Błąd", "Błędne dane administratora", "Ok");
                    return;
                }
            }

            bool exists = false;
            User loggedUser = new User();
            if(isUser)
            {
                for(int i = 0; i < Users.users.Count; i++)
                {
                    if(Users.users[i].Name == login && Users.users[i].Password == password)
                    {
                        loggedUser = Users.users[i];
                        exists = true; 
                        break;
                    }
                }
                if(exists)
                {
                    await Navigation.PushAsync(new UserPage(loggedUser));
                }
            }
        }
    }
}
