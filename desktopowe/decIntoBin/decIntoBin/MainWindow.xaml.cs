using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace decIntoBin
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
            ObservableCollection<int> tab = new ObservableCollection<int>();
            int number = int.Parse(decimalTextBox.Text);
            int i = 0;
            while(number > 0)
            {
                if (number < 1 && number > 0)
                    break;
                tab.Add(number % 2);
                number = number / 2;
                i++;
            }
            binaryListBox.ItemsSource = tab;
        }
    }
}
