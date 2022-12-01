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

namespace STS___WPF
{
    public class Player
    {
        public double money { get; set; } = 100;
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player1 = new Player();
        Player player2 = new Player();
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void player1_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(player1BetTextBox.Text))
            {
                var isBetCorrect = double.TryParse(player1BetTextBox.Text, out double bet);
                if (isBetCorrect && bet > 0 && bet <= player1.money)
                {
                    if (random.NextDouble() > 0.75)
                    {
                        MessageBox.Show($"Wygrałeś {2 * bet} zł.");
                        player1.money += bet;
                        player1MoneyLabel.Content = $"Gracz 1 posiada {player1.money} zł";
                    }
                    else
                    {
                        MessageBox.Show($"Niestety, przegrałeś.");
                        player1.money -= bet;
                        player1MoneyLabel.Content = $"Gracz 1 posiada {player1.money} zł";
                    }
                }
                else if (bet <= 0)
                {
                    MessageBox.Show("Należy podać liczbę dodatnią");
                    player1BetTextBox.Text = "";
                }
                else if (bet > player1.money)
                {
                    MessageBox.Show($"Nie masz wystarczająco pieniędzy aby postawić {bet} zł");
                    player1BetTextBox.Text = "";
                }
                if (player1.money == 0 && player2.money == 0)
                    MessageBox.Show("STS zawsze wygrywa");
            }
        }

        private void player2_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(player2BetTextBox.Text))
            {
                var isBetCorrect = double.TryParse(player2BetTextBox.Text, out double bet);
                if (isBetCorrect && bet > 0 && bet <= player2.money)
                {
                    if (random.NextDouble() > 0.75)
                    {
                        MessageBox.Show($"Wygrałeś {2 * bet} zł.");
                        player2.money += bet;
                        player2MoneyLabel.Content = $"Gracz 2 posiada {player2.money} zł";
                    }
                    else
                    {
                        MessageBox.Show($"Niestety, przegrałeś.");
                        player2.money -= bet;
                        player2MoneyLabel.Content = $"Gracz 2 posiada {player2.money} zł";
                    }
                }
                else if (bet <= 0)
                {
                    MessageBox.Show("Należy podać liczbę dodatnią");
                    player2BetTextBox.Text = "";
                }
                else if (bet > player2.money)
                {
                    MessageBox.Show($"Nie masz wystarczająco pieniędzy aby postawić {bet} zł");
                    player2BetTextBox.Text = "";
                }
                if (player1.money == 0 && player2.money == 0)
                    MessageBox.Show("STS zawsze wygrywa");
            }
        }
    }
}
