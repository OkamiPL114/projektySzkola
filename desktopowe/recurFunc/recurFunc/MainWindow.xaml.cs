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

namespace recurFunc
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

        public void sym(int a, int b)
        {
            if (a != 0)
            {
                sym(a - 1, b + 1);
                resultListBox.Items.Add(a * b);
                sym(a - 1, b + 1);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.Items.Clear();
            int.TryParse(aInput.Text, out int a);
            int.TryParse(bInput.Text, out int b);

            sym(a, b);
        }
    }
}
