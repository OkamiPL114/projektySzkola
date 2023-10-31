using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobilna
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void statuteButton_Clicked(object sender, EventArgs e)
        {
            statuteLabel.IsVisible = !statuteLabel.IsVisible;
        }

        private async void addUserButton_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string surname = surnameEntry.Text;
            string password = passwordEntry.Text;
            DateTime birthday = birthdayDatePicker.Date;
            bool statuteAccepted = statuteCheckBox.IsChecked;

            if(name.Trim().Length == 0 || surname.Trim().Length == 0 || password.Trim().Length == 0)
            {
                await DisplayAlert("Błąd", "Wypełnij wszystkie pola", "Ok");
                return;
            }

            if(DateTime.Now < birthday)
            {
                await DisplayAlert("Błąd", "Data urodzenia nie może być późniejsza niż aktualna", "Ok");
                return;
            }

            if(password.Length < 8)
            {
                await DisplayAlert("Błąd", "Hasło musi mieć conajmniej 8 znaków", "Ok");
                return;
            }
            if(password == password.ToUpper() || password == password.ToLower())
            {
                await DisplayAlert("Błąd", "Hasło musi składać się z małych oraz dużych liter", "Ok");
                return;
            }
            bool containsDigit = false;
            for(int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    containsDigit = true;
                    break;
                }
            }
            if(!containsDigit)
            {
                await DisplayAlert("Błąd", "Hasło musi zawierać cyfrę", "Ok");
                return;
            }
            User newUser = new User()
            {
                Name = name,
                Surname = surname,
                Password = password,
                Birthday = birthday,
                StatuteAccepted = statuteAccepted,
            };
            Users.users.Add(newUser);

            await DisplayAlert("Sukces", "Dodano użytkownika", "Ok");
            nameEntry.Text = "";
            surnameEntry.Text = "";
            passwordEntry.Text = "";
            birthdayDatePicker.Date = DateTime.Now;
            statuteCheckBox.IsChecked = false;
        }
    }
}