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

namespace odchylenieStandardowe
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(sizeTextBox.Text, out int size);
            double[] tab = new double[size];
            string[] tab2 = elementsTextBox.Text.Split(' ');
            for(int i = 0; i < tab2.Length; i++) 
            {
                tab[i] = double.Parse(tab2[i]);
            }
            sredniaTextBox.Text = CalculateAverage(tab, size).ToString();
            odchylenieTextBox.Text = CalculateStandardDeviation(tab, size).ToString();
        }

        private double CalculateStandardDeviation(double[] numbers, int size)
        {
            double srednia = 0;
            double sum2 = 0;
            foreach (double number in numbers)
            {
                srednia += number;
            }
            srednia /= size;
            for (int i = 0; i < size; i++)
            {
                numbers[i] -= srednia;
                sum2 += Math.Pow(numbers[i], 2);
            }
            return Math.Sqrt(sum2 /= size);
        }

        private double CalculateAverage(double[] numbers, int size)
        {
            double sum = 0;
            foreach(double number in numbers)
            {
                sum += number;
            }
            return sum/size;
        }
    }
}
