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

namespace rekurencjaOrazIteracja
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
        private int silniaRek(int num)
        {
            if (num == 1) return 1;
            return num * silniaRek(num - 1);
        }
        private int sumaRek(int num)
        {
            if (num == 0) return 0;
            return num + sumaRek(num - 1);
        }
        private int silniaIter(int num)
        {
            int result = 1;
            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        private int sumaIter(int num)
        {
            int result = 0;
            for (int i = 1; i <= num; i++)
            {
                result += i;
            }
            return result;
        }
        private void silniaRekButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int num);
            int result = silniaRek(num);
            MessageBox.Show($"Silnia rekurencyjnie = {result}", "Komunikat");
        }

        private void sumaRekButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int num);
            int result = sumaRek(num);
            MessageBox.Show($"Suma rekurencyjnie = {result}", "Komunikat");
        }

        private void silniaIterButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int num);
            int result = silniaIter(num);
            MessageBox.Show($"Silnia iteracyjnie = {result}", "Komunikat");
        }

        private void sumaIterButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int num);
            int result = sumaIter(num);
            MessageBox.Show($"Suma iteracyjnie = {result}", "Komunikat");
        }
    }
}
