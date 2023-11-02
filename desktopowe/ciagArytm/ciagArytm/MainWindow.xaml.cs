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

namespace ciagArytm
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

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(starterTextBox.Text, out double starter);    
            double.TryParse(differenceTextBox.Text, out double difference);    
            double.TryParse(countTextBox.Text, out double count);

            resultLabel.Content = $"{starter}";
            for(int i = 1; i < count; i++)
            {
                resultLabel.Content += $", {starter + (i * difference)}";
            }
        }
    }
}
