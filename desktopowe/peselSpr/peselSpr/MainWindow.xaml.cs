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

namespace peselSpr
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

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = peselTextBox.Text[i];
            }
            int controlInt = peselTextBox.Text[10];
            int multiplier = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] *= multiplier;
                nums[i] %= (10);
                switch (multiplier)
                {
                    case 1: multiplier = 3; break;
                    case 3: multiplier = 7; break;
                    case 7: multiplier = 9; break;
                    case 9: multiplier = 1; break;
                }
            }
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            sum %= (10);
            if(10 - sum == controlInt)
            {
                resultLabel.Foreground = Brushes.Green;
                resultLabel.Content = "PESEL jest poprawny!";
            }
            else
            {
                resultLabel.Foreground = Brushes.Red;
                resultLabel.Content = "PESEL nie jest poprawny!";
            }
        }
    }
}
