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

namespace fibbonaci
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
        ObservableCollection<int> recurTab = new ObservableCollection<int>();
        ObservableCollection<int> iterTab = new ObservableCollection<int>();
        private void recurButton_Click(object sender, RoutedEventArgs e)
        {
            recurTab.Clear();
            int input = int.Parse(inputTextBox.Text);
            recurFunc(input);
            recurListBox.ItemsSource = recurTab;
        }
        private int recurFunc(int input)
        {
            if (input == 1 || input == 2)
            {
                return 1;
            }
            else
            {
                // dodawanie do listy
                return recurFunc(input - 2) + recurFunc(input - 1);
            }
        }
        private void iterButton_Click(object sender, RoutedEventArgs e)
        {
            iterTab.Clear();
            int input = int.Parse(inputTextBox.Text);
            if(input == 1)
            {
                iterTab.Add(1);
            }
            else if(input == 2)
            {
                iterTab.Add(1);
                iterTab.Add(1);
            }
            else
            {
                iterTab.Add(1);
                int p1 = 0;
                int p2 = 0;
                int w = 1;
                for (int i = 0; i < input - 1; i++)
                {
                    p1 = p2;
                    p2 = w;
                    w = p2 + p1;
                    iterTab.Add(w);
                }

            }
            iterListBox.ItemsSource = iterTab;
        }
    }
}
