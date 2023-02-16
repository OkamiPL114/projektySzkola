using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace oneHanded
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int money = 100;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(money == 0)
            {
                MessageBox.Show("Koniec środków, koniec gry!");
                App.Current.Shutdown();
            }
            Random random = new Random();
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, 10);
            int num3 = random.Next(1, 10);
            numberOneTextBox.Text = $"{num1}";
            numberTwoTextBox.Text = $"{num2}";
            numberThreeTextBox.Text = $"{num3}";
            if(num1 == 9 && num2 == 9 && num3 == 9)
            {
                money += 5000;
                moneyLabel.Content = $"Twoje saldo: {money}zł";
                resultLabel.Foreground = Brushes.Green;
                resultLabel.Content = "Zwyciężasz!";
            }
            else
            {
                money -= 5;
                moneyLabel.Content = $"Twoje saldo: {money}zł";
                resultLabel.Foreground = Brushes.Red;
                resultLabel.Content = "Przegrywasz!";
            }
        }
    }
}
