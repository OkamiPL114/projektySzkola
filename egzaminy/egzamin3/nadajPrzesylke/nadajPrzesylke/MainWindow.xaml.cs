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

namespace nadajPrzesylke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkPrice_Click(object sender, RoutedEventArgs e)
        {
            if((bool)postcardRadioButton.IsChecked)
            {
                string appDir = AppDomain.CurrentDomain.BaseDirectory; // pobierz aktualną ścieżkę na której jest zapisany program
                BitmapImage img = new BitmapImage(new Uri($"{appDir}/images/postcard.png")); // dodaj do tej ścieżki lokalizację zdjęcia
                iconImage.Source = img;
                priceLabel.Content = "Cena: 1 zł";
            }
            if ((bool)letterRadioButton.IsChecked)
            {
                string appDir = AppDomain.CurrentDomain.BaseDirectory;
                BitmapImage img = new BitmapImage(new Uri($"{appDir}/images/letter.png"));
                iconImage.Source = img;
                priceLabel.Content = "Cena: 1,5 zł";
            }
            if ((bool)packageRadioButton.IsChecked)
            {
                string appDir = AppDomain.CurrentDomain.BaseDirectory;
                BitmapImage img = new BitmapImage(new Uri($"{appDir}/images/package.png"));
                iconImage.Source = img;
                priceLabel.Content = "Cena: 10 zł";
            }
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            if(postcodeTextBox.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                return;
            }
            for(int i = 0; i < postcodeTextBox.Text.Length; i++)
            {
                if (!Char.IsDigit(postcodeTextBox.Text[i]))
                {
                    MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                    return;
                }
            }
            MessageBox.Show("Dane przesyłki zostały wprowadzone");

        }
    }
}
