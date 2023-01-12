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

namespace wydawanieReszty
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            outputListBox.Items.Clear();
            double change = double.Parse(inputTextBox.Text);
            double[] tab = { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01};
            
            for(int i = 0; i < tab.Length; i++)
            {
                if (tab[i] <= change)
                {
                    double amount = Math.Floor(change / tab[i]);
                    change = change - (amount * tab[i]);
                    outputListBox.Items.Add($"{amount} x {tab[i]}zł");
                }
            }
            
        }
    }
}