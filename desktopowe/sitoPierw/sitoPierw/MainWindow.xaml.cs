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
            for(int i = 0; i < sito.Length; i++)
            {
                sito[i] = true;
            }
            sito[0] = false;
            int j = 0;
            for(int i = 1; i < sito.Length; i++)
            {
                if (sito[i])
                {
                    j = i;
                    while(j < max)
                    {
                        sito[j] = true;
                        j++;
                    }
                }
            }
        }
    }
}
