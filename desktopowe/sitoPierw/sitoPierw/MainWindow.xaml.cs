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

namespace sitoPierw
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
            int max = int.Parse(limitTextBox.Text);
            bool[] sito = new bool[max];
            for(int i = 1; i < max; i++)
            {
                sito[i] = true;
            }
            sito[0] = false;
            for(int i = 1; i < Math.Sqrt(max); i++)
            {
                if (sito[i])
                {
                    for(int j = (i + 1) * (i + 1); j < max+1; j += (i + 1))
                    {
                        sito[j-1] = false;
                    }
                }
            }
            string primeNums = "";
            for(int i = 1; i < max; i++)
            {
                if (sito[i])
                {
                    primeNums += $"{i + 1}, ";
                }
            }
            MessageBox.Show($"Ciąg liczb pierwszych o granicy {max}: {primeNums}");
        }
    }
}
