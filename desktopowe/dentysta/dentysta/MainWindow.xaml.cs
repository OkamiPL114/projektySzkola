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

namespace dentysta
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string address = addressTextBox.Text.Trim();
            if (name.Length == 0 || address.Length == 0)
            {
                MessageBox.Show("Wypełnij wszystkie dane");
                return;
            }
            int personAge = 0;
            if ((bool)seniorRadioButton.IsChecked) personAge = 1;
            if ((bool)kAyRadioButton.IsChecked) personAge = 2;
            if ((bool)adultRadioButton.IsChecked) personAge = 3;
            if (personAge == 0)
            {
                MessageBox.Show("Proszę zaznaczyć przedział wiekowy");
                return;
            }

            double price = 0;
            if ((bool)flossingCheckBox.IsChecked) price += 20;
            if ((bool)fillingCheckBox.IsChecked) price += 75;
            if ((bool)rootCanalCheckBox.IsChecked) price += 150;

            if (price == 0)
            {
                MessageBox.Show("Zaznacz jedną z usług");
                return;
            }

            double actualPrice = 0;
            switch(personAge)
            {
                case 1:
                    {
                        actualPrice = price - (price * 10 / 100);
                    };break;
                case 2:
                    {
                        actualPrice = price - (price * 15 / 100);
                    };break;
            }
            MessageBox.Show($"Całkowity koszt za usługi: ${Math.Round(actualPrice, 2)}");
        }
    }
}
