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

namespace wyscigChartow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int janekMoney = 200;
        public int bartekMoney = 200;
        public int arekMoney = 200;
        public int janekBet = 0;
        public int janekBetDog = 1;
        public int bartekBet = 0;
        public int bartekBetDog = 1;
        public int arekBet = 0;
        public int arekBetDog = 1;
        public int timesBetted = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void janekRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            bettingStackPanel.Visibility = Visibility.Visible;
            bartekCheckBox.IsChecked = false;
            arekCheckBox.IsChecked = false;
            if(janekBet == 0)
            {
                betAmount.Value = 5;
            }
            else
            {
                betAmount.Value = janekBet;
            }
            whoBetsLabel.Content = "Janek stawia";
        }
        private void bartekRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            bettingStackPanel.Visibility = Visibility.Visible;
            janekCheckBox.IsChecked = false;
            arekCheckBox.IsChecked = false;
            if (bartekBet == 0)
            {
                betAmount.Value = 5;
            }
            else
            {
                betAmount.Value = bartekBet;
            }
            whoBetsLabel.Content = "Bartek stawia";
        }
        private void arekRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            bettingStackPanel.Visibility = Visibility.Visible;
            janekCheckBox.IsChecked = false;
            bartekCheckBox.IsChecked = false;
            if (arekBet == 0)
            {
                betAmount.Value = 5;
            }
            else
            {
                betAmount.Value = arekBet;
            }
            whoBetsLabel.Content = "Arek stawia";
        }

        private void betAmountIntegerUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if ((bool)janekCheckBox.IsChecked)
            {
                janekBet = (int)betAmount.Value;
                if(janekBet > 0)
                {
                    janekBetTextBox.Text = $"Janek stawia {janekBet} zł na charta numer {janekBetDog}";
                }
                else
                {
                    janekBetTextBox.Text = $"Janek nie zawarł zakładu";
                }
            }
            else if ((bool)bartekCheckBox.IsChecked)
            {
                bartekBet = (int)betAmount.Value;
                if (bartekBet > 0)
                {
                    bartekBetTextBox.Text = $"Bartek stawia {bartekBet} zł na charta numer {bartekBetDog}";
                }
                else
                {
                    bartekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                }
            }
            else if ((bool)arekCheckBox.IsChecked)
            {
                arekBet = (int)betAmount.Value;
                if (arekBet > 0)
                {
                    arekBetTextBox.Text = $"Arek stawia {arekBet} zł na charta numer {arekBetDog}";
                }
                else
                {
                    arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                }
            }
        }

        private void dogNumberIntegerUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if ((bool)janekCheckBox.IsChecked)
            {
                janekBetDog = (int)dogNumber.Value;
                if (janekBet > 0)
                {
                    janekBetTextBox.Text = $"Janek stawia {janekBet} zł na charta numer {janekBetDog}";
                }
                else
                {
                    janekBetTextBox.Text = $"Janek nie zawarł zakładu";
                }
            }
            else if ((bool)bartekCheckBox.IsChecked)
            {
                bartekBet = (int)dogNumber.Value;
                if (bartekBet > 0)
                {
                    bartekBetTextBox.Text = $"Bartek stawia {bartekBet} zł na charta numer {bartekBetDog}";
                }
                else
                {
                    bartekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                }
            }
            else if ((bool)arekCheckBox.IsChecked)
            {
                arekBet = (int)dogNumber.Value;
                if (arekBet > 0)
                {
                    arekBetTextBox.Text = $"Arek stawia {arekBet} zł na charta numer {arekBetDog}";
                }
                else
                {
                    arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                }
            }
        }

        private void StartBet_Click(object sender, RoutedEventArgs e)
        {
            if(timesBetted > 0)
            {
                Random random = new Random();
                int chart1 = random.Next(1, 101);
                int chart2 = random.Next(1, 101);
                int chart3 = random.Next(1, 101);
                int chart4 = random.Next(1, 101);
                if (chart1 > chart2 && chart1 > chart3 && chart1 > chart4)
                {
                    if(janekBetDog == 1)
                    {
                        janekMoney += janekBet;
                        janekBet = 0;
                        arekBetTextBox.Text = $"Janek nie zawarł zakładu";

                    }
                    else
                    {
                        janekMoney -= janekBet;
                        janekBet = 0;
                        arekBetTextBox.Text = $"Janek nie zawarł zakładu";
                    }
                    if(bartekBetDog == 1)
                    {
                        bartekMoney += bartekBet;
                        bartekBet = 0;
                        arekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                    }
                    else
                    {
                        bartekMoney -= bartekBet;
                        bartekBet = 0;
                        arekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                    }
                    if(arekBetDog == 1)
                    {
                        arekMoney += arekBet;
                        arekBet = 0;
                        arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                    }
                    else
                    {
                        arekMoney -= arekBet;
                        arekBet = 0;
                        arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                    }
                    MessageBox.Show("Wygrał chart 1!");
                }
                else if (chart2 > chart1 && chart2 > chart3 && chart2 > chart4)
                {
                    if (janekBetDog == 2)
                    {
                        janekMoney += janekBet;
                        janekBet = 0;
                        arekBetTextBox.Text = $"Janek nie zawarł zakładu";
                    }
                    else
                    {
                        janekMoney -= janekBet;
                        janekBet = 0;
                        arekBetTextBox.Text = $"Janek nie zawarł zakładu";
                    }
                    if (bartekBetDog == 2)
                    {
                        bartekMoney += bartekBet;
                        bartekBet = 0;
                        arekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                    }
                    else
                    {
                        bartekMoney -= bartekBet;
                        bartekBet = 0;
                        arekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                    }
                    if (arekBetDog == 2)
                    {
                        arekMoney += arekBet;
                        arekBet = 0;
                        arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                    }
                    else
                    {
                        arekMoney -= arekBet;
                        arekBet = 0;
                        arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                    }
                    MessageBox.Show("Wygrał chart 2!");
                }
                else if (chart3 > chart1 && chart3 > chart2 && chart3 > chart4)
                {
                    if (janekBetDog == 3)
                    {
                        janekMoney += janekBet;
                        janekBet = 0;
                        arekBetTextBox.Text = $"Janek nie zawarł zakładu";
                    }
                    else
                    {
                        janekMoney -= janekBet;
                        janekBet = 0;
                        arekBetTextBox.Text = $"Janek nie zawarł zakładu";
                    }
                    if (bartekBetDog == 3)
                    {
                        bartekMoney += bartekBet;
                        bartekBet = 0;
                        arekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                    }
                    else
                    {
                        bartekMoney -= bartekBet;
                        bartekBet = 0;
                        arekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                    }
                    if (arekBetDog == 3)
                    {
                        arekMoney += arekBet;
                        arekBet = 0;
                        arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                    }
                    else
                    {
                        arekMoney -= arekBet;
                        arekBet = 0;
                        arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                    }
                    MessageBox.Show("Wygrał chart 3!");
                }
                else if (chart4 > chart1 && chart4 > chart2 && chart4 > chart3)
                {
                    if (janekBetDog == 4)
                    {
                        janekMoney += janekBet;
                        janekBet = 0;
                        arekBetTextBox.Text = $"Janek nie zawarł zakładu";
                    }
                    else
                    {
                        janekMoney -= janekBet;
                        janekBet = 0;
                        arekBetTextBox.Text = $"Janek nie zawarł zakładu";
                    }
                    if (bartekBetDog == 4)
                    {
                        bartekMoney += bartekBet;
                        bartekBet = 0;
                        arekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                    }
                    else
                    {
                        bartekMoney -= bartekBet;
                        bartekBet = 0;
                        arekBetTextBox.Text = $"Bartek nie zawarł zakładu";
                    }
                    if (arekBetDog == 4)
                    {
                        arekMoney += arekBet;
                        arekBet = 0;
                        arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                    }
                    else
                    {
                        arekMoney -= arekBet;
                        arekBet = 0;
                        arekBetTextBox.Text = $"Arek nie zawarł zakładu";
                    }
                    MessageBox.Show("Wygrał chart 4!");
                }
            }
            else
            {
                MessageBox.Show("Koniec zakładów");
            }
        }
    }
}
