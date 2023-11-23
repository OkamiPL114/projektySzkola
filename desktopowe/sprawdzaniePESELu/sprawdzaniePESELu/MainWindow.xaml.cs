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

namespace sprawdzaniePESELu
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

        private void checkPESEL_Click(object sender, RoutedEventArgs e)
        {
            string peselString = peselTextBox.Text.Trim();
            if(peselString.Length > 11 || peselString.Length < 11)
            {
                MessageBox.Show("Niepoprawny PESEL");
                return;
            }

            int sum = 0;
            int[] multiplyArr = { 1, 3, 7, 9 };
            int multiplyNum = 0;

            for(int i = 0; i < peselString.Length - 1; i++)
            {
                int num = int.Parse(peselString[i].ToString());
                if (multiplyNum < 3)
                {
                    int multiply = num * multiplyArr[multiplyNum];
                    if(multiply > 9)
                    {
                        multiply = multiply % 10;
                    }
                    sum += multiply;
                    multiplyNum++;
                }
                else
                {
                    int multiply = num * multiplyArr[multiplyNum];
                    if (multiply > 9)
                    {
                        multiply = multiply % 10;
                    }
                    sum += multiply;
                    multiplyNum = 0;
                }
            }
            if(sum > 9)
            {
                sum = sum % 10;
            }
            int checkNum = 10 - sum;
            int lastNum = int.Parse(peselString[peselString.Length - 1].ToString());
            if (checkNum == lastNum)
            {
                switch (sendLetterComboBox.SelectedIndex)
                {
                    case 0: MessageBox.Show($"{nameTextBox.Text} {surnameTextBox.Text}, wysłano list"); ; break;
                    case 1: MessageBox.Show($"{nameTextBox.Text} {surnameTextBox.Text}, nie wysłano listu"); ; break;
                }
            }
            else
            {
                MessageBox.Show($"PESEL jest niepoprawny");
            }
        }
    }
}
