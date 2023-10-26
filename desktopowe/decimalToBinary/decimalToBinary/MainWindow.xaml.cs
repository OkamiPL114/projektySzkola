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

namespace decimalToBinary
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

        private void decimalTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(decimalTextBox.Text, out int dec);
            string bin = "";

            while (dec > 0)
            {
                int remainder = dec % 2;
                bin += $"{remainder}";
                dec /= 2;
            }

            char[] arr = bin.ToCharArray();
            Array.Reverse(arr);
            bin = new string(arr);
            binaryTextBox.Text = bin;
        }
    }
}
