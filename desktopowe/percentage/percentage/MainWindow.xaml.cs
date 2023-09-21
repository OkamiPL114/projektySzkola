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

namespace percentage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<double> lista = new List<double>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void obliczButton_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(podstawaTextBox.Text, out double podst);
            double.TryParse(procentTextBox.Text, out double proc);
            double wynik = (podst * proc) / 100;
            wynikTextBox.Text = $"{wynik}";
            if((bool)zapisujCheckBox.IsChecked)
            {
                listaListBox.ItemsSource = null;
                lista.Add(wynik);
                listaListBox.ItemsSource = lista;
            }
        }
    }
}
