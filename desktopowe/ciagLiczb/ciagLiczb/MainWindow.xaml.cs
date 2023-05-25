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

namespace ciagLiczb
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

        private void execButton_Click(object sender, RoutedEventArgs e)
        {
            string tabCandidate = $"{tabTextBox.Text},";
            int[] tabA = new int[tabTextBox.Text.Length*2];
            for (int i = 0; i < tabA.Length; i++)
            {
                tabA[i] = 0;
            }
            int x = 0;
            string temp = "";
            for(int i = 0; i < tabCandidate.Length; i++)
            {
                if(tabCandidate[i] != ',')
                {
                    temp += tabCandidate[i];
                }
                else
                {
                    tabA[x] = int.Parse(temp);
                    x++;
                    temp = "";
                }
            }
            int[] tabB = new int[tabA.Length];
            for (int i = 0; i < tabB.Length; i++)
            {
                tabB[i] = 0;
            }
            int count = 0;
            int num = 0;
            int z = 0;
            for(int i = 0; i < tabA.Length; i++)
            {
                if(num != tabA[i])
                {
                    if(num != 0)
                    {
                        tabB[z] = count;
                        z++;
                        tabB[z] = num;
                        z++;
                    }
                    num = tabA[i];
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            string result = "Ciąg przed opisaniem: ";
            for (int i = 0; i < tabA.Length; i++)
            {
                if (tabA[i] != 0)
                {
                    result += $"{tabA[i]}";
                }
            }
            result += ". Ciąg po opisaniu: ";
            for (int i = 0; i < tabB.Length; i++)
            {
                if (tabB[i] != 0)
                {
                    result += $"{tabB[i]}";
                }
            }
            int actualLength = 0;
            for (int i = 0; i < tabB.Length; i++)
            {
                if (tabB[i] != 0)
                {
                    actualLength++;
                }
            }
            result += $". Długość opisu ciągu A: {actualLength}";
            resultTextBlock.Text = result;
        }
    }
}
