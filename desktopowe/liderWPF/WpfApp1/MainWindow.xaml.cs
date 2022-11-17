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

namespace WpfApp1
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
        private static int findLeader(int[] array, int length)
        {
            int currentCandidate = 0;
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (counter == 0)
                {
                    currentCandidate = array[i];
                    counter = 1;
                }
                else
                {
                    if (array[i] == currentCandidate)
                    {
                        counter++;
                    }
                    else
                    {
                        counter--;
                    }
                }
            }
            return currentCandidate;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            Random random = new Random();
            int[] array = new int[(int)numberOf.Value];
            for(int i = 0; i < numberOf.Value; i++)
            {
                array[i] = random.Next(1,4);
                listBox.Items.Add(array[i]);
            }
            
            int position = findLeader(array, (int)numberOf.Value);
            int count = 0;
            for (int i = 0; i < numberOf.Value; i++)
            {
                if (array[i] == position)
                    count = count + 1;
            }
            if (count > (numberOf.Value / 2))
                textBlock.Text = $" Liderem jest {position} \n Występuje {count} razy";
            else
                textBlock.Text = "Nie ma lidera";
        }
    }
}
