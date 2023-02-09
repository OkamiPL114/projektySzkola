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

namespace partyCost
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
        private void calculate()
        {
            int guestAmount = int.Parse(peopleAmountTextBox.Text);
            if (guestAmount < 1 || guestAmount > 20)
            {
                MessageBox.Show("Należy podać wartość pomiędzy 1 a 20");
                return;
            }
            float overallCost = guestAmount * 25;
            bool doDiscount = false;
            if (healthyCheckBox.IsChecked == true)
            {
                doDiscount = true;
                overallCost += guestAmount * 5;
            }
            else
            {
                overallCost += guestAmount * 20;
            }
            if (decorationsCheckBox.IsChecked == true)
            {
                overallCost += guestAmount * 15;
                overallCost += 50;
            }
            else
            {
                overallCost += guestAmount * 7.5F;
                overallCost += 30;
            }
            if (doDiscount)
            {
                overallCost -= (overallCost / 25);
            }
            costTextBox.Text = $"{Math.Round(overallCost, 2)}zł";
        }
        private void checkBoxes_Checked(object sender, RoutedEventArgs e)
        {
            calculate();
        }
        private void checkBoxes_Unchecked(object sender, RoutedEventArgs e)
        {
            calculate();
        }
        private void peopleAmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            calculate();
        }
    }
}

