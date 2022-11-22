using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupApp
{
    public partial class MainPage : ContentPage
    {
        private int score { get; set; }
        public MainPage()
        {
            InitializeComponent();
            score = 0;
        }

        private async void infoButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Informacje o programie", "Data wydania: 2022\nAutor: Gała", "Zamknij");
        }

        private async void likeCodingButton_Clicked(object sender, EventArgs e)
        {
            var answear = await DisplayAlert("Pytanie", "Czy lubisz programowanie?", "Tak", "Nie");
            if (answear)
                codingLabel.Text = "Uwielbiam programowanie";
            else
                codingLabel.Text = "Nie przepadam za programowaniem";
        }

        private async void favLangButton_Clicked(object sender, EventArgs e)
        {
            var favLang = await DisplayActionSheet("Wybierz ulubiony język:", "Anuluj", null, "C++", "C#", "PHP", "JavaScript", "Python");
            if(favLang != "Anuluj")
                favLangLabel.Text = "Ulubiony język: " + favLang;
        }

        private async void fastfoodButton_Clicked(object sender, EventArgs e)
        {
            var fastfood = await DisplayActionSheet("Wybierz najbardziej szkodliwy fastfood", "Wszystko jest zdrowe", "Wszystko jest niezdrowe", "Burgir", "Pica", "Fłytki");
            fastfoodLabel.Text = "Szkodiwy fastfood według ciebie: " + fastfood;
        }

        private async void mathButton_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            var number1 = random.Next(1, 101);
            var number2 = random.Next(1, 101);
            var result = await DisplayPromptAsync("Odpowiedz na pytanie", $"{number1} + {number2} = ?", "Sprawdź", "Anuluj");
            int sum = 0;
            var validResult = int.TryParse(result, out sum);
            if (!validResult)
            {
                await DisplayAlert("Błąd", "Nie podano prawidłowej wartości", "OK");
                return;
            }

            if(sum == (number1 + number2))
            {
                score++;
            }
            scoreLabel.Text = "Punkty: " + score;
        }

        private async void leapYearButton_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayPromptAsync("Sprawdź czy przestępny", "Podaj rok", "Sprawdź", "Anuluj");
            int inserted = int.Parse(result);
            if(inserted < 1 || inserted > DateTime.Now.Year)
            {
                await DisplayAlert("Błąd", "Podano nieprawidłową wartość", "OK");
                return;
            }
            if (inserted % 4 == 0)
            {
                leapYearLabel.Text = "Rok jest przestępny";
            }
            else
            {
                leapYearLabel.Text = "Rok nie jest przestępny";
            }
        }
    }
}
