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

namespace wpfJump
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
            int s = int.Parse(sTextBox.Text);
            int n = int.Parse(nTextBox.Text) - 1;
            string tabCandidate = $"{tabTextBox.Text},";
            string temp = "";
            int x = 0;
            int[] tabA = new int[n];
            for(int i = 0; i <= tabCandidate.Length; i++)
            {
                if(tabCandidate[i] != ',')
                {
                    temp += $"{tabCandidate[i]}";
                }else
                {
                    tabA[x] = int.Parse(temp);
                    temp = "";
                    x++;
                }
            }
            bool[] tabB = new bool[s];
            for(int i = 0; i < tabB.Length; i++)
            {
                tabB[i] = false;
            }

            //wypełnianie pól
            tabB[0] = true;
            for(int k = 1; k <= n; k++)
            {
                for(int i = s; i >= tabA[k]; i--)
                {
                    if (tabB[i - tabA[k]] && !tabB[i])
                    {
                        tabB[i] = true;
                    }
                }
            }

            //generowanie graficzne planszy
            resultLabel.Content = "";
            for(int i = 0; i < tabB.Length; i++)
            {
                resultLabel.Content += $"B{i} | ";
                if (tabB[i])
                {
                    resultLabel.Content += "X";
                }else
                {
                    resultLabel.Content += " ";
                }
                resultLabel.Content += "   ";
            }
        }
    }
}
