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

namespace costReturn
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            float start = float.Parse(startTextBox.Text);
            float end = float.Parse(endTextBox.Text);
            moneyToReturnLabel.Content = $"Pieniądze do zwrotu: {Math.Round((end-start)*0.39F, 2)}zł";
        }

        private void showDistanceButton_Click(object sender, RoutedEventArgs e)
        {
            float start = float.Parse(startTextBox.Text);
            float end = float.Parse(endTextBox.Text);
            MessageBox.Show($"Przebyto {end-start} kilometrów", "Przebyta odległość");
        }
    }
}
