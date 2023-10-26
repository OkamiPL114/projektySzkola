using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wynajemAuta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] samochody = { "Audi", "Opel", "Volvo", "Mazda", "BMW", "Fiat", "Ford", "Honda"};
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dniSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            dniWynajmuLabel.Content = $"Ustaw liczbę dni wynajmu: {(sender as Slider).Value}";
        }

        private void zatwierdzButton_Click(object sender, RoutedEventArgs e)
        {
            string marka = markaTextBox.Text;
            int klasa = klasaComboBox.SelectedIndex;
            int dni = int.Parse(dniSlider.Value.ToString());
            if (!samochody.Contains<string>(marka))
            {
                MessageBox.Show("Nie ma takiej marki samochodu");
                return;
            }
            if(klasa < 0 || klasa > 3)
            {
                MessageBox.Show("Nieprawidłowa klasa samochodu");
                return;
            }
            if(dni < 0 || dni > 30) 
            {
                MessageBox.Show("Nieprawidłowa ilość dni");
                return;
            }
            string nazwa = $"{marka} ";
            switch(klasa)
            {
                case 0: nazwa += "ekonomiczny";break; 
                case 1: nazwa += "średni"; break;
                case 2: nazwa += "luksusowy"; break;
            }
            nazwaTextBox.Text = nazwa;
            liczbaDniTextBox.Text = $"{dni}";
            int cena = 0;
            switch (klasa)
            {
                case 0: cena = dni * 100; break;
                case 1: cena = dni * 200; break;
                case 2: cena = dni * 300; break;
            }
            cenaTextBox.Text = $"{cena}";
            int rabat = random.Next(5, 21);
            rabatTextBox.Text = $"{rabat} %";
            kosztTextBox.Text = $"{cena - ((rabat * cena) / 100)}";
        }
    }
}
