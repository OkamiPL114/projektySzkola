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

namespace gra999
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int funds = 100;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(betTextBox.Text.Trim(), out int bet))
            {
                MessageBox.Show("Zakład musi być liczbą całkowitą");
                return;
            }
            if(bet > funds)
            {
                MessageBox.Show("Nie masz wystarczająco środków żeby postawić taki zakład");
                return;
            }
            int result = random.Next(100, 1000);
            if(result == 999)
            {
                MessageBox.Show($"Wylosowano {result}, wygrałeś! Dodano 5000 zł do konta");
                funds += 5000;
                fundsLabel.Content = $"Dostępne środki: {funds} zł";
                betTextBox.Text = "";
                resultsTextBox.Text += $"{result} ";
            }
            else
            {
                MessageBox.Show($"Wylosowano {result}, przegrałeś! Odjęto 5 zł od konta");
                funds -= 5;
                fundsLabel.Content = $"Dostępne środki: {funds} zł";
                betTextBox.Text = "";
                resultsTextBox.Text += $"{result} ";
            }
            resultsTextBox.Visibility = Visibility.Visible;
            if(funds == 0)
            {
                MessageBox.Show("Brak środków - koniec gry");
                Environment.Exit(0);
            }
        }

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
