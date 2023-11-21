using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public class Uczen
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Klasa { get; set; }
        public string Miasto { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Uczen> uczniowie = new ObservableCollection<Uczen>();
        public MainPage()
        {
            InitializeComponent();
            uczniowieListView.ItemsSource = uczniowie;
        }

        private void dodajButton_Clicked(object sender, EventArgs e)
        {
            string imie = imieEntry.Text.Trim();
            string nazwisko = nazwiskoEntry.Text.Trim();
            if (imie.Length == 0 || nazwisko.Length == 0) return;

            int klasa = int.Parse($"{klasaStepper.Value}");
            string miasto = miastoEntry.Text.Trim();
            Uczen nowyUczen = new Uczen() { Imie = imie, Nazwisko = nazwisko, Klasa = klasa, Miasto = miasto};
            uczniowie.Add(nowyUczen);

            imieEntry.Text = "";
            nazwiskoEntry.Text = "";
            klasaStepper.Value = 1;
            miastoEntry.Text = "";
        }

        private void klasaStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            klasaWartoscLabel.Text = e.NewValue.ToString();
        }

        private void uczniowieListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new UczenPage(e.SelectedItem as Uczen));
        }
    }
}
