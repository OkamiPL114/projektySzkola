using System;
using System.Collections.Generic;
using System.IO;
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

namespace tajnyKod
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

        private void validateButton_Click(object sender, RoutedEventArgs e)
        {
            if(nameTextBox.Text.Trim().Length == 0 || surnameTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Wpisz imię i nazwisko");
                return;
            }
            if (!int.TryParse(codePasswordBox.Password, out int a))
            {
                MessageBox.Show("Kod może być tylko cyframi");
                return;
            }
            pictureImage.Visibility = Visibility.Visible;

            /* jak znależć lokalizację apki i dołączyć zdjęcie
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            BitmapImage img = new BitmapImage(new Uri($"{appDirectory}/images/bmw.jpg"));
            pictureImage.Source = img;
            */
        }
    }
}
